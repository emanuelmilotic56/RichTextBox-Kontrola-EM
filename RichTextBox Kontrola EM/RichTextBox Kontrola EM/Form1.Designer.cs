namespace RichTextBox_Kontrola_EM
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
            this.buttonCitaj_Click = new System.Windows.Forms.Button();
            this.buttonBrisi_Click = new System.Windows.Forms.Button();
            this.buttonSpremi_Click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCitaj_Click
            // 
            this.buttonCitaj_Click.Location = new System.Drawing.Point(150, 138);
            this.buttonCitaj_Click.Name = "buttonCitaj_Click";
            this.buttonCitaj_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonCitaj_Click.TabIndex = 0;
            this.buttonCitaj_Click.Text = "Citaj";
            this.buttonCitaj_Click.UseVisualStyleBackColor = true;
            this.buttonCitaj_Click.Click += new System.EventHandler(this.buttonCitaj_Click_Click);
            // 
            // buttonBrisi_Click
            // 
            this.buttonBrisi_Click.Location = new System.Drawing.Point(312, 138);
            this.buttonBrisi_Click.Name = "buttonBrisi_Click";
            this.buttonBrisi_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi_Click.TabIndex = 1;
            this.buttonBrisi_Click.Text = "Brisi";
            this.buttonBrisi_Click.UseVisualStyleBackColor = true;
            this.buttonBrisi_Click.Click += new System.EventHandler(this.buttonBrisi_Click_Click);
            // 
            // buttonSpremi_Click
            // 
            this.buttonSpremi_Click.Location = new System.Drawing.Point(150, 352);
            this.buttonSpremi_Click.Name = "buttonSpremi_Click";
            this.buttonSpremi_Click.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi_Click.TabIndex = 2;
            this.buttonSpremi_Click.Text = "Spremi";
            this.buttonSpremi_Click.UseVisualStyleBackColor = true;
            this.buttonSpremi_Click.Click += new System.EventHandler(this.buttonSpremi_Click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(150, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 179);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSpremi_Click);
            this.Controls.Add(this.buttonBrisi_Click);
            this.Controls.Add(this.buttonCitaj_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCitaj_Click;
        private System.Windows.Forms.Button buttonBrisi_Click;
        private System.Windows.Forms.Button buttonSpremi_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

