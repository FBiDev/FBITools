using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoSauce.MagicScaler;
using GNX;
using GNX.Desktop;

namespace FBITools
{
    public class MagicScaler
    {
        #region main
        public enum EncoderOptions
        {
            Png = 0,
            Jpg = 1
        }

        public enum Sizes
        {
            NESHalf_128x112,
            PS1Cover_512x512,
            PS2Cover_360x512
        }

        public enum Interpolation
        {
            Average,
            CatmullRom,
            Cubic,
            CubicSmoother,
            Hermite,
            Lanczos,
            Linear,
            Mitchell,
            NearestNeighbor,
            Quadratic,
            Spline36,
        }

        EncoderOptions EncoderSelected;
        public ProcessImageSettings Settings;
        public event Action Resized = delegate { };

        PngFilter PngFilter = PngFilter.Unspecified;
        bool PngInterlace;

        int JpgQuality = 98;
        ChromaSubsampleMode JpgChromaSubsample = ChromaSubsampleMode.Subsample444;

        string ImageFormats = "Image Formats (*.jpg, *.jpeg, *.png, *.bmp, *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;";

        public MagicScaler()
        {
            Settings = new ProcessImageSettings
            {
                Width = 64,
                Height = 64
                //ResizeMode = CropScaleMode.Stretch,
                //EncoderOptions = new PngEncoderOptions(PngFilter.Unspecified, false),
                //EncoderOptions = new JpegEncoderOptions(98, ChromaSubsampleMode.Subsample444, true),
                //Interpolation = InterpolationSettings.Average,
                //Anchor = CropAnchor.Center,
                //BlendingMode = GammaMode.Linear,
                //HybridMode = HybridScaleMode.FavorQuality,
            };

            SetEncoderPNG();

            dlgOrigin = new OpenFileDialog
            {
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = "",
                Filter = ImageFormats
            };

            dlgDestinationCustom = new SaveFileDialog
            {
                Filter = ImageFormats
            };

            CustomName = true;
            OriginFile = string.Empty;
        }

        public async Task<bool> Resize()
        {
            if (IsInvalidInputs())
                return false;

            await Task.Run(() =>
            {
                MagicImageProcessor.ProcessImage(OriginPath, DestinationPath, Settings);
            });

            Resized();
            return true;
        }
        #endregion

        #region LoadCombos
        public event Action EncoderChanged = delegate { };
        public delegate void BoolAction(bool enable);
        public event BoolAction EnableAnchor = delegate { };

        public void LoadEncoders(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(EncoderOptions));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                var innerCombo = s as FlatComboBoxNew;
                var cboItem = (EncoderOptions)innerCombo.SelectedItem;

                switch (cboItem)
                {
                    case EncoderOptions.Png:
                        EncoderSelected = EncoderOptions.Png;
                        SetEncoderPNG();
                        break;
                    case EncoderOptions.Jpg:
                        EncoderSelected = EncoderOptions.Jpg;
                        SetEncoderJPG();
                        break;
                }

                if (string.IsNullOrWhiteSpace(DestinationPath)) return;

                SetExtension();

                EncoderChanged();
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadResizeModes(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(CropScaleMode));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                var cboItem = (CropScaleMode)cbo.SelectedItem;

                Settings.ResizeMode = cboItem;
                EnableAnchor(cboItem == CropScaleMode.Crop);
            };

            cbo.SelectedIndex = 2;
        }

        public void LoadSizes(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(Sizes));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                var innerCombo = s as FlatComboBoxNew;
                var cboItem = (Sizes)innerCombo.SelectedItem;

                switch (cboItem)
                {
                    case Sizes.NESHalf_128x112:
                        Settings.Width = 128;
                        Settings.Height = 112;
                        break;
                    case Sizes.PS1Cover_512x512:
                        Settings.Width = 512;
                        Settings.Height = 512;
                        break;
                    case Sizes.PS2Cover_360x512:
                        Settings.Width = 360;
                        Settings.Height = 512;
                        break;
                }
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadAnchors(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(CropAnchor));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.Anchor = (CropAnchor)cbo.SelectedItem;
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadMatteColors(FlatComboBox cbo)
        {
            var colors = new ListBind<KnownColor>
            {
                KnownColor.Transparent, KnownColor.Magenta, KnownColor.Black, KnownColor.White
            };

            cbo.DataSource = colors;

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.MatteColor = Color.FromKnownColor((KnownColor)cbo.SelectedItem);
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadInterpolations(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(Interpolation));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                switch ((Interpolation)cbo.SelectedItem)
                {
                    case Interpolation.Average: Settings.Interpolation = InterpolationSettings.Average; break;
                    case Interpolation.CatmullRom: Settings.Interpolation = InterpolationSettings.CatmullRom; break;
                    case Interpolation.Cubic: Settings.Interpolation = InterpolationSettings.Cubic; break;
                    case Interpolation.CubicSmoother: Settings.Interpolation = InterpolationSettings.CubicSmoother; break;
                    case Interpolation.Hermite: Settings.Interpolation = InterpolationSettings.Hermite; break;
                    case Interpolation.Lanczos: Settings.Interpolation = InterpolationSettings.Lanczos; break;
                    case Interpolation.Linear: Settings.Interpolation = InterpolationSettings.Linear; break;
                    case Interpolation.Mitchell: Settings.Interpolation = InterpolationSettings.Mitchell; break;
                    case Interpolation.NearestNeighbor: Settings.Interpolation = InterpolationSettings.NearestNeighbor; break;
                    case Interpolation.Quadratic: Settings.Interpolation = InterpolationSettings.Quadratic; break;
                    case Interpolation.Spline36: Settings.Interpolation = InterpolationSettings.Spline36; break;
                }
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadBlendingModes(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(GammaMode));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.BlendingMode = (GammaMode)cbo.SelectedItem;
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadSharpen(FlatComboBox cbo)
        {
            cbo.DataSource = new ListBind<bool> { true, false };

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.Sharpen = (bool)cbo.SelectedItem;
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadColorProfiles(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(ColorProfileMode));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.ColorProfileMode = (ColorProfileMode)cbo.SelectedItem;
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadHybridModes(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(HybridScaleMode));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                Settings.HybridMode = (HybridScaleMode)cbo.SelectedItem;
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadPngFilters(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(PngFilter));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                PngFilter = (PngFilter)cbo.SelectedItem;
                SetEncoderPNG();
            };

            cbo.SelectedIndex = 0;
        }

        public void LoadPngInterlaces(FlatComboBox cbo)
        {
            cbo.DataSource = new ListBind<bool> { false, true };

            cbo.SelectedIndexChanged += (s, e) =>
            {
                PngInterlace = (bool)cbo.SelectedItem;

            };

            cbo.SelectedIndex = 0;
        }

        public void LoadJpgQuality(FlatComboBox cbo)
        {
            cbo.DataSource = Enumerable.Range(1, 100).ToList();

            cbo.SelectedIndexChanged += (s, e) =>
            {
                JpgQuality = (int)cbo.SelectedItem;
                SetEncoderJPG();
            };

            cbo.SelectedIndex = 97;
        }

        public void LoadJpgChromaSubsample(FlatComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(ChromaSubsampleMode));

            cbo.SelectedIndexChanged += (s, e) =>
            {
                JpgChromaSubsample = (ChromaSubsampleMode)cbo.SelectedItem;
                SetEncoderJPG();
            };

            cbo.SelectedIndex = 0;
        }

        public void SetEncoderJPG()
        {
            Settings.EncoderOptions = new JpegEncoderOptions(JpgQuality, JpgChromaSubsample);
        }

        public void SetEncoderPNG()
        {
            Settings.EncoderOptions = new PngEncoderOptions(PngFilter, PngInterlace);
        }
        #endregion

        #region OriginFileAndDestination
        public event Action InvalidFile = delegate { };

        bool CustomName { get; set; }

        OpenFileDialog dlgOrigin;
        SaveFileDialog dlgDestinationCustom { get; set; }

        string _OriginPath;
        public string OriginPath
        {
            get { return _OriginPath; }
            set
            {
                _OriginPath = value;
                UpdateOrigin();
            }
        }
        public string OriginFolder { get; set; }
        public string OriginFile { get; set; }

        string _DestinationPath;
        public string DestinationPath
        {
            get { return _DestinationPath; }
            set
            {
                _DestinationPath = value;
                UpdateDestination();
            }
        }
        public string DestinationFolder { get; set; }
        public string DestinationFile { get; set; }

        void UpdateOrigin()
        {
            if (string.IsNullOrWhiteSpace(OriginPath)) return;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(OriginPath);
            dlgOrigin.FileName = Path.GetFileName(OriginPath);

            OriginFolder = dlgOrigin.InitialDirectory;
            OriginFile = dlgOrigin.FileName;
        }

        void UpdateDestination()
        {
            if (string.IsNullOrWhiteSpace(DestinationPath)) return;

            if (CustomName)
            {
                dlgDestinationCustom.InitialDirectory = Path.GetDirectoryName(DestinationPath);
                dlgDestinationCustom.FileName = Path.GetFileName(DestinationPath);

                DestinationFolder = Path.GetDirectoryName(DestinationPath);
                DestinationFile = dlgDestinationCustom.FileName;
                return;
            }

            DestinationFolder = Path.GetDirectoryName(DestinationPath);
            DestinationFile = Path.GetFileName(DestinationPath);
        }

        public bool PickOrigin()
        {
            bool result;

            if (result = dlgOrigin.ShowDialog() == DialogResult.OK)
            {
                OriginPath = dlgOrigin.FileName.NormalizePath();
                UpdateDestinationFile();
            }

            return result;
        }

        void UpdateDestinationFile()
        {
            if (string.IsNullOrWhiteSpace(DestinationPath) == false)
                DestinationPath = (Path.Combine(Path.GetDirectoryName(DestinationPath), OriginFile)).NormalizePath();
            else if (CustomName)
                dlgDestinationCustom.FileName = dlgOrigin.FileName;
        }

        public bool PickDestination()
        {
            if (CustomName)
            {
                dlgDestinationCustom.InitialDirectory = DestinationFolder;
                if (dlgDestinationCustom.InitialDirectory == null)
                    dlgDestinationCustom.InitialDirectory = dlgOrigin.InitialDirectory;

                if (dlgDestinationCustom.ShowDialog() == DialogResult.OK)
                {
                    DestinationPath = dlgDestinationCustom.FileName.NormalizePath();

                    SetExtension();

                    return true;
                }
                return false;
            }
            return false;
        }

        void SetExtension()
        {
            var newDestination = Path.GetFileNameWithoutExtension(DestinationPath);
            newDestination += "." + EncoderSelected.ToString().ToLower();
            newDestination = Path.Combine(DestinationFolder, newDestination);

            DestinationPath = newDestination.NormalizePath();
        }

        bool IsInvalidInputs()
        {
            if (string.IsNullOrWhiteSpace(OriginPath) || string.IsNullOrWhiteSpace(DestinationPath)
            || OriginPath == DestinationPath)
            {
                InvalidFile();
                return true;
            }
            return false;
        }
        #endregion
    }
}