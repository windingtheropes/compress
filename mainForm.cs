using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Compress
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            FileInfo ifi = new FileInfo(input);
            var inMB = Decimal.Divide(ifi.Length, 1000000);

            string output = outputBox.Text;
            if (input == output)
            {
                MessageBox.Show("The input and output can't be the same.");
                return;
            }
            string crf = crfBox.Value.ToString();
            string bitrate = bitrateBox.Text;
            string args = null;
            if (crfRadio.Checked)
            {
                args = $"-y -i {input} -vcodec libx265 -crf {crf} {output}";
            }
            else if (bitrateRadio.Checked)
            {
                args = $"-y -i {input} -b {bitrate}k {output}";
            }
            else
            {
                return;
            }

            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "ffmpeg";
                p.StartInfo.Arguments = args;
                p.Start();
                p.WaitForExit();
            }

           
            FileInfo ofi = new FileInfo(output);
            var outMB = Decimal.Divide(ofi.Length, 1000000);

            MessageBox.Show($"Compression complete. Went from {inMB.ToString()}MB to {outMB.ToString()}MB.", "Compression Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inputBrowse_Click(object sender, EventArgs e)
        {
            
            
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    inputBox.Text = openFileDialog.FileName;
                    outputBox.Text = openFileDialog.FileName + "_COMPRESSED.mp4";

                }
            }

        }

    }
}
