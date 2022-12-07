using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

namespace F3TailGoodsList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            // Текущая папка
            string LocalFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            // проверяем есть ли папки для сохранения картинок и описаний  
            // картинки
            if (!Directory.Exists(Path.Combine(LocalFolder,  "images")))
                Directory.CreateDirectory(Path.Combine(LocalFolder , "images"));
            //описания
            if (!Directory.Exists(Path.Combine(LocalFolder,  "description")))
                Directory.CreateDirectory(Path.Combine(LocalFolder, "description"));
            // выгрузка данных справочника товаров  XML
            if (!Directory.Exists(Path.Combine(LocalFolder, "xmldb")))
                Directory.CreateDirectory(Path.Combine(LocalFolder, "xmldb"));

            InitializeComponent();

        }

        public void ReadDB (int  Firstn= 100000, bool WithQuantity=false )
        {

            ImagesListFromDir img = new ImagesListFromDir();
            

            List<F3TailRemain> remains = new List<F3TailRemain>();
                        
            toolStripStatusLabel1.Text = "Начинаю загрузку";
            GoodsList goods = new GoodsList();
            toolStripStatusLabel1.Text = "Загружено " + goods.result.F3TailRemains.Count.ToString();

            remains = goods.result.F3TailRemains.OrderBy(x=>x.NAME).ToList();


            //только с остатками
            if (cbWithRemains.Checked)
            {
                remains = remains.Where(x => x.quantity >= 1).ToList();
            }

            //фильтр по наименованию
            if (textboxFilter.Text.Length > 1)
            {
                remains = remains.Where(x => x.NAME.ToUpper().Contains(textboxFilter.Text.ToUpper())).ToList(); 
            }
            
            //Только без картинок
            if (cbWithouthImages.Checked)
            {
                remains = remains.Where(x => !img.images.Contains(x.ID_GOODS_GLOBAL.ToString())).ToList();
            }
            
            ///только первая тысяча
            if (cbFirst1000.Checked)
            {
                remains = remains.Take(1000).ToList();
            }

            
            dataGrid.DataSource = remains;  

        
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            ImagesListFromDir img = new ImagesListFromDir();
            ReadDB();

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
          



        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Data.ToString();
            if (!Directory.Exists("images"))
            {
                Directory.CreateDirectory("images");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadDB();
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

            if (this.dataGrid.RowCount > 10)
            {
                rtbDescription.Text = this.dataGrid.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();
                toolStripStatusLabel2.Text = this.dataGrid.Rows[e.RowIndex].Cells["ID_GOODS_GLOBAL"].Value.ToString();
                tbIdGoods.Text = this.dataGrid.Rows[e.RowIndex].Cells["ID_GOODS_GLOBAL"].Value.ToString();
                string LocalFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                string filename = Path.Combine(LocalFolder, "images", tbIdGoods.Text + ".jpg");
                string emptyimage = Path.Combine(LocalFolder, "empty.jpg");

                if (File.Exists (filename))
                {
                    pictureBox.Image = Image.FromFile (filename);
                }
                else
                {
                    pictureBox.Image = Image.FromFile(emptyimage);
                }

            }

        }

        
        
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {

            

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("DragEnter");

        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("Drag over");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Clipboard.GetImage();
            }
            else
            {
                MessageBox.Show("В буфере обмена нет картинки");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbIdGoods.Text.Length>0)
            {
                string LocalFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string filename = Path.Combine(LocalFolder, "images", tbIdGoods.Text + ".jpg");
                pictureBox.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GoodsList goods = new GoodsList();
            //toolStripStatusLabel1.Text = "Загружено " + goods.result.F3TailRemains.Count.ToString();
            ReadDB(WithQuantity: true);
           /// dataGrid.DataSource = goods.result.F3TailRemains.FindAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadDB(Firstn:1000);
        }
    }
}
