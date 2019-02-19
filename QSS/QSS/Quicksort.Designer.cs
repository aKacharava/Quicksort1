namespace QSS
{
    partial class Quicksort
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
            this.components = new System.ComponentModel.Container();
            this.btnQuicksort = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMin = new System.Windows.Forms.TextBox();
            this.txbMax = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuicksort
            // 
            this.btnQuicksort.Location = new System.Drawing.Point(12, 226);
            this.btnQuicksort.Name = "btnQuicksort";
            this.btnQuicksort.Size = new System.Drawing.Size(75, 23);
            this.btnQuicksort.TabIndex = 1;
            this.btnQuicksort.Text = "Quicksort";
            this.btnQuicksort.UseVisualStyleBackColor = true;
            this.btnQuicksort.Click += new System.EventHandler(this.btnQuicksort_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(12, 197);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(12, 12);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 173);
            this.lstNumbers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 998;
            this.label2.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 997;
            this.label3.Text = "Amount";
            // 
            // txbMin
            // 
            this.txbMin.Location = new System.Drawing.Point(192, 12);
            this.txbMin.Name = "txbMin";
            this.txbMin.Size = new System.Drawing.Size(100, 20);
            this.txbMin.TabIndex = 2;
            this.txbMin.Text = "0";
            this.txbMin.TextChanged += new System.EventHandler(this.txbMin_TextChanged);
            // 
            // txbMax
            // 
            this.txbMax.Location = new System.Drawing.Point(192, 42);
            this.txbMax.Name = "txbMax";
            this.txbMax.Size = new System.Drawing.Size(100, 20);
            this.txbMax.TabIndex = 3;
            this.txbMax.Text = "10";
            this.txbMax.TextChanged += new System.EventHandler(this.txbMax_TextChanged);
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(192, 73);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 20);
            this.txbAmount.TabIndex = 4;
            this.txbAmount.Text = "10";
            this.txbAmount.TextChanged += new System.EventHandler(this.txbAmount_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Quicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.txbMax);
            this.Controls.Add(this.txbMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnQuicksort);
            this.Name = "Quicksort";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuicksort;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMin;
        private System.Windows.Forms.TextBox txbMax;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

