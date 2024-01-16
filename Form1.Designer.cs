namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumLabel = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.logicSumBTN = new System.Windows.Forms.Button();
            this.boolSumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(41, 39);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 20);
            this.sumLabel.TabIndex = 0;
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(15, 91);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(125, 27);
            this.inputTB.TabIndex = 1;
            // 
            // logicSumBTN
            // 
            this.logicSumBTN.Location = new System.Drawing.Point(172, 89);
            this.logicSumBTN.Name = "logicSumBTN";
            this.logicSumBTN.Size = new System.Drawing.Size(103, 29);
            this.logicSumBTN.TabIndex = 2;
            this.logicSumBTN.Text = "Подсчитать";
            this.logicSumBTN.UseVisualStyleBackColor = true;
            this.logicSumBTN.Click += new System.EventHandler(this.logicSumBTN_Click);
            // 
            // boolSumLabel
            // 
            this.boolSumLabel.AutoSize = true;
            this.boolSumLabel.Location = new System.Drawing.Point(15, 141);
            this.boolSumLabel.Name = "boolSumLabel";
            this.boolSumLabel.Size = new System.Drawing.Size(0, 20);
            this.boolSumLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boolSumLabel);
            this.Controls.Add(this.logicSumBTN);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.sumLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sumLabel;
        private TextBox inputTB;
        private Button logicSumBTN;
        private Label boolSumLabel;
    }
}