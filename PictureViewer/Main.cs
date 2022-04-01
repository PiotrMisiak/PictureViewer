using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PictureViewer
{
    public partial class Main : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "filepath.txt");
        public Main()
        {
           
            InitializeComponent();
           
            if (!File.Exists(_filePath))
            {
                pbImage.Image = null;
                btnRemovePicture.Visible = false;
            }
            else
            {
                var filePath = File.ReadAllText(_filePath);

                if (!string.IsNullOrWhiteSpace(filePath))
                {
                    pbImage.Image = Image.FromFile(filePath);
                    btnRemovePicture.Visible = true;
                }
            }
        }
               
        private void btnAddPicture_MouseClick(object sender, MouseEventArgs e)
        {                 
            AddPicture();
        }

        private void btnRemovePicture_MouseClick(object sender, MouseEventArgs e)
        {
            RemovePicture();
        }

        public void AddPicture ()
        {          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Load(openFileDialog1.FileName);
                File.WriteAllText(_filePath, openFileDialog1.FileName);              
                btnRemovePicture.Visible = true;
            } 
        }
          
        private void RemovePicture()
        {
            pbImage.Image = null;
            File.Delete(_filePath);
            btnRemovePicture.Visible = false;
        }
    }
}
