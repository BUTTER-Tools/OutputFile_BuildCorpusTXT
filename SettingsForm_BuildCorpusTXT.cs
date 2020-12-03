using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BuildCorpusTXT
{
    internal partial class SettingsForm_BuildCorpusTXT : Form
    {


        #region Get and Set Options

        public string TextFileToSave { get; set; }
        public string SelectedEncoding { get; set; }
        public bool LowerCase { get; set; }
        public bool appendFileSetting { get; set; }

       #endregion



        public SettingsForm_BuildCorpusTXT(string TextFileDirectory, string SelectedEncoding, bool ConvertToLower, bool appendFile)
        {
            InitializeComponent();

            LowercaseCheckbox.Checked = ConvertToLower;

            foreach (var encoding in Encoding.GetEncodings())
            {
                EncodingDropdown.Items.Add(encoding.Name);
            }

            try
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact(SelectedEncoding);
            }
            catch
            {
                EncodingDropdown.SelectedIndex = EncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }
           
            SelectedFileTextbox.Text = TextFileDirectory;
            appendFileCheckbox.Checked = appendFile;

        }






        private void SetFolderButton_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Please choose the output location for your corpus file";
                dialog.FileName = "BUTTER-Corpus.txt";
                dialog.Filter = "Text File (*.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (File.Exists(dialog.FileName.ToString()))
                        {
                            if (DialogResult.Yes == MessageBox.Show("BUTTER is about to overwrite your selected file. Are you ABSOLUTELY sure that you want to do this? All data currently contained in the selected file will immediately be deleted if you select \"Yes\".", "Overwrite File?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                using (var myFile = File.Create(dialog.FileName.ToString())) { }
                                SelectedFileTextbox.Text = dialog.FileName.ToString();
                            }
                            else
                            {
                                SelectedFileTextbox.Text = "";
                            }
                        }
                        else
                        {
                            using (var myFile = File.Create(dialog.FileName.ToString())) { }
                            SelectedFileTextbox.Text = dialog.FileName.ToString();
                        }



                    }
                    catch
                    {
                        MessageBox.Show("BUTTER does not appear to be able to create this output file. Do you have write permissions for this file? Is the file already open in another program?", "Cannot Create File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SelectedFileTextbox.Text = "";
                    }
                }
            }
        }


        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.SelectedEncoding = EncodingDropdown.SelectedItem.ToString();
            this.TextFileToSave = SelectedFileTextbox.Text;
            this.LowerCase = LowercaseCheckbox.Checked;
            this.appendFileSetting = appendFileCheckbox.Checked;

            this.DialogResult = DialogResult.OK;

        }
    }
}
