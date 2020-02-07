namespace KEAOpgave2_2_Lommeregner
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVejledning = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.textBoxTalA = new System.Windows.Forms.TextBox();
            this.textBoxTalB = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(223, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(290, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lommeregner";
            // 
            // labelVejledning
            // 
            this.labelVejledning.AutoSize = true;
            this.labelVejledning.Location = new System.Drawing.Point(227, 119);
            this.labelVejledning.Name = "labelVejledning";
            this.labelVejledning.Size = new System.Drawing.Size(229, 25);
            this.labelVejledning.TabIndex = 1;
            this.labelVejledning.Text = "Indtast ét tal i hver box";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(232, 299);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(52, 37);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // textBoxTalA
            // 
            this.textBoxTalA.Location = new System.Drawing.Point(232, 165);
            this.textBoxTalA.Name = "textBoxTalA";
            this.textBoxTalA.Size = new System.Drawing.Size(100, 31);
            this.textBoxTalA.TabIndex = 3;
            // 
            // textBoxTalB
            // 
            this.textBoxTalB.Location = new System.Drawing.Point(232, 233);
            this.textBoxTalB.Name = "textBoxTalB";
            this.textBoxTalB.Size = new System.Drawing.Size(100, 31);
            this.textBoxTalB.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(227, 371);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 5;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(290, 299);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(52, 37);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(348, 299);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(52, 37);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(409, 299);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(52, 37);
            this.buttonDivide.TabIndex = 8;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxTalB);
            this.Controls.Add(this.textBoxTalA);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.labelVejledning);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVejledning;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBoxTalA;
        private System.Windows.Forms.TextBox textBoxTalB;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
    }
}

