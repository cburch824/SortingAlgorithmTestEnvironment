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
            this.btnGenerateIntTextfile = new System.Windows.Forms.Button();
            this.btnSort10Ints = new System.Windows.Forms.Button();
            this.btnSortThrough1e7 = new System.Windows.Forms.Button();
            this.txtNumberOfGeneratedInts = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSortAllIntLists = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "1 3 2 5 4";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(9, 223);
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
            this.lblOutput.Location = new System.Drawing.Point(9, 73);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(82, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Initial input label";
            // 
            // lblBool
            // 
            this.lblBool.AutoSize = true;
            this.lblBool.Location = new System.Drawing.Point(100, 117);
            this.lblBool.Name = "lblBool";
            this.lblBool.Size = new System.Drawing.Size(18, 13);
            this.lblBool.TabIndex = 3;
            this.lblBool.Text = "t/f";
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Location = new System.Drawing.Point(6, 155);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(81, 13);
            this.lblSorted.TabIndex = 4;
            this.lblSorted.Text = "Post-sort output";
            // 
            // lblPostValidation
            // 
            this.lblPostValidation.AutoSize = true;
            this.lblPostValidation.Location = new System.Drawing.Point(100, 187);
            this.lblPostValidation.Name = "lblPostValidation";
            this.lblPostValidation.Size = new System.Drawing.Size(18, 13);
            this.lblPostValidation.TabIndex = 5;
            this.lblPostValidation.Text = "t/f";
            // 
            // btnGenerateIntTextfile
            // 
            this.btnGenerateIntTextfile.Location = new System.Drawing.Point(246, 21);
            this.btnGenerateIntTextfile.Name = "btnGenerateIntTextfile";
            this.btnGenerateIntTextfile.Size = new System.Drawing.Size(146, 23);
            this.btnGenerateIntTextfile.TabIndex = 6;
            this.btnGenerateIntTextfile.Text = "Generate Ints Textfile";
            this.btnGenerateIntTextfile.UseVisualStyleBackColor = true;
            this.btnGenerateIntTextfile.Click += new System.EventHandler(this.button1_Click);
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
            this.btnSortThrough1e7.Location = new System.Drawing.Point(12, 86);
            this.btnSortThrough1e7.Name = "btnSortThrough1e7";
            this.btnSortThrough1e7.Size = new System.Drawing.Size(183, 44);
            this.btnSortThrough1e7.TabIndex = 10;
            this.btnSortThrough1e7.Text = "Sort and graph time for 1e1 through 1e7";
            this.btnSortThrough1e7.UseVisualStyleBackColor = true;
            this.btnSortThrough1e7.Click += new System.EventHandler(this.btnSortThrough1e7_Click);
            // 
            // txtNumberOfGeneratedInts
            // 
            this.txtNumberOfGeneratedInts.Location = new System.Drawing.Point(140, 21);
            this.txtNumberOfGeneratedInts.Name = "txtNumberOfGeneratedInts";
            this.txtNumberOfGeneratedInts.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfGeneratedInts.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumberOfGeneratedInts);
            this.groupBox1.Controls.Add(this.btnGenerateIntTextfile);
            this.groupBox1.Location = new System.Drawing.Point(89, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate New Ints List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of ints generated:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.lblOutput);
            this.groupBox2.Controls.Add(this.lblBool);
            this.groupBox2.Controls.Add(this.lblSorted);
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.Controls.Add(this.lblPostValidation);
            this.groupBox2.Location = new System.Drawing.Point(287, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 252);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Textbox Sorting Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Initial Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorted before sort?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Post-sort output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sorted after sort?";
            // 
            // btnSortAllIntLists
            // 
            this.btnSortAllIntLists.Location = new System.Drawing.Point(12, 12);
            this.btnSortAllIntLists.Name = "btnSortAllIntLists";
            this.btnSortAllIntLists.Size = new System.Drawing.Size(183, 68);
            this.btnSortAllIntLists.TabIndex = 14;
            this.btnSortAllIntLists.Text = "Sort all lists in the \"IntLists\" directory";
            this.btnSortAllIntLists.UseVisualStyleBackColor = true;
            this.btnSortAllIntLists.Click += new System.EventHandler(this.btnSortAllIntLists_Click);
            // 
            // frmSortingTestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 366);
            this.Controls.Add(this.btnSortAllIntLists);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSortThrough1e7);
            this.Controls.Add(this.btnSort10Ints);
            this.Name = "frmSortingTestMain";
            this.Text = "Sorting Algorithms Test Environment";
            this.Load += new System.EventHandler(this.frmSortingTestMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblBool;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Label lblPostValidation;
        private System.Windows.Forms.Button btnGenerateIntTextfile;
        private System.Windows.Forms.Button btnSort10Ints;
        private System.Windows.Forms.Button btnSortThrough1e7;
        private System.Windows.Forms.TextBox txtNumberOfGeneratedInts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortAllIntLists;
    }
}

