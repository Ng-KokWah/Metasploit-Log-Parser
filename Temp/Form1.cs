using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<string> FindLinesContaining(string filePath, string searchText)
        {
            List<string> lines = new List<string>();
            try
            {
                string[] contents = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < contents.Length; i++)
                {
                    if (searchText.ToLower() == "meterpreter")
                    {
                        Regex regex = new Regex(@"\b" + searchText + @"\s+>");
                        if (regex.IsMatch(contents[i]))
                        {
                            Regex checkBackground = new Regex(@"\bbg\b"); // Use a regular expression to match standalone "bg"
                            Regex checkhelp = new Regex(@"\bhelp\b"); // Use a regular expression to match standalone "help"

                            if (checkBackground.IsMatch(contents[i + 1]) || checkhelp.IsMatch(contents[i + 1]))
                            {
                                continue;
                            }
                            else
                            {
                                lines.Add(contents[i + 1].Replace("[", ""));
                            }
                        }
                    }
                    else
                    {
                        if (contents[i].ToLower().Contains(searchText))
                        {
                            lines.Add(contents[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading log file: " + ex.Message);
            }
            return lines;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                file1.Text = file;
            }
        }

        private void checkOnFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOnFilter.Checked)
            {
                tbText.Enabled = true;
                tbText.Text = "meterpreter";
            }
            else
            {
                tbText.Enabled = false;
                tbText.Text = "";
            }

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            // Write file using StreamWriter
            using (StreamWriter writer = new StreamWriter("output.log"))
            {
                if (output.Lines.Length > 0)
                {
                    for (int i = 0; i < output.Lines.Length; i++)
                    {
                        writer.WriteLine(output.Lines[i]);
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string file = file1.Text;
            if (checkOnFilter.Checked && tbText.Enabled == true)
            {
                List<string> temp = FindLinesContaining(file, tbText.Text);

                //add in the filename so that if needed we can still traceback
                //added the ] so that later when we add this file to excel we can just use the ] as a separation delimeter
                output.Text += Path.GetFileName(file) + "]\r\n";
                //added this so that you can keep track of the files that you have added into the output
                tbAdded.Text += Path.GetFileName(file) + "\r\n";

                for (int i = 0; i < temp.Count; i++)
                    output.Text += temp[i] + "\r\n";
            }
            else
            {
                output.Text += Path.GetFileName(file) + "]\r\n";
                try
                {
                    string[] contents = System.IO.File.ReadAllLines(file);
                    for (int i = 0; i < contents.Length; i++)
                    {
                        output.Text += contents[i] + "\r\n";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading log file: " + ex.Message);
                }
            }
        }
    }
}
