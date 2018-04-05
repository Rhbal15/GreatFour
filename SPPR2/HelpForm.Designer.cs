namespace SPPR2
{
    partial class HelpForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Savige = new System.Windows.Forms.LinkLabel();
            this.Vald = new System.Windows.Forms.LinkLabel();
            this.Laplace = new System.Windows.Forms.LinkLabel();
            this.Hurwitz = new System.Windows.Forms.LinkLabel();
            this.HelpText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Savige);
            this.panel1.Controls.Add(this.Vald);
            this.panel1.Controls.Add(this.Laplace);
            this.panel1.Controls.Add(this.Hurwitz);
            this.panel1.Controls.Add(this.HelpText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 439);
            this.panel1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(322, 389);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 30);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(322, 389);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 30);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Закрыть справку";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Savige
            // 
            this.Savige.AutoSize = true;
            this.Savige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Savige.Location = new System.Drawing.Point(26, 117);
            this.Savige.Name = "Savige";
            this.Savige.Size = new System.Drawing.Size(293, 18);
            this.Savige.TabIndex = 3;
            this.Savige.TabStop = true;
            this.Savige.Text = "Критерий Минимального риска Сэвиджа";
            this.Savige.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Savige_LinkClicked);
            // 
            // Vald
            // 
            this.Vald.AutoSize = true;
            this.Vald.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Vald.Location = new System.Drawing.Point(26, 87);
            this.Vald.Name = "Vald";
            this.Vald.Size = new System.Drawing.Size(129, 18);
            this.Vald.TabIndex = 2;
            this.Vald.TabStop = true;
            this.Vald.Text = "Критерий Вальда";
            this.Vald.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Vald_LinkClicked);
            // 
            // Laplace
            // 
            this.Laplace.AutoSize = true;
            this.Laplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Laplace.Location = new System.Drawing.Point(26, 59);
            this.Laplace.Name = "Laplace";
            this.Laplace.Size = new System.Drawing.Size(137, 18);
            this.Laplace.TabIndex = 1;
            this.Laplace.TabStop = true;
            this.Laplace.Text = "Критерий Лапласа";
            this.Laplace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Laplace_LinkClicked);
            // 
            // Hurwitz
            // 
            this.Hurwitz.AutoSize = true;
            this.Hurwitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hurwitz.Location = new System.Drawing.Point(26, 30);
            this.Hurwitz.Name = "Hurwitz";
            this.Hurwitz.Size = new System.Drawing.Size(306, 18);
            this.Hurwitz.TabIndex = 0;
            this.Hurwitz.TabStop = true;
            this.Hurwitz.Text = "Критерий пессемизма-оптимизма Гурвица";
            this.Hurwitz.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Hurwitz_LinkClicked);
            // 
            // HelpText
            // 
            this.HelpText.Location = new System.Drawing.Point(43, 21);
            this.HelpText.Name = "HelpText";
            this.HelpText.ReadOnly = true;
            this.HelpText.Size = new System.Drawing.Size(690, 362);
            this.HelpText.TabIndex = 5;
            this.HelpText.Text = "";
            this.HelpText.Visible = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 463);
            this.Controls.Add(this.panel1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Hurwitz;
        private System.Windows.Forms.LinkLabel Laplace;
        private System.Windows.Forms.LinkLabel Vald;
        private System.Windows.Forms.LinkLabel Savige;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox HelpText;
        private System.Windows.Forms.Button Back;
    }
}