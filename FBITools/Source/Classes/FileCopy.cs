using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GNX;
using GNX.Desktop;

namespace FBITools
{
    public class FileCopy
    {
        [Flags]
        public enum Filters
        {
            AllFiles = 0,
            PDF = 1,
            Microsoft_Excel = 2,
            Microsoft_Word = 4
        }

        Dictionary<Filters, string> filterMap = new Dictionary<Filters, string>
        {
            { Filters.AllFiles, "All Files (*.*)|*.*" },
            { Filters.PDF, "PDF (*.pdf)|*.pdf" },
            { Filters.Microsoft_Excel, "Microsoft Excel (*.xls, *.xlsx)|*.xls;*.xlsx" },
            { Filters.Microsoft_Word, "Microsoft Word (*.doc, *.docx)|*.doc;*.docx" }
        };

        Filters _Filter { get; set; }
        public Filters Filter
        {
            get
            {
                return _Filter;
            }
            set
            {
                _Filter = value;
                dlgDestinationCustom.Filter = GetFilter(value);
                dlgDestinationCustom.FilterIndex = 2;
            }
        }

        OpenFileDialog dlgOrigin;

        string _OriginPath;
        public string OriginPath
        {
            get
            {
                return _OriginPath;
            }
            set
            {
                _OriginPath = value;
                UpdateOrigin();
            }
        }
        public string OriginFolder { get; set; }
        public string OriginFile { get; set; }

        FolderPicker dlgDestination { get; set; }
        SaveFileDialog dlgDestinationCustom { get; set; }

        string _DestinationPath;
        public string DestinationPath
        {
            get
            {
                return _DestinationPath;
            }
            set
            {
                _DestinationPath = value;
                UpdateDestination();
            }
        }
        public string DestinationFolder { get; set; }
        public string DestinationFile { get; set; }

        public bool Overwrite { get; set; }
        public bool CustomName { get; set; }
        public bool MakeBackup { get; set; }

        public FileCopy()
        {
            dlgOrigin = new OpenFileDialog
            {
                ValidateNames = true,
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = ""
            };

            dlgDestination = new FolderPicker
            {
            };

            dlgDestinationCustom = new SaveFileDialog
            {
            };

            Filter = Filters.AllFiles;

            Overwrite = true;
            OriginFile = string.Empty;
        }

        string GetFilter(Filters value)
        {
            string filter = string.Empty;

            foreach (var kvp in filterMap)
            {
                if ((value & kvp.Key) == kvp.Key)
                {
                    if (!string.IsNullOrEmpty(filter))
                        filter += "|";

                    filter += kvp.Value;
                }
            }

            return filter;
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
                    return true;
                }
                return false;
            }

            dlgDestination.InputPath = DestinationFolder;
            if (dlgDestination.InputPath == null)
                dlgDestination.InputPath = dlgOrigin.InitialDirectory;

            if (dlgDestination.ShowDialog() == true)
            {
                DestinationPath = (Path.Combine(dlgDestination.ResultPath, OriginFile)).NormalizePath();
                return true;
            }
            return false;
        }

        public bool Copy()
        {
            if (string.IsNullOrWhiteSpace(OriginPath) || string.IsNullOrWhiteSpace(DestinationPath)
            || OriginPath == DestinationPath)
            {
                return false;
            }

            var exist = File.Exists(DestinationPath);
            var canCopy = !exist || Overwrite;

            if (MakeBackup)
            {
                return BackupFile(OriginPath, DestinationPath);
            }
            else if (canCopy)
            {
                File.Copy(OriginPath, DestinationPath, Overwrite);
                return true;
            }

            return false;
        }

        bool BackupFile(string origin, string destination)
        {
            var backupNumber = 1;
            var s = DestinationPath;

            var folder = Path.GetDirectoryName(s);
            var name = Path.GetFileNameWithoutExtension(s);
            var ext = Path.GetExtension(s);

            var exist = File.Exists(destination);

            while (exist)
            {
                var backupString = "-back-" + backupNumber.ToString().PadLeft(0, '0') + "";
                var fullName = name + backupString + ext;
                var fullPath = Path.Combine(folder, fullName).NormalizePath();

                exist = File.Exists(fullPath);
                if (exist)
                    backupNumber++;
                else
                    File.Move(DestinationPath, fullPath);
            }

            File.Copy(OriginPath, DestinationPath);
            return true;
        }

        void UpdateOrigin()
        {
            if (string.IsNullOrWhiteSpace(OriginPath)) return;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(OriginPath);
            dlgOrigin.FileName = Path.GetFileName(OriginPath);

            OriginFolder = dlgOrigin.InitialDirectory;
            OriginFile = dlgOrigin.FileName;
        }

        void UpdateDestinationFile()
        {
            if (string.IsNullOrWhiteSpace(DestinationPath) == false)
                DestinationPath = (Path.Combine(Path.GetDirectoryName(DestinationPath), OriginFile)).NormalizePath();
            else if (CustomName)
                dlgDestinationCustom.FileName = dlgOrigin.FileName;
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
    }
}