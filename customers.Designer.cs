
namespace CsharpApi
{
    partial class customers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.txtschooladd = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtschoolname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(494, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(573, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "School info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Location.Location = new System.Drawing.Point(477, 260);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(109, 16);
            this.Location.TabIndex = 11;
            this.Location.Text = "School_address:";
            this.Location.Click += new System.EventHandler(this.Location_Click);
            // 
            // txtschooladd
            // 
            this.txtschooladd.Location = new System.Drawing.Point(592, 254);
            this.txtschooladd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtschooladd.Name = "txtschooladd";
            this.txtschooladd.Size = new System.Drawing.Size(146, 22);
            this.txtschooladd.TabIndex = 8;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Beige;
            this.btnPost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPost.Location = new System.Drawing.Point(711, 332);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(101, 34);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtschoolname
            // 
            this.txtschoolname.Location = new System.Drawing.Point(592, 187);
            this.txtschoolname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtschoolname.Name = "txtschoolname";
            this.txtschoolname.Size = new System.Drawing.Size(146, 22);
            this.txtschoolname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(482, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "School_name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnGet);
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Location);
            this.groupBox2.Controls.Add(this.txtschooladd);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.txtschoolname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-42, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1117, 728);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(526, 678);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "CREDENTIALS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(554, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "School";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGet.Location = new System.Drawing.Point(592, 618);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 41);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(263, 421);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(714, 183);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1060, 788);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "customers";
            this.Text = "customers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox txtschooladd;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtschoolname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtOutput;
    }
}