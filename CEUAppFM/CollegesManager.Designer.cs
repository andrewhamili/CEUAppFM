namespace CEUAppFM
{
    partial class CollegesManager
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
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.txtCollegeAbbrev = new System.Windows.Forms.TextBox();
            this.rtWebScript = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "College Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "College Abbreviation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "WebScript";
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(228, 49);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(143, 26);
            this.txtCollegeName.TabIndex = 1;
            // 
            // txtCollegeAbbrev
            // 
            this.txtCollegeAbbrev.Location = new System.Drawing.Point(228, 81);
            this.txtCollegeAbbrev.Name = "txtCollegeAbbrev";
            this.txtCollegeAbbrev.Size = new System.Drawing.Size(143, 26);
            this.txtCollegeAbbrev.TabIndex = 1;
            // 
            // rtWebScript
            // 
            this.rtWebScript.Location = new System.Drawing.Point(228, 119);
            this.rtWebScript.Name = "rtWebScript";
            this.rtWebScript.Size = new System.Drawing.Size(143, 185);
            this.rtWebScript.TabIndex = 2;
            this.rtWebScript.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(244, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CollegesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 385);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtWebScript);
            this.Controls.Add(this.txtCollegeAbbrev);
            this.Controls.Add(this.txtCollegeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CollegesManager";
            this.Text = "CollegesManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.TextBox txtCollegeAbbrev;
        private System.Windows.Forms.RichTextBox rtWebScript;
        private System.Windows.Forms.Button btnAdd;
    }
}