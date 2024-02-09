using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoSauce.MagicScaler;
using GNX;
using GNX.Desktop;

namespace FBITools
{
    public partial class ImageResizeController
    {
        FileBackup ImageFile;
        ProcessImageSettings ImageSettings;

        public ImageResizeController(ImageResizeForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            ImageFile = new FileBackup
            {
                CustomName = true,
                MakeBackup = true
            };

            ImageSettings = new ProcessImageSettings
            {
                Width = 128,
                Height = 128,
                ResizeMode = CropScaleMode.Stretch,
                EncoderOptions = new PngEncoderOptions(PngFilter.None, false),
                Interpolation = InterpolationSettings.Average,
            };

            CarregarCombos();

            btnOrigin.Click += (s, e) =>
            {
                if (ImageFile.PickOrigin())
                {
                    var imageOrigin = BitmapExtension.SuperFastLoad(ImageFile.OriginPath);
                    picDrop.Image = imageOrigin;

                    if (imageOrigin.Size.Width <= picDrop.Width && imageOrigin.Size.Height <= picDrop.Height)
                        picDrop.SizeMode = PictureBoxSizeMode.CenterImage;
                    else
                        picDrop.SizeMode = PictureBoxSizeMode.Zoom;

                    PreencherCampos();
                }
            };

            btnDestination.Click += (s, e) =>
            {
                if (ImageFile.PickDestination()) PreencherCampos();
            };

            btnResize.Click += async (s, e) =>
            {
                if (ImageFile.Copy())
                {
                    await Task.Run(() =>
                    {
                        MagicImageProcessor.ProcessImage(ImageFile.OriginPath, ImageFile.DestinationPath, ImageSettings);
                    });

                    lblWarning.ForeColorType = LabelType.success;
                    lblWarning.Text = "MagicScaler Executed!";

                    var imageResized = BitmapExtension.SuperFastLoad(ImageFile.DestinationPath);
                    picResized.Image = imageResized;

                    if (imageResized.Size.Width <= picResized.Width && imageResized.Size.Height <= picResized.Height)
                        picResized.SizeMode = PictureBoxSizeMode.CenterImage;
                    else
                        picResized.SizeMode = PictureBoxSizeMode.Zoom;
                }
            };

            ImageFile.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "MagicScaler Failed!";
            };
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        void CarregarCombos()
        {
            LoadComboEncoder(cboEncoder);
            LoadComboResizeMode(cboResizeMode);
            LoadComboColorProfile(cboColorProfile);
        }

        void PreencherCampos()
        {
            if (string.IsNullOrWhiteSpace(ImageFile.DestinationPath) == false)
            {
                string outputFile = Path.GetFileNameWithoutExtension(ImageFile.DestinationPath);
                switch (cboEncoder.SelectedIndex)
                {
                    case 0: outputFile += ".png"; break;
                    case 1: outputFile += ".jpg"; break;
                }
                outputFile = Path.Combine(ImageFile.DestinationFolder, outputFile);
                ImageFile.DestinationPath = outputFile.NormalizePath();
            }

            txtOrigin.Text = ImageFile.OriginPath;
            txtDestination.Text = ImageFile.DestinationPath;

            //Session.Options.SaveState_Origin = ImageFile.OriginPath;
            //Session.Options.SaveState_Destination = ImageFile.DestinationPath;
        }

        public void LoadComboEncoder(FlatComboBox cbo)
        {
            var encoders = new ListBind<ListItem>
            {
                new ListItem{ Text="Png", Value=0},
                new ListItem{ Text="Jpg", Value=1}
            };

            cbo.DisplayMember = "Text";
            cbo.ValueMember = "Value";
            cbo.DataSource = encoders;
            cbo.SelectedIndex = 0;

            cbo.SelectedIndexChanged += cboEncoder_SelectedIndexChanged;
        }

        public void LoadComboResizeMode(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(CropScaleMode));
            cbo.SelectedIndex = 0;

            cbo.SelectedIndexChanged += (s, e) =>
            {
                ImageSettings.ResizeMode = (CropScaleMode)cbo.SelectedItem;
            };
        }

        public void LoadComboColorProfile(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(ColorProfileMode));
            cbo.SelectedIndex = 0;

            cbo.SelectedIndexChanged += (s, e) =>
            {
                ImageSettings.ColorProfileMode = (ColorProfileMode)cbo.SelectedItem;
            };
        }

        void cboEncoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = sender as FlatComboBoxNew;
            switch (cbo.SelectedIndex)
            {
                case 0:
                    ImageSettings.EncoderOptions = new PngEncoderOptions(PngFilter.None, false);
                    break;
                case 1:
                    ImageSettings.EncoderOptions = new JpegEncoderOptions(98, ChromaSubsampleMode.Subsample444, true);
                    break;
            }
            PreencherCampos();
        }
    }
}