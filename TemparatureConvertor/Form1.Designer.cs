namespace TemparatureConvertor
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
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCtoF = new System.Windows.Forms.Label();
            this.lblFtoC = new System.Windows.Forms.Label();
            this.txtCtoF = new System.Windows.Forms.TextBox();
            this.txtFtoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(501, 11);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(75, 23);
            this.btnFtoC.TabIndex = 0;
            this.btnFtoC.Text = "Convert";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(501, 42);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(75, 23);
            this.btnCtoF.TabIndex = 1;
            this.btnCtoF.Text = "Convert";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(455, 120);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(121, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Create List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a Temparature in F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a Temparature in C";
            // 
            // lblCtoF
            // 
            this.lblCtoF.AutoSize = true;
            this.lblCtoF.Location = new System.Drawing.Point(311, 48);
            this.lblCtoF.Name = "lblCtoF";
            this.lblCtoF.Size = new System.Drawing.Size(12, 17);
            this.lblCtoF.TabIndex = 5;
            this.lblCtoF.Text = " ";
            // 
            // lblFtoC
            // 
            this.lblFtoC.AutoSize = true;
            this.lblFtoC.Location = new System.Drawing.Point(314, 17);
            this.lblFtoC.Name = "lblFtoC";
            this.lblFtoC.Size = new System.Drawing.Size(12, 17);
            this.lblFtoC.TabIndex = 6;
            this.lblFtoC.Text = " ";
            // 
            // txtCtoF
            // 
            this.txtCtoF.Location = new System.Drawing.Point(187, 43);
            this.txtCtoF.Name = "txtCtoF";
            this.txtCtoF.Size = new System.Drawing.Size(100, 22);
            this.txtCtoF.TabIndex = 7;
            // 
            // txtFtoC
            // 
            this.txtFtoC.Location = new System.Drawing.Point(186, 13);
            this.txtFtoC.Name = "txtFtoC";
            this.txtFtoC.Size = new System.Drawing.Size(100, 22);
            this.txtFtoC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFtoC);
            this.Controls.Add(this.txtCtoF);
            this.Controls.Add(this.lblFtoC);
            this.Controls.Add(this.lblCtoF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.btnFtoC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCtoF;
        private System.Windows.Forms.Label lblFtoC;
        private System.Windows.Forms.TextBox txtCtoF;
        private System.Windows.Forms.TextBox txtFtoC;
        private System.Windows.Forms.Label label3;
    }
}

