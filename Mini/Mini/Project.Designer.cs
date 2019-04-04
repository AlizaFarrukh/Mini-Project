namespace Mini
{
    partial class Project
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.descTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(168, 3);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(469, 63);
            this.personBH.TabIndex = 18;
            this.personBH.Text = "PROJECT";
            this.personBH.UseVisualStyleBackColor = false;
            this.personBH.Click += new System.EventHandler(this.personBH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 233);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Teal;
            this.AddB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.AddB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddB.Location = new System.Drawing.Point(233, 383);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(83, 37);
            this.AddB.TabIndex = 25;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.Teal;
            this.DeleteB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteB.Location = new System.Drawing.Point(530, 383);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(83, 37);
            this.DeleteB.TabIndex = 26;
            this.DeleteB.Text = "DELETE";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Teal;
            this.UpdateB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateB.Location = new System.Drawing.Point(379, 383);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(83, 37);
            this.UpdateB.TabIndex = 27;
            this.UpdateB.Text = "UPDATE";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(185, 100);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(208, 20);
            this.titleTB.TabIndex = 28;
            this.titleTB.TextChanged += new System.EventHandler(this.titleTB_TextChanged);
            this.titleTB.Validating += new System.ComponentModel.CancelEventHandler(this.titleTB_Validating);
            // 
            // descTb
            // 
            this.descTb.Location = new System.Drawing.Point(185, 161);
            this.descTb.Multiline = true;
            this.descTb.Name = "descTb";
            this.descTb.Size = new System.Drawing.Size(208, 112);
            this.descTb.TabIndex = 29;
            this.descTb.TextChanged += new System.EventHandler(this.descTb_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(670, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descTb);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personBH);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox descTb;
        private System.Windows.Forms.Button button1;
    }
}