using System;
using System.Drawing;
using App.Core;
using App.Core.Desktop;
using App.Image;

namespace FBITools
{
    public class ImageResizeController
    {
        private readonly MagicScaler scaler;

        public ImageResizeController()
        {
            scaler = new MagicScaler();

            scaler.EncoderChanged += OnEncoderChanged;
            scaler.EnableAnchor += OnResizeModeCrop;
            scaler.InvalidFile += OnInvalidFile;
            scaler.Resized += OnResized;
        }

        public event Action<string, LabelType> StatusChanged;

        public event Action Resized;

        public event BoolAction ResizeModeCrop;

        public event Action EncoderChanged;

        public string ImgPath
        {
            get { return scaler.ImgPath; }
        }

        public string OutPath
        {
            get { return scaler.OutPath; }
        }

        public void LoadComboBoxData(
            FlatComboBox encoderComboBox,
            FlatComboBox resizeModeComboBox,
            FlatComboBox sizesComboBox,
            FlatComboBox anchorComboBox,
            FlatComboBox interpolationComboBox,
            FlatComboBox matteColorComboBox,
            FlatComboBox colorProfileComboBox,
            FlatComboBox sharpenComboBox,
            FlatComboBox blendingModeComboBox,
            FlatComboBox hybridModeComboBox,
            FlatComboBox jpgQualityComboBox,
            FlatComboBox jpgChromaSubsampleComboBox,
            FlatComboBox pngFilterComboBox,
            FlatComboBox pngInterlaceComboBox)
        {
            scaler.LoadEncoders(encoderComboBox);
            scaler.LoadResizeModes(resizeModeComboBox);
            scaler.LoadSizes(sizesComboBox);

            scaler.LoadAnchors(anchorComboBox);
            scaler.LoadInterpolations(interpolationComboBox);

            scaler.LoadMatteColors(matteColorComboBox);
            scaler.LoadColorProfiles(colorProfileComboBox);

            scaler.LoadSharpen(sharpenComboBox);
            scaler.LoadBlendingModes(blendingModeComboBox);
            scaler.LoadHybridModes(hybridModeComboBox);

            scaler.LoadJpgQuality(jpgQualityComboBox);
            scaler.LoadJpgChromaSubsample(jpgChromaSubsampleComboBox);

            scaler.LoadPngFilters(pngFilterComboBox);
            scaler.LoadPngInterlaces(pngInterlaceComboBox);
        }

        public bool PickImg()
        {
            return scaler.PickImg();
        }

        public bool PickOut()
        {
            return scaler.PickOut();
        }

        public Bitmap GetImgBitmap()
        {
            return BitmapExtension.SuperFastLoad(ImgPath);
        }

        public Bitmap GetOutBitmap()
        {
            return BitmapExtension.SuperFastLoad(OutPath);
        }

        public void Resize()
        {
            scaler.Resize().TryAwait();
        }

        private void OnEncoderChanged()
        {
            EncoderChanged.Run();
        }

        private void OnResizeModeCrop(bool isCrop)
        {
            ResizeModeCrop.Run(isCrop);
        }

        private void OnInvalidFile()
        {
            StatusChanged.Run(scaler.ErrorMessage, LabelType.danger);
        }

        private void OnResized()
        {
            Resized.Run();

            StatusChanged.Run(scaler.SuccessMessage, LabelType.success);
        }
    }
}