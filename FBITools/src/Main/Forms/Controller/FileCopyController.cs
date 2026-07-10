using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class FileCopyController
    {
        private readonly FileBackup _file;

        public FileCopyController()
        {
            _file = new FileBackup();

            _file.Copied += OnCopied;
            _file.InvalidFile += OnInvalidFile;
            _file.TimerRunningChanged += OnTimerRunningChanged;
        }

        public event Action<LabelType, string> StatusChanged;

        public event Action<bool, string> TimerStateChanged;

        public string OriginPath
        {
            get { return _file.OriginPath; }
        }

        public string DestinationPath
        {
            get { return _file.DestinationPath; }
        }

        public bool IsTimer
        {
            get { return _file.IsTimer; }
        }

        public string ButtonMessage
        {
            get { return _file.ButtonMessage; }
        }

        public void LoadComboBoxData(FlatComboBox typeComboBox, FlatComboBox timerComboBox)
        {
            _file.LoadTypes(typeComboBox);
            _file.LoadTimer(timerComboBox);
        }

        public void LoadOptions()
        {
            if (Options.IsLoaded)
            {
                _file.OriginPath = Session.Options.FileCopyOrigin;
                _file.DestinationPath = Session.Options.FileCopyDestination;
                _file.CustomDestination = Session.Options.FileCopyCustomDestination;
                _file.TimerValue = Session.Options.FileCopyTimer;
                _file.Type = Session.Options.FileCopyType;
            }
        }

        public void SaveOptions()
        {
            Session.Options.FileCopyOrigin = _file.OriginPath;
            Session.Options.FileCopyDestination = _file.DestinationPath;
            Session.Options.FileCopyCustomDestination = _file.CustomDestination;
            Session.Options.FileCopyType = _file.Type;
            Session.Options.FileCopyTimer = _file.TimerValue;
            Session.Options.Update();
        }

        public bool PickOrigin()
        {
            return _file.PickOrigin();
        }

        public bool PickDestination()
        {
            return _file.PickDestination();
        }

        public void SetCustomDestination(bool value)
        {
            _file.CustomDestination = value;
        }

        public void SetType(int type)
        {
            _file.Type = type;
        }

        public void SetTimer(int timer)
        {
            _file.TimerValue = timer;
        }

        public bool Copy()
        {
            if (!_file.Copy())
            {
                return false;
            }

            if (_file.TimerIsRunning)
            {
                _file.StartBackupTimer().TryAwait();
            }

            return true;
        }

        private void OnInvalidFile()
        {
            StatusChanged.Run(LabelType.danger, _file.ErrorMessage);
        }

        private void OnCopied()
        {
            StatusChanged.Run(LabelType.success, _file.SuccessMessage);
        }

        private void OnTimerRunningChanged()
        {
            TimerStateChanged.Run(_file.TimerIsRunning, _file.ButtonMessage);

            StatusChanged.Run(LabelType.primary, _file.SuccessMessage);
        }
    }
}