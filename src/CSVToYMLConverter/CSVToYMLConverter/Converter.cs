//*******************************************************************************************************
//
// Generator    - CSV to YML
// Purpose      - It is used for generating JSS based content files such as en.yml
// Developed by - Surendra Sharma, Ashish Modgal, Manikantha Surya manikyala rao Vankayala
// Date         - Mar 6 2021
//
//*******************************************************************************************************

#region Namespaces

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#endregion

namespace CSVToYMLConverter
{
    /// <summary>
    /// CSV to YML
    /// </summary>
    public partial class Converter : Form
    {
        #region Constructor
        public Converter()
        {
            InitializeComponent();

            //txtTargetJSSFolderPath.Text = @"D:\Projects\Hackathon\CSVToYMLConverter\CSVToYMLConverter\Template\MyTestFolder";
            //txtCSVFile.Text = @"D:\Projects\Hackathon\CSVToYMLConverter\CSVToYMLConverter\Template\ArticleMigrationTemplate.csv";
            //txtYMLFile.Text = @"D:\Projects\Hackathon\CSVToYMLConverter\CSVToYMLConverter\Template\en.yml";
        }

        #endregion

        #region Variables
        string lanagugeBaseFileName = @"\en.yml";
        #endregion

        #region Private Methods

        /// <summary>
        /// Read CSV file and get its record
        /// </summary>
        /// <param name="populateFields"></param>
        private void ReadCSV(bool populateFields = false)
        {
            var path = txtCSVFile.Text;

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                //csvParser.ReadLine();
                string[] fieldColumnname = csvParser.ReadFields();

                if (populateFields)
                {
                    ddlCSVFieldNames.Items.AddRange(fieldColumnname);
                    if (ddlCSVFieldNames.Items != null && ddlCSVFieldNames.Items.Count > 0)
                    {
                        ddlCSVFieldNames.SelectedIndex = 0;
                    }
                    return;
                }

                txtMessage.Text = "";
                int counter = 1;

                while (!csvParser.EndOfData)
                {
                    try
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();

                        string title = fields[ddlCSVFieldNames.SelectedIndex];

                        string id = Regex.Replace(title, @"[^0-9a-zA-Z_\s]", string.Empty);
                        id = id.Replace(" ", "-");

                        txtMessage.Text += counter + ".  " + title + System.Environment.NewLine;

                        counter++;

                        string newTargetDirectory = txtTargetJSSFolderPath.Text + @"\" + id;

                        if (Directory.Exists(newTargetDirectory))
                        {
                            Directory.Delete(newTargetDirectory, true);
                        }

                        Directory.CreateDirectory(newTargetDirectory);

                        string targetFile = newTargetDirectory + lanagugeBaseFileName;

                        File.Copy(txtYMLFile.Text, targetFile);

                        //ReplaceWord(targetFile, id, fields);

                        Dictionary<string, string> fieldDictionary = new Dictionary<string, string>();
                        for (int i = 0; i < fieldColumnname.Count(); i++)
                        {
                            fieldDictionary.Add(fieldColumnname[i], fields[i]);
                        }

                        //ReplaceWord(newTargetDirectory, id, fields, fieldDictionary);
                        ReadMapFile(targetFile, fields, fieldDictionary);

                    }
                    catch (Exception ex)
                    {
                        txtError.Text += csvParser.LineNumber + "----" + ex.Message + System.Environment.NewLine + System.Environment.NewLine;
                    }
                }
            }
        }

        /// <summary>
        /// Process each CSV file record and generate the YML file
        /// </summary>
        /// <param name="targetFile"></param>
        /// <param name="fields"></param>
        /// <param name="csvFieldDict"></param>
        private void ReadMapFile(string targetFile, string[] fields, Dictionary<string, string> csvFieldDict)
        {

            string filepath = txtYMLFile.Text;

            using (var reader = new StreamReader(filepath))
            {
                try
                {
                    string text = File.ReadAllText(targetFile);

                    foreach (var csvcolumn in csvFieldDict)
                    {
                        text = text.Replace("{{" + csvcolumn.Key + "}}", csvcolumn.Value);
                    }

                    File.WriteAllText(targetFile, text);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }

        #endregion

        #region Events

        /// <summary>
        /// Browse CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCSVFile_Click(object sender, EventArgs e)
        {
            if (openCSVFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCSVFile.Text = openCSVFileDialog.FileName;
                ReadCSV(true);
            }
        }

        /// <summary>
        /// Browse YML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYMLFile_Click(object sender, EventArgs e)
        {
            if (openYMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtYMLFile.Text = openYMLFileDialog.FileName;
            }
        }

        /// <summary>
        /// Specify Target location where to generate en.yml files. Typically it should be you JSS Application routes folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTargetJSSFolderPath_Click(object sender, EventArgs e)
        {
            if (folderJSSTargetBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtTargetJSSFolderPath.Text = folderJSSTargetBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Read and Process each CSV file record to generate the YML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtError.Text = "";

            if (ddlCSVFieldNames.SelectedIndex == -1)
            {
                MessageBox.Show("Kindly select field for item name.");
                ddlCSVFieldNames.Focus();
            }

            lanagugeBaseFileName = string.IsNullOrEmpty(txtLanguageCode.Text.Trim()) ? "en.yml" : txtLanguageCode.Text.Trim() + ".yml";
            lanagugeBaseFileName = @"\" + lanagugeBaseFileName;

            ReadCSV();
        }

        #endregion
    }
}
