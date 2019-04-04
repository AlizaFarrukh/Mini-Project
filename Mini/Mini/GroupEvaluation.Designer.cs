namespace Mini
{
    partial class GroupEvaluation
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
            this.marks = new System.Windows.Forms.Label();
            this.evalid = new System.Windows.Forms.Label();
            this.gid = new System.Windows.Forms.Label();
            this.evaluation = new System.Windows.Forms.ComboBox();
            this.groupid = new System.Windows.Forms.ComboBox();
            this.obtained = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(139, 24);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(494, 63);
            this.personBH.TabIndex = 21;
            this.personBH.Text = "MANAGE GROUP EVALUATIONS";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.marks.ForeColor = System.Drawing.Color.Teal;
            this.marks.Location = new System.Drawing.Point(65, 209);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(127, 19);
            this.marks.TabIndex = 24;
            this.marks.Text = "Obtained Marks";
            // 
            // evalid
            // 
            this.evalid.AutoSize = true;
            this.evalid.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.evalid.ForeColor = System.Drawing.Color.Teal;
            this.evalid.Location = new System.Drawing.Point(65, 167);
            this.evalid.Name = "evalid";
            this.evalid.Size = new System.Drawing.Size(127, 19);
            this.evalid.TabIndex = 25;
            this.evalid.Text = "Evaluation Title";
            // 
            // gid
            // 
            this.gid.AutoSize = true;
            this.gid.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.gid.ForeColor = System.Drawing.Color.Teal;
            this.gid.Location = new System.Drawing.Point(65, 128);
            this.gid.Name = "gid";
            this.gid.Size = new System.Drawing.Size(76, 19);
            this.gid.TabIndex = 26;
            this.gid.Text = "Group ID";
            // 
            // evaluation
            // 
            this.evaluation.FormattingEnabled = true;
            this.evaluation.Location = new System.Drawing.Point(209, 167);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(163, 21);
            this.evaluation.TabIndex = 43;
            // 
            // groupid
            // 
            this.groupid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupid.FormattingEnabled = true;
            this.groupid.Location = new System.Drawing.Point(209, 128);
            this.groupid.Name = "groupid";
            this.groupid.Size = new System.Drawing.Size(163, 21);
            this.groupid.TabIndex = 44;
            // 
            // obtained
            // 
            this.obtained.Location = new System.Drawing.Point(209, 210);
            this.obtained.Name = "obtained";
            this.obtained.Size = new System.Drawing.Size(163, 20);
            this.obtained.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 243);
            this.dataGridView1.TabIndex = 46;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Teal;
            this.add.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(69, 283);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(83, 37);
            this.add.TabIndex = 47;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Teal;
            this.delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Location = new System.Drawing.Point(305, 283);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(83, 37);
            this.delete.TabIndex = 48;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Teal;
            this.update.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update.Location = new System.Drawing.Point(185, 283);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(83, 37);
            this.update.TabIndex = 49;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.Teal;
            this.addB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.addB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addB.Location = new System.Drawing.Point(658, 41);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(114, 35);
            this.addB.TabIndex = 50;
            this.addB.Text = "Home";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.obtained);
            this.Controls.Add(this.groupid);
            this.Controls.Add(this.evaluation);
            this.Controls.Add(this.gid);
            this.Controls.Add(this.evalid);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.personBH);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            this.Load += new System.EventHandler(this.GroupEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Label marks;
        private System.Windows.Forms.Label evalid;
        private System.Windows.Forms.Label gid;
        private System.Windows.Forms.ComboBox evaluation;
        private System.Windows.Forms.ComboBox groupid;
        private System.Windows.Forms.TextBox obtained;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button addB;
    }
}