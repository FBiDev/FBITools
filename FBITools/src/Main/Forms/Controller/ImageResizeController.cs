using System;
using System.Drawing;
using App.Core;
using App.Core.Desktop;
using App.Image;

namespace FBITools
{
    public class ImageResizeController
    {
        private readonly MagicScaler _scaler;

        public ImageResizeController()
        {
            _scaler = new MagicScaler();

            _scaler.EncoderChanged += OnEncoderChanged;
            _scaler.EnableAnchor += OnResizeModeCrop;
            _scaler.InvalidFile += OnInvalidFile;
            _scaler.Resized += OnResized;
        }

        public event Action<LabelType, string> StatusChanged;

        public event Action Resized;

        public event BoolAction ResizeModeCrop;

        public event Action EncoderChanged;

        public string ImgPath
        {
            get { return _scaler.ImgPath; }
        }

        public string OutPath
        {
            get { return _scaler.OutPath; }
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
            _scaler.LoadEncoders(encoderComboBox);
            _scaler.LoadResizeModes(resizeModeComboBox);
            _scaler.LoadSizes(sizesComboBox);

            _scaler.LoadAnchors(anchorComboBox);
            _scaler.LoadInterpolations(interpolationComboBox);

            _scaler.LoadMatteColors(matteColorComboBox);
            _scaler.LoadColorProfiles(colorProfileComboBox);

            _scaler.LoadSharpen(sharpenComboBox);
            _scaler.LoadBlendingModes(blendingModeComboBox);
            _scaler.LoadHybridModes(hybridModeComboBox);

            _scaler.LoadJpgQuality(jpgQualityComboBox);
            _scaler.LoadJpgChromaSubsample(jpgChromaSubsampleComboBox);

            _scaler.LoadPngFilters(pngFilterComboBox);
            _scaler.LoadPngInterlaces(pngInterlaceComboBox);
        }

        public bool PickImg()
        {
            return _scaler.PickImg();
        }

        public bool PickOut()
        {
            return _scaler.PickOut();
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
            _scaler.Resize().TryAwait();
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
            StatusChanged.Run(LabelType.danger, _scaler.ErrorMessage);
        }

        private void OnResized()
        {
            Resized.Run();

            StatusChanged.Run(LabelType.success, _scaler.SuccessMessage);
        }
    }
}