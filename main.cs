using System.Diagnostics;
using System.Windows.Forms;

namespace DeadlockModder
{
    public partial class main : Form
    {
        public List<string> addons = new List<string>();
        public string directory;

        public main()
        {
            InitializeComponent();
            modButton.AllowDrop = true;
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            modFileDialog.ShowDialog(this);
        }

        private void modSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            addons.Clear(); // Clear mod selection

            int i = 0;
            foreach (string name in modFileDialog.FileNames)
            {
                i++; // Increase index so it eventually prints how many addons are selected
                addons.Add(name); // Add the directory to the list
            }
            modCount.Text = "You have selected " + i + " add-on(s)";
            modButton.BackColor = Color.FromArgb(225, 255, 225);
        }

        private void directoryButtonClick(object sender, EventArgs e)
        {
            DialogResult res = directoryDialog.ShowDialog(this);
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(directoryDialog.SelectedPath))
            {
                string sel = directoryDialog.SelectedPath;
                directoryText.Text = sel;
                directory = sel;
            }
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(directory + "\\gameinfo.gi"); // Read the gameinfo.gi file

            int startI = content.IndexOf("SearchPaths");
            int endI = content.IndexOf("}", startI) + 1;

            string target = content.Substring(startI, endI - startI); // The substring of the entire SearchPaths scope

            if (!target.Contains("Mod")) // If the substring is not a modded SearchPaths scope
            {
                string modifiedContent = "SearchPaths\n\t\t{\n\t\t\tMod\t\t\t\tcitadel\n\t\t\tWrite\t\t\t\tcitadel\n\t\t\tGame\t\t\t\tcitadel/addons\n\t\t\tGame\t\t\t\tcitadel\n\t\t\tGame\t\t\t\tcore\n\t\t}";
                content = content.Replace(target, modifiedContent); // Replace the specified content with the new modified content
                File.WriteAllText(directory + "\\gameinfo.gi", content); // Write it
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("gameinfo.gi has been modified!", "Task complete", buttons);
            }
            else // If it's modded, skip it
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("gameinfo.gi has already been modified! Yippee!", "Error", buttons);
            }
        }

        private long CalculateSizeOfDirectory(DirectoryInfo directory)
        {
            long totalSizeOfDir = 0;

            // Get all files into the directory 
            FileInfo[] allFiles = directory.GetFiles();

            // Loop through every file and get size of it 
            foreach (FileInfo file in allFiles)
            {
                totalSizeOfDir += file.Length;
            }

            // Find all subdirectories 
            DirectoryInfo[] subFolders = directory.GetDirectories();

            // Return the total size of folder 
            return totalSizeOfDir;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            // Create information
            bool folderAlreadyExisted = true;
            int previouslyInstalledAddons = 0;

            string addonDir = directory + "\\addons";

            // Check if addons folder exists. If not, create it
            if (!Directory.Exists(addonDir)) {
                Directory.CreateDirectory(addonDir);
                folderAlreadyExisted = false;
            }

            // Check if there are any addons in the folder. If so, follow the numbered order
            int addonIndex = Directory.GetFiles(addonDir).Length;
            if (Directory.GetFiles(addonDir).Length > 0) previouslyInstalledAddons = Directory.GetFiles(addonDir).Length;

            // Check if the checkbox for "Clear current add-ons" is checked. If so, do it
            if (clearCheckbox.Checked)
            {
                foreach(string f in Directory.GetFiles(addonDir))
                {
                    File.Delete(f);
                    addonIndex = 0;
                }
            }

            // Copy/Move files
            int ai = 1;
            foreach (string addon in addons)
            {
                string newName = string.Format("\\pak{0:00}_dir.vpk", addonIndex + ai);
                if (moveCheckbox.Checked) File.Move(addon, addonDir + newName);
                else File.Copy(addon, addonDir + newName);
                ai++;
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            float size = MathF.Round((float)CalculateSizeOfDirectory(new DirectoryInfo(addonDir)) / (1024 * 1024), 2);
            string status = "Installation complete!\n\nFolder: " + (folderAlreadyExisted ? "Already exists" : "Created") + "\nPreviously installed addons: " + (clearCheckbox.Checked ? "Cleared by user request" : addonIndex + " addon(s)") + "\nCurrently installed addons: " + Directory.GetFiles(addonDir).Length + " addon(s)\nTotal \"addons\" folder size: " + size + " Megabytes";
            MessageBox.Show(status, "Task complete", buttons);
        }
    }
}
