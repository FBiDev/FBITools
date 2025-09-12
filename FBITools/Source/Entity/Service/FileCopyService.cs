using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class FileCopyService
    {
        private readonly FileBackup file;

        public FileCopyService()
        {
            file = new FileBackup();

            file.Copied += OnCopied;
            file.InvalidFile += OnInvalidFile;
            file.TimerRunningChanged += OnTimerRunningChanged;
        }

        public event Action<string, LabelType> StatusChanged;

        public event Action<bool, string> TimerStateChanged;

        public string OriginPath
        {
            get { return file.OriginPath; }
        }

        public string DestinationPath
        {
            get { return file.DestinationPath; }
        }

        public bool IsTimer
        {
            get { return file.IsTimer; }
        }

        public string ButtonMessage
        {
            get { return file.ButtonMessage; }
        }

        public void LoadOptions()
        {
            if (Options.IsLoaded)
            {
                file.OriginPath = Session.Options.FileCopy_Origin;
                file.DestinationPath = Session.Options.FileCopy_Destination;
                file.CustomDestination = Session.Options.FileCopy_CustomDestination;
                file.TimerValue = Session.Options.FileCopy_Timer;
                file.Type = Session.Options.FileCopy_Type;
            }
        }

        public void LoadComboBoxData(FlatComboBox typeComboBox, FlatComboBox timerComboBox)
        {
            file.LoadTypes(typeComboBox);
            file.LoadTimer(timerComboBox);
        }

        public void SaveOptions()
        {
            Session.Options.FileCopy_Origin = file.OriginPath;
            Session.Options.FileCopy_Destination = file.DestinationPath;
            Session.Options.FileCopy_CustomDestination = file.CustomDestination;
            Session.Options.FileCopy_Type = file.Type;
            Session.Options.FileCopy_Timer = file.TimerValue;
            Session.Options.Update();
        }

        public bool PickOrigin()
        {
            return file.PickOrigin();
        }

        public bool PickDestination()
        {
            return file.PickDestination();
        }

        public void SetCustomDestination(bool value)
        {
            file.CustomDestination = value;
        }

        public void SetType(int type)
        {
            file.Type = type;
        }

        public void SetTimer(int timer)
        {
            file.TimerValue = timer;
        }

        public bool Copy()
        {
            if (!file.Copy())
            {
                return false;
            }

            if (file.TimerIsRunning)
            {
                file.StartBackupTimer().TryAwait();
            }

            return true;
        }

        private void OnInvalidFile()
        {
            if (StatusChanged != null)
            {
                StatusChanged(file.ErrorMessage, LabelType.danger);
            }
        }

        private void OnCopied()
        {
            if (StatusChanged != null)
            {
                StatusChanged(file.SuccessMessage, LabelType.success);
            }
        }

        private void OnTimerRunningChanged()
        {
            if (TimerStateChanged != null)
            {
                TimerStateChanged(file.TimerIsRunning, file.ButtonMessage);
            }

            if (StatusChanged != null)
            {
                StatusChanged(file.SuccessMessage, LabelType.primary);
            }
        }
    }
}