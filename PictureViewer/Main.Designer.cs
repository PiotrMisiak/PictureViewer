
namespace PictureViewer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(102, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(787, 440);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPicture.Location = new System.Drawing.Point(458, 461);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 44);
            this.btnAddPicture.TabIndex = 1;
            this.btnAddPicture.Text = "Dodaj zdjęcie";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddPicture_MouseClick);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemovePicture.BackColor = System.Drawing.Color.Red;
            this.btnRemovePicture.Location = new System.Drawing.Point(900, 461);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(84, 44);
            this.btnRemovePicture.TabIndex = 2;
            this.btnRemovePicture.Text = "Usuń zdjęcie";
            this.btnRemovePicture.UseVisualStyleBackColor = false;
            this.btnRemovePicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRemovePicture_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Wybierz plik obrazu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.pbImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemovePicture, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPicture, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 521);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(PictureViewer.Main);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Text", true));
            this.Name = "Main";
            this.Text = "Przglądarka obrazów i zdjęć";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource mainBindingSource;
    }
}

