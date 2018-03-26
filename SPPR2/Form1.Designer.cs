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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.NameofCritery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGo = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddColumn = new System.Windows.Forms.Button();
            this.ButtonAddRow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 780);
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
            this.panel2.Location = new System.Drawing.Point(415, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 210);
            this.panel2.TabIndex = 23;
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(41, 164);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(159, 28);
            this.CreateMatrix.TabIndex = 23;
            this.CreateMatrix.Text = "Создать матрицу";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // FreeStyle
            // 
            this.FreeStyle.AutoSize = true;
            this.FreeStyle.Location = new System.Drawing.Point(31, 34);
            this.FreeStyle.Name = "FreeStyle";
            this.FreeStyle.Size = new System.Drawing.Size(173, 21);
            this.FreeStyle.TabIndex = 17;
            this.FreeStyle.Text = "Свободный вид ввода";
            this.FreeStyle.UseVisualStyleBackColor = true;
            this.FreeStyle.CheckedChanged += new System.EventHandler(this.FreeStyle_CheckedChanged);
            // 
            // LabelCell
            // 
            this.LabelCell.AutoSize = true;
            this.LabelCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCell.Location = new System.Drawing.Point(54, 120);
            this.LabelCell.Name = "LabelCell";
            this.LabelCell.Size = new System.Drawing.Size(68, 19);
            this.LabelCell.TabIndex = 22;
            this.LabelCell.Text = "Столбцы";
            this.LabelCell.Visible = false;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size.Location = new System.Drawing.Point(41, 70);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 19);
            this.Size.TabIndex = 18;
            this.Size.Text = "Размерность:";
            this.Size.Visible = false;
            // 
            // LabelRow
            // 
            this.LabelRow.AutoSize = true;
            this.LabelRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelRow.Location = new System.Drawing.Point(65, 94);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.Size = new System.Drawing.Size(57, 19);
            this.LabelRow.TabIndex = 21;
            this.LabelRow.Text = "Строки";
            this.LabelRow.Visible = false;
            // 
            // RowCounter
            // 
            this.RowCounter.Location = new System.Drawing.Point(128, 92);
            this.RowCounter.Name = "RowCounter";
            this.RowCounter.Size = new System.Drawing.Size(37, 22);
            this.RowCounter.TabIndex = 19;
            this.RowCounter.Visible = false;
            this.RowCounter.TextChanged += new System.EventHandler(this.RowCounter_TextChanged);
            // 
            // CellCounter
            // 
            this.CellCounter.Location = new System.Drawing.Point(128, 120);
            this.CellCounter.Name = "CellCounter";
            this.CellCounter.Size = new System.Drawing.Size(37, 22);
            this.CellCounter.TabIndex = 20;
            this.CellCounter.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1056, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteRow.Location = new System.Drawing.Point(738, 19);
            this.ButtonDeleteRow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(144, 28);
            this.ButtonDeleteRow.TabIndex = 15;
            this.ButtonDeleteRow.Text = "Убрать строку";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteRow.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonDeleteColumn
            // 
            this.ButtonDeleteColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteColumn.Location = new System.Drawing.Point(420, 19);
            this.ButtonDeleteColumn.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteColumn.Name = "ButtonDeleteColumn";
            this.ButtonDeleteColumn.Size = new System.Drawing.Size(154, 28);
            this.ButtonDeleteColumn.TabIndex = 14;
            this.ButtonDeleteColumn.Text = "Убрать столбец";
            this.ButtonDeleteColumn.UseVisualStyleBackColor = true;
            this.ButtonDeleteColumn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Коэффициент оптимизма\r\nдля критерия Гурвица";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(226, 664);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 544);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(328, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 70);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Матрица потерь";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Матрица прибыли";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // DataGridView2
            // 
            this.DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameofCritery,
            this.BestVariant});
            this.DataGridView2.Location = new System.Drawing.Point(680, 544);
            this.DataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.Size = new System.Drawing.Size(487, 210);
            this.DataGridView2.TabIndex = 10;
            this.DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // NameofCritery
            // 
            this.NameofCritery.HeaderText = "Критерий";
            this.NameofCritery.Name = "NameofCritery";
            this.NameofCritery.ReadOnly = true;
            this.NameofCritery.Width = 190;
            // 
            // BestVariant
            // 
            this.BestVariant.HeaderText = "Лучший вариант";
            this.BestVariant.Name = "BestVariant";
            this.BestVariant.ReadOnly = true;
            this.BestVariant.Width = 130;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(0, 165);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(328, 28);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Исследовать";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
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
            this.DataGridView1.Location = new System.Drawing.Point(20, 53);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1147, 486);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
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
            this.ButtonAddColumn.Location = new System.Drawing.Point(262, 19);
            this.ButtonAddColumn.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddColumn.Name = "ButtonAddColumn";
            this.ButtonAddColumn.Size = new System.Drawing.Size(150, 28);
            this.ButtonAddColumn.TabIndex = 1;
            this.ButtonAddColumn.Text = "Добавить столбец";
            this.ButtonAddColumn.UseVisualStyleBackColor = true;
            this.ButtonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
            // 
            // ButtonAddRow
            // 
            this.ButtonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddRow.Location = new System.Drawing.Point(582, 19);
            this.ButtonAddRow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddRow.Name = "ButtonAddRow";
            this.ButtonAddRow.Size = new System.Drawing.Size(148, 28);
            this.ButtonAddRow.TabIndex = 0;
            this.ButtonAddRow.Text = "Добавить строку";
            this.ButtonAddRow.UseVisualStyleBackColor = true;
            this.ButtonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 810);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn NameofCritery;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestVariant;
    }
}

