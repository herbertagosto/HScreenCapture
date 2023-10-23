using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HScreenCaptureDemo
{
    public partial class Form1 : Form
    {
        private HScreenCapture.Main hsc = new HScreenCapture.Main();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var image = hsc.GetImage(textBox1.Text, textBox2.Text);
            SaveToClipboardOrFile(image);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var image = hsc.GetImage();
            SaveToClipboardOrFile(image);
        }

        private void SaveToClipboardOrFile(Image image)
        {
            if (radioButton1.Checked)
            {
                hsc.SaveToClipboard(image);
            }
            else
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png";
                sfd.Title = "Save an Image File";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    hsc.SaveToPNG(sfd.FileName, image);
                }
            }
        }
    }
}
