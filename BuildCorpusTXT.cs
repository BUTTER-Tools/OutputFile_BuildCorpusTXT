using PluginContracts;
using System.Drawing;
using System.Windows.Forms;
using TSOutputWriter;
using OutputHelperLib;
using System.Collections.Generic;
using System;
using System.IO;



namespace BuildCorpusTXT
{
    [Serializable]
    public class BuildCorpusTXT : OutputPlugin
    {

        public string[] InputType { get; } = { "String" };
        public string OutputType { get; } = "Corpus File";

        public bool KeepStreamOpen { get; } = true;
        public ThreadsafeOutputWriter Writer { get; set;  }
        public Dictionary<int, string> OutputHeaderData { get; set; }
        public bool headerWritten { get; set; } = false;
        public bool InheritHeader { get; } = true;
        public FileMode fileMode { get; set; } = FileMode.Create;

        


        #region IPlugin Details and Info
        public string PluginName { get; } = "Build Corpus File (.txt)";
        public string PluginType { get; } = "Save Output File(s)";
        public string PluginVersion { get; } = "1.0.3";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "This plugin will save all of your texts to a single .txt file. Useful for creating a single file that contains your entire corpus -- for example, setting up your texts to be analyzed with word2vec." + Environment.NewLine + Environment.NewLine +
                                                   "Each line in your corpus file should contain a single text -- as such, you should almost always preprocess the texts that you want to aggregate into a corpus file using something like the Whitespace Tokenizer at the very least. This will remove linebreaks, etc., from your texts to ensure that they comply to the format of a BUTTER corpus file.";
        public string PluginTutorial { get; } = "https://youtu.be/NJVrDUa3xEg";
        public bool TopLevel { get; } = false;


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }
        #endregion


        #region Settings and ChangeSettings() Method

        public string OutputLocation { get; set; } = "";
        public string SelectedEncoding { get; set; } = "utf-8";
        private bool LowerCase { get; set; } = true;
        private bool appendToFile { get; set; } = false;



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_BuildCorpusTXT(OutputLocation, SelectedEncoding, LowerCase, appendToFile))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;


                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedEncoding = form.SelectedEncoding;
                    OutputLocation = form.TextFileToSave;
                    LowerCase = form.LowerCase;
                    appendToFile = form.appendFileSetting;

                }
            }



        }
        #endregion


        //sets GetTextList with the files to be analyzed
        public Payload RunPlugin(Payload Input)
        {

                Payload pData = Input;

                    for (int counter = 0; counter < Input.StringList.Count; counter++)
                    {
                        if (LowerCase)
                        {
                            Writer.WriteString(Input.StringList[counter].ToLower());
                        }
                        else
                        {
                            Writer.WriteString(Input.StringList[counter]);
                        }
                    }
                
                return (new Payload());
        }

        

        public void Initialize()
        { 

            if (appendToFile)
            {
                fileMode = FileMode.Append;
            }
            else
            {
                fileMode = FileMode.Create;
            }

        }

        public void WriteHeader() { }

        public bool InspectSettings()
        {
            if (string.IsNullOrEmpty(OutputLocation))
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }

        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }



        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            OutputLocation = SettingsDict["OutputLocation"];
            SelectedEncoding = SettingsDict["SelectedEncoding"];
            LowerCase = Boolean.Parse(SettingsDict["LowerCase"]);
            appendToFile = Boolean.Parse(SettingsDict["appendToFile"]);
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("OutputLocation", OutputLocation);
            SettingsDict.Add("SelectedEncoding", SelectedEncoding);
            SettingsDict.Add("LowerCase", LowerCase.ToString());
            SettingsDict.Add("appendToFile", appendToFile.ToString());
            return (SettingsDict);
        }
        #endregion

    }



}
