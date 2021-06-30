namespace Static
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFarenheit = new System.Windows.Forms.RadioButton();
            this.rdbCelcius = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select converter direction";
            // 
            // rdbFarenheit
            // 
            this.rdbFarenheit.AutoSize = true;
            this.rdbFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFarenheit.Location = new System.Drawing.Point(89, 93);
            this.rdbFarenheit.Name = "rdbFarenheit";
            this.rdbFarenheit.Size = new System.Drawing.Size(151, 21);
            this.rdbFarenheit.TabIndex = 1;
            this.rdbFarenheit.TabStop = true;
            this.rdbFarenheit.Text = "Celcius to Farenheit";
            this.rdbFarenheit.UseVisualStyleBackColor = true;
            this.rdbFarenheit.CheckedChanged += new System.EventHandler(this.rdbFarenheit_CheckedChanged);
            // 
            // rdbCelcius
            // 
            this.rdbCelcius.AutoSize = true;
            this.rdbCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelcius.Location = new System.Drawing.Point(88, 120);
            this.rdbCelcius.Name = "rdbCelcius";
            this.rdbCelcius.Size = new System.Drawing.Size(155, 21);
            this.rdbCelcius.TabIndex = 2;
            this.rdbCelcius.TabStop = true;
            this.rdbCelcius.Text = "Farenheit to Celcius ";
            this.rdbCelcius.UseVisualStyleBackColor = true;
            this.rdbCelcius.CheckedChanged += new System.EventHandler(this.rdbCelcius_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(76, 178);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(155, 23);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(243, 178);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblAnswer.TabIndex = 4;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(73, 158);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(172, 17);
            this.lblEnter.TabIndex = 5;
            this.lblEnter.Text = "Please select a converter.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rdbCelcius);
            this.Controls.Add(this.rdbFarenheit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFarenheit;
        private System.Windows.Forms.RadioButton rdbCelcius;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblEnter;
    }
}

