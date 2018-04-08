namespace SPPR2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.FreeStyle = new System.Windows.Forms.CheckBox();
            this.LabelCell = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.LabelRow = new System.Windows.Forms.Label();
            this.RowCounter = new System.Windows.Forms.TextBox();
            this.CellCounter = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonDeleteRow = new System.Windows.Forms.Button();
            this.ButtonDeleteColumn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.NameofCritery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddColumn = new System.Windows.Forms.Button();
            this.ButtonAddRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ButtonDeleteRow);
            this.panel1.Controls.Add(this.ButtonDeleteColumn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DataGridView2);
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Controls.Add(this.ButtonAddColumn);
            this.panel1.Controls.Add(this.ButtonAddRow);
            this.panel1.Location = new System.Drawing.Point(10, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 624);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CreateMatrix);
            this.panel2.Controls.Add(this.FreeStyle);
            this.panel2.Controls.Add(this.LabelCell);
            this.panel2.Controls.Add(this.Size);
            this.panel2.Controls.Add(this.LabelRow);
            this.panel2.Controls.Add(this.RowCounter);
            this.panel2.Controls.Add(this.CellCounter);
            this.panel2.Location = new System.Drawing.Point(314, 432);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 171);
            this.panel2.TabIndex = 23;
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(31, 133);
            this.CreateMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(119, 23);
            this.CreateMatrix.TabIndex = 23;
            this.CreateMatrix.Text = "Создать матрицу";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // FreeStyle
            // 
            this.FreeStyle.AutoSize = true;
            this.FreeStyle.Location = new System.Drawing.Point(23, 28);
            this.FreeStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FreeStyle.Name = "FreeStyle";
            this.FreeStyle.Size = new System.Drawing.Size(137, 17);
            this.FreeStyle.TabIndex = 17;
            this.FreeStyle.Text = "Свободный вид ввода";
            this.FreeStyle.UseVisualStyleBackColor = true;
            this.FreeStyle.CheckedChanged += new System.EventHandler(this.FreeStyle_CheckedChanged);
            // 
            // LabelCell
            // 
            this.LabelCell.AutoSize = true;
            this.LabelCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCell.Location = new System.Drawing.Point(40, 98);
            this.LabelCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCell.Name = "LabelCell";
            this.LabelCell.Size = new System.Drawing.Size(53, 15);
            this.LabelCell.TabIndex = 22;
            this.LabelCell.Text = "Столбцы";
            this.LabelCell.Visible = false;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size.Location = new System.Drawing.Point(31, 57);
            this.Size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(80, 15);
            this.Size.TabIndex = 18;
            this.Size.Text = "Размерность:";
            this.Size.Visible = false;
            // 
            // LabelRow
            // 
            this.LabelRow.AutoSize = true;
            this.LabelRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelRow.Location = new System.Drawing.Point(49, 76);
            this.LabelRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.Size = new System.Drawing.Size(45, 15);
            this.LabelRow.TabIndex = 21;
            this.LabelRow.Text = "Строки";
            this.LabelRow.Visible = false;
            // 
            // RowCounter
            // 
            this.RowCounter.Location = new System.Drawing.Point(96, 75);
            this.RowCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RowCounter.Name = "RowCounter";
            this.RowCounter.Size = new System.Drawing.Size(29, 20);
            this.RowCounter.TabIndex = 19;
            this.RowCounter.Visible = false;
            this.RowCounter.TextChanged += new System.EventHandler(this.RowCounter_TextChanged);
            // 
            // CellCounter
            // 
            this.CellCounter.Location = new System.Drawing.Point(96, 98);
            this.CellCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CellCounter.Name = "CellCounter";
            this.CellCounter.Size = new System.Drawing.Size(29, 20);
            this.CellCounter.TabIndex = 20;
            this.CellCounter.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(781, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteRow.Location = new System.Drawing.Point(514, 15);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(109, 23);
            this.ButtonDeleteRow.TabIndex = 15;
            this.ButtonDeleteRow.Text = "Убрать строку";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteRow.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonDeleteColumn
            // 
            this.ButtonDeleteColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteColumn.Location = new System.Drawing.Point(252, 15);
            this.ButtonDeleteColumn.Name = "ButtonDeleteColumn";
            this.ButtonDeleteColumn.Size = new System.Drawing.Size(116, 23);
            this.ButtonDeleteColumn.TabIndex = 14;
            this.ButtonDeleteColumn.Text = "Убрать столбец";
            this.ButtonDeleteColumn.UseVisualStyleBackColor = true;
            this.ButtonDeleteColumn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(170, 530);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGo);
            this.groupBox1.Location = new System.Drawing.Point(22, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Матрица потерь";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Матрица прибыли";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Коэффициент оптимизма\r\nдля критерия Гурвица";
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(0, 134);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(246, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Исследовать";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameofCritery,
            this.BestVariant,
            this.Value});
            this.DataGridView2.Location = new System.Drawing.Point(513, 432);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.Size = new System.Drawing.Size(365, 171);
            this.DataGridView2.TabIndex = 10;
            this.DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            this.DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // NameofCritery
            // 
            this.NameofCritery.HeaderText = "Критерий";
            this.NameofCritery.Name = "NameofCritery";
            this.NameofCritery.ReadOnly = true;
            this.NameofCritery.Width = 180;
            // 
            // BestVariant
            // 
            this.BestVariant.HeaderText = "Лучший вариант";
            this.BestVariant.Name = "BestVariant";
            this.BestVariant.ReadOnly = true;
            this.BestVariant.Width = 70;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение критерия";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 70;
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course});
            this.DataGridView1.Location = new System.Drawing.Point(15, 42);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(863, 386);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // Course
            // 
            this.Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course.FillWeight = 120F;
            this.Course.HeaderText = "Среда №1";
            this.Course.Name = "Course";
            this.Course.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ButtonAddColumn
            // 
            this.ButtonAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddColumn.Location = new System.Drawing.Point(122, 15);
            this.ButtonAddColumn.Name = "ButtonAddColumn";
            this.ButtonAddColumn.Size = new System.Drawing.Size(113, 23);
            this.ButtonAddColumn.TabIndex = 1;
            this.ButtonAddColumn.Text = "Добавить столбец";
            this.ButtonAddColumn.UseVisualStyleBackColor = true;
            this.ButtonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
            // 
            // ButtonAddRow
            // 
            this.ButtonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddRow.Location = new System.Drawing.Point(383, 15);
            this.ButtonAddRow.Name = "ButtonAddRow";
            this.ButtonAddRow.Size = new System.Drawing.Size(112, 23);
            this.ButtonAddRow.TabIndex = 0;
            this.ButtonAddRow.Text = "Добавить строку";
            this.ButtonAddRow.UseVisualStyleBackColor = true;
            this.ButtonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click_1);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonAddColumn;
        private System.Windows.Forms.Button ButtonAddRow;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.Button ButtonDeleteColumn;
        private System.Windows.Forms.Button ButtonDeleteRow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox FreeStyle;
        private System.Windows.Forms.Label LabelCell;
        private System.Windows.Forms.Label LabelRow;
        private System.Windows.Forms.TextBox CellCounter;
        private System.Windows.Forms.TextBox RowCounter;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameofCritery;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestVariant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}

