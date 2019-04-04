namespace Mini
{
    partial class Evaluation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.totalmarksTB = new System.Windows.Forms.TextBox();
            this.weightageTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddB = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
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
            this.personBH.Location = new System.Drawing.Point(173, -1);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(474, 63);
            this.personBH.TabIndex = 19;
            this.personBH.Text = "EVALUATION";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Weightage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total Marks";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(191, 127);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 24;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            this.NameTB.Validating += new System.ComponentModel.CancelEventHandler(this.NameTB_Validating);
            // 
            // totalmarksTB
            // 
            this.totalmarksTB.Location = new System.Drawing.Point(191, 191);
            this.totalmarksTB.Name = "totalmarksTB";
            this.totalmarksTB.Size = new System.Drawing.Size(100, 20);
            this.totalmarksTB.TabIndex = 25;
            this.totalmarksTB.TextChanged += new System.EventHandler(this.totalmarksTB_TextChanged);
            this.totalmarksTB.Validating += new System.ComponentModel.CancelEventHandler(this.totalmarksTB_Validating);
            // 
            // weightageTB
            // 
            this.weightageTB.Location = new System.Drawing.Point(191, 265);
            this.weightageTB.Name = "weightageTB";
            this.weightageTB.Size = new System.Drawing.Size(100, 20);
            this.weightageTB.TabIndex = 26;
            this.weightageTB.Validating += new System.ComponentModel.CancelEventHandler(this.weightageTB_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 233);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Teal;
            this.AddB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.AddB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddB.Location = new System.Drawing.Point(208, 375);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(83, 37);
            this.AddB.TabIndex = 28;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Teal;
            this.UpdateB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateB.Location = new System.Drawing.Point(370, 375);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(83, 37);
            this.UpdateB.TabIndex = 30;
            this.UpdateB.Text = "UPDATE";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.Teal;
            this.DeleteB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteB.Location = new System.Drawing.Point(521, 375);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(83, 37);
            this.DeleteB.TabIndex = 29;
            this.DeleteB.Text = "DELETE";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(681, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightageTB);
            this.Controls.Add(this.totalmarksTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personBH);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox totalmarksTB;
        private System.Windows.Forms.TextBox weightageTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button button1;
    }
}