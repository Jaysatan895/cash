namespace cash
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pencilImput = new System.Windows.Forms.TextBox();
            this.paperImput = new System.Windows.Forms.TextBox();
            this.eraserImput = new System.Windows.Forms.TextBox();
            this.subOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printOutput = new System.Windows.Forms.Label();
            this.printOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of pencils";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of erasers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(247, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(4, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of paper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(32, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(32, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(32, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subtotal";
            // 
            // pencilImput
            // 
            this.pencilImput.Location = new System.Drawing.Point(102, 19);
            this.pencilImput.Name = "pencilImput";
            this.pencilImput.Size = new System.Drawing.Size(100, 20);
            this.pencilImput.TabIndex = 7;
            // 
            // paperImput
            // 
            this.paperImput.Location = new System.Drawing.Point(102, 74);
            this.paperImput.Name = "paperImput";
            this.paperImput.Size = new System.Drawing.Size(100, 20);
            this.paperImput.TabIndex = 8;
            // 
            // eraserImput
            // 
            this.eraserImput.Location = new System.Drawing.Point(102, 48);
            this.eraserImput.Name = "eraserImput";
            this.eraserImput.Size = new System.Drawing.Size(100, 20);
            this.eraserImput.TabIndex = 9;
            // 
            // subOutput
            // 
            this.subOutput.AutoSize = true;
            this.subOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subOutput.Location = new System.Drawing.Point(167, 170);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(35, 13);
            this.subOutput.TabIndex = 10;
            this.subOutput.Text = "label8";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalOutput.Location = new System.Drawing.Point(167, 245);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(41, 13);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.Text = "label10";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxOutput.Location = new System.Drawing.Point(167, 206);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(41, 13);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.Text = "label11";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(102, 113);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(275, 30);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printOutput
            // 
            this.printOutput.AutoSize = true;
            this.printOutput.Location = new System.Drawing.Point(37, 285);
            this.printOutput.Name = "printOutput";
            this.printOutput.Size = new System.Drawing.Size(41, 13);
            this.printOutput.TabIndex = 21;
            this.printOutput.Text = "label10";
            // 
            // printOutput2
            // 
            this.printOutput2.AutoSize = true;
            this.printOutput2.Location = new System.Drawing.Point(37, 310);
            this.printOutput2.Name = "printOutput2";
            this.printOutput2.Size = new System.Drawing.Size(35, 13);
            this.printOutput2.TabIndex = 22;
            this.printOutput2.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printOutput2);
            this.Controls.Add(this.printOutput);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.eraserImput);
            this.Controls.Add(this.paperImput);
            this.Controls.Add(this.pencilImput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pencilImput;
        private System.Windows.Forms.TextBox paperImput;
        private System.Windows.Forms.TextBox eraserImput;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label printOutput;
        private System.Windows.Forms.Label printOutput2;
    }
}

