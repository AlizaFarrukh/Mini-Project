namespace Mini
{
    partial class GenerateReport
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
            this.button1 = new System.Windows.Forms.Button();
            this.Advisors = new System.Windows.Forms.DataGridView();
            this.AddB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Advisors)).BeginInit();
            this.SuspendLayout();
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(129, 24);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(474, 63);
            this.personBH.TabIndex = 20;
            this.personBH.Text = "Report";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(667, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 32;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Advisors
            // 
            this.Advisors.AllowUserToAddRows = false;
            this.Advisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Advisors.Location = new System.Drawing.Point(76, 141);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(587, 185);
            this.Advisors.TabIndex = 33;
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Teal;
            this.AddB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.AddB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddB.Location = new System.Drawing.Point(309, 367);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(155, 37);
            this.AddB.TabIndex = 34;
            this.AddB.Text = "Generate pdf";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.Advisors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personBH);
            this.Name = "GenerateReport";
            this.Text = "GenerateReport";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Advisors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Advisors;
        private System.Windows.Forms.Button AddB;
    }
}