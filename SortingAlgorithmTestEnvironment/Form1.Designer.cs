namespace SortingAlgorithmTestEnvironment
{
    partial class frmSortingTestMain
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblBool = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lblPostValidation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSort10Ints = new System.Windows.Forms.Button();
            this.btnSortThrough1e7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(210, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "1 3 2 5 4";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(238, 10);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort Textbox";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 53);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "label1";
            // 
            // lblBool
            // 
            this.lblBool.AutoSize = true;
            this.lblBool.Location = new System.Drawing.Point(13, 87);
            this.lblBool.Name = "lblBool";
            this.lblBool.Size = new System.Drawing.Size(35, 13);
            this.lblBool.TabIndex = 3;
            this.lblBool.Text = "label1";
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Location = new System.Drawing.Point(13, 121);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(35, 13);
            this.lblSorted.TabIndex = 4;
            this.lblSorted.Text = "label1";
            // 
            // lblPostValidation
            // 
            this.lblPostValidation.AutoSize = true;
            this.lblPostValidation.Location = new System.Drawing.Point(13, 158);
            this.lblPostValidation.Name = "lblPostValidation";
            this.lblPostValidation.Size = new System.Drawing.Size(35, 13);
            this.lblPostValidation.TabIndex = 5;
            this.lblPostValidation.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Ints Textfile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSort10Ints
            // 
            this.btnSort10Ints.Location = new System.Drawing.Point(316, 10);
            this.btnSort10Ints.Name = "btnSort10Ints";
            this.btnSort10Ints.Size = new System.Drawing.Size(75, 23);
            this.btnSort10Ints.TabIndex = 9;
            this.btnSort10Ints.Text = "Sort 1e1 Ints";
            this.btnSort10Ints.UseVisualStyleBackColor = true;
            this.btnSort10Ints.Click += new System.EventHandler(this.btnSort10Ints_Click);
            // 
            // btnSortThrough1e7
            // 
            this.btnSortThrough1e7.Location = new System.Drawing.Point(16, 191);
            this.btnSortThrough1e7.Name = "btnSortThrough1e7";
            this.btnSortThrough1e7.Size = new System.Drawing.Size(183, 44);
            this.btnSortThrough1e7.TabIndex = 10;
            this.btnSortThrough1e7.Text = "Sort 1e1 through 1e7";
            this.btnSortThrough1e7.UseVisualStyleBackColor = true;
            this.btnSortThrough1e7.Click += new System.EventHandler(this.btnSortThrough1e7_Click);
            // 
            // frmSortingTestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 366);
            this.Controls.Add(this.btnSortThrough1e7);
            this.Controls.Add(this.btnSort10Ints);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPostValidation);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.lblBool);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtInput);
            this.Name = "frmSortingTestMain";
            this.Text = "Sorting Algorithms Test Environment";
            this.Load += new System.EventHandler(this.frmSortingTestMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblBool;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Label lblPostValidation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSort10Ints;
        private System.Windows.Forms.Button btnSortThrough1e7;
    }
}

