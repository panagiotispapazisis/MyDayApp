using System.Diagnostics;

namespace MyDayApp
{
    public partial class Form1 : Form
    {
        private string LQFolderPath = string.Empty;
        private List<FileInfo> LQFiles = new List<FileInfo>();

        private string HQFolderPath = string.Empty;
        private List<FileInfo> HQFiles = new List<FileInfo>();

        private string FinalFolderPath = string.Empty;
        private string FinalMatchingImagesFolderName = "FinalMatchingImages";

        private List<FileInfo> matchingFiles = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();

            LQPath.TextChanged += CheckListsFilled;
            HQPath.TextChanged += CheckListsFilled;
        }

        private void LQButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    LQFolderPath = folderDialog.SelectedPath;
                    LQPath.Text = LQFolderPath;
                    LQFiles = GetLQFilesInFolder(LQFolderPath);
                    TotalFiles.Text = LQFiles.Count.ToString();
                    CheckListsFilled(sender, e);
                }
            }
        }

        private List<FileInfo> GetLQFilesInFolder(string LQFolderPath)
        {
            List<FileInfo> LQFiles = new List<FileInfo>();
            string[] LQFilePaths = Directory.GetFiles(LQFolderPath);
            foreach (string LQFilePath in LQFilePaths)
            {
                FileInfo LQFile = new FileInfo(LQFilePath);
                LQFiles.Add(LQFile);
            }
            return LQFiles;
        }

        private void HQButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    HQFolderPath = folderDialog.SelectedPath;
                    HQPath.Text = HQFolderPath;
                    HQFiles = GetHQFilesInFolder(HQFolderPath);
                    CheckListsFilled(sender, e);
                }
            }
        }

        private List<FileInfo> GetHQFilesInFolder(string HQFolderPath)
        {
            List<FileInfo> HQFiles = new List<FileInfo>();
            string[] HQFilePaths = Directory.GetFiles(HQFolderPath);
            foreach (string HQFilePath in HQFilePaths)
            {
                FileInfo HQFile = new FileInfo(HQFilePath);
                HQFiles.Add(HQFile);
            }
            return HQFiles;
        }

        private void CheckListsFilled(object sender, EventArgs e)
        {
            if (LQFiles.Count > 0 && HQFiles.Count > 0)
            {
                matchingFiles = FindMatchingFiles(HQFiles, LQFiles);
            }
        }

        private List<FileInfo> FindMatchingFiles(List<FileInfo> fileList1, List<FileInfo> fileList2)
        {
            List<FileInfo> matchingFiles = new List<FileInfo>();

            foreach (FileInfo file1 in fileList1)
            {
                string file1NameLower = Path.GetFileNameWithoutExtension(file1.Name).ToLower();

                foreach (FileInfo file2 in fileList2)
                {
                    string file2NameLower = Path.GetFileNameWithoutExtension(file2.Name).ToLower();

                    if (file1NameLower == file2NameLower)
                    {
                        matchingFiles.Add(file1);
                        break;
                    }
                }
            }

            return matchingFiles;
        }


        private void FinalButton_Click(object sender, EventArgs e)
        {
            if (matchingFiles.Count > 0 && !string.IsNullOrEmpty(HQFolderPath))
            {
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string folderName = $"FinalMatchingImages_{timestamp}";

                string destinationFolderPath = Path.Combine(HQFolderPath, folderName);
                Directory.CreateDirectory(destinationFolderPath);

                foreach (FileInfo file in matchingFiles)
                {
                    string destinationPath = Path.Combine(destinationFolderPath, file.Name);
                    File.Copy(file.FullName, destinationPath, true);
                }

                string message = $"Ο Νέος Φάκελος Δημιουργήθηκε με Επιτυχία: {destinationFolderPath}";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                try
                {
                    Process.Start("explorer.exe", destinationFolderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while opening the folder: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Δεν Υπάρχουν Αντιστοιχίες ή Δεν Έχετε Διαλέξει Τους Φακέλους ή οι Κάποιος Φάκελος Είναι κενός.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}