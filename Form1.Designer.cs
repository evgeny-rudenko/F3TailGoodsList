namespace F3TailGoodsList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdGoods = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cbFirst1000 = new System.Windows.Forms.CheckBox();
            this.cbWithRemains = new System.Windows.Forms.CheckBox();
            this.cbWithouthImages = new System.Windows.Forms.CheckBox();
            this.goodsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 300);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1404, 409);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить БД товаров";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1431, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(201, 17);
            this.toolStripStatusLabel1.Text = "Формируем БД картинок для сайта";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel2.Text = "Текущий ИД товара ";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(243, 87);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(755, 176);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтр по наименованию";
            // 
            // textboxFilter
            // 
            this.textboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxFilter.Location = new System.Drawing.Point(243, 29);
            this.textboxFilter.Name = "textboxFilter";
            this.textboxFilter.Size = new System.Drawing.Size(755, 29);
            this.textboxFilter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Изображение товара. ";
            // 
            // tbIdGoods
            // 
            this.tbIdGoods.Location = new System.Drawing.Point(243, 271);
            this.tbIdGoods.Name = "tbIdGoods";
            this.tbIdGoods.Size = new System.Drawing.Size(755, 20);
            this.tbIdGoods.TabIndex = 12;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1021, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(313, 234);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1021, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(313, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Вставить из буфера";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1341, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 234);
            this.button6.TabIndex = 14;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbFirst1000
            // 
            this.cbFirst1000.AutoSize = true;
            this.cbFirst1000.Location = new System.Drawing.Point(12, 89);
            this.cbFirst1000.Name = "cbFirst1000";
            this.cbFirst1000.Size = new System.Drawing.Size(142, 17);
            this.cbFirst1000.TabIndex = 15;
            this.cbFirst1000.Text = "Выбрать 1000 записей";
            this.cbFirst1000.UseVisualStyleBackColor = true;
            // 
            // cbWithRemains
            // 
            this.cbWithRemains.AutoSize = true;
            this.cbWithRemains.Location = new System.Drawing.Point(12, 113);
            this.cbWithRemains.Name = "cbWithRemains";
            this.cbWithRemains.Size = new System.Drawing.Size(129, 17);
            this.cbWithRemains.TabIndex = 16;
            this.cbWithRemains.Text = "Только с остатками";
            this.cbWithRemains.UseVisualStyleBackColor = true;
            // 
            // cbWithouthImages
            // 
            this.cbWithouthImages.AutoSize = true;
            this.cbWithouthImages.Location = new System.Drawing.Point(11, 137);
            this.cbWithouthImages.Name = "cbWithouthImages";
            this.cbWithouthImages.Size = new System.Drawing.Size(95, 17);
            this.cbWithouthImages.TabIndex = 17;
            this.cbWithouthImages.Text = "Без картинок";
            this.cbWithouthImages.UseVisualStyleBackColor = true;
            // 
            // goodsListBindingSource
            // 
            this.goodsListBindingSource.DataSource = typeof(F3TailGoodsList.GoodsList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 748);
            this.Controls.Add(this.cbWithouthImages);
            this.Controls.Add(this.cbWithRemains);
            this.Controls.Add(this.cbFirst1000);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tbIdGoods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Описание товаров для сайта";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource goodsListBindingSource;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox tbIdGoods;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cbFirst1000;
        private System.Windows.Forms.CheckBox cbWithRemains;
        private System.Windows.Forms.CheckBox cbWithouthImages;
    }
}

