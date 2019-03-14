namespace Mini
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.projectB = new System.Windows.Forms.Button();
            this.evaluation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(146, 152);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(205, 55);
            this.personBH.TabIndex = 0;
            this.personBH.Text = "STUDENT";
            this.personBH.UseVisualStyleBackColor = false;
            this.personBH.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Final Year Project Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(417, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADVISOR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // projectB
            // 
            this.projectB.BackColor = System.Drawing.Color.Teal;
            this.projectB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectB.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.projectB.Location = new System.Drawing.Point(146, 274);
            this.projectB.Name = "projectB";
            this.projectB.Size = new System.Drawing.Size(205, 55);
            this.projectB.TabIndex = 3;
            this.projectB.Text = "PROJECT";
            this.projectB.UseVisualStyleBackColor = false;
            this.projectB.Click += new System.EventHandler(this.projectB_Click);
            // 
            // evaluation
            // 
            this.evaluation.BackColor = System.Drawing.Color.Teal;
            this.evaluation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evaluation.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.evaluation.Location = new System.Drawing.Point(417, 274);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(205, 55);
            this.evaluation.TabIndex = 4;
            this.evaluation.Text = "EVALUATION";
            this.evaluation.UseVisualStyleBackColor = false;
            this.evaluation.Click += new System.EventHandler(this.evaluation_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Mini.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.evaluation);
            this.Controls.Add(this.projectB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personBH);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button projectB;
        private System.Windows.Forms.Button evaluation;
    }
}