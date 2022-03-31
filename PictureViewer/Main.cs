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
                      
            var files = DeserializeFromFile();
            
            foreach (var item in files)
               {
                    var filePath = item.FilePath;
                   if (!string.IsNullOrWhiteSpace(filePath))
                    {
                        pbImage.Image = Image.FromFile(filePath);
                        btnRemovePicture.Visible = true;
                    }  
                    else
                        btnRemovePicture.Visible = false;
                }                                                          
        }
               
        public void SerializeToFile(List<Files> files)
      {
            var serializer = new XmlSerializer(typeof(List<Files>));
           
           using (var streamwriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamwriter, files);
                streamwriter.Close();
            }
        }

        public List<Files> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))           
                return new List<Files>();            

            var serializer = new XmlSerializer(typeof(List<Files>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var files = (List<Files>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return files;
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

                var filePath = openFileDialog1.FileName;
                var files = new List<Files>();
                files.Add(new Files { FilePath = filePath});
                SerializeToFile(files);

                btnRemovePicture.Visible = true;
            } 
        }
          
        private void RemovePicture()
        {
            pbImage.Image = null;
            var files = new List<Files>();
            files.Add(new Files { FilePath = null});
            SerializeToFile(files);
            btnRemovePicture.Visible = false;
        }
    }
}
