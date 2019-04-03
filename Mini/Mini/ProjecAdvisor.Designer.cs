namespace Mini
{
    partial class ProjecAdvisor
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
            this.personBH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(146, 28);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(494, 63);
            this.personBH.TabIndex = 21;
            this.personBH.Text = "Assign Project Advisor";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title of Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(142, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(142, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Advisor Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(142, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Advisor Role";
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(264, 146);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(163, 20);
            this.fn.TabIndex = 31;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(264, 194);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(163, 20);
            this.title.TabIndex = 33;
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.role.Location = new System.Drawing.Point(264, 247);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(163, 21);
            this.role.TabIndex = 34;
            // 
            // ProjecAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.role);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personBH);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "ProjecAdvisor";
            this.Text = "ProjecAdvisor";
            this.Load += new System.EventHandler(this.ProjecAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ComboBox role;
    }
}