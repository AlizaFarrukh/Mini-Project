namespace Mini
{
    partial class Advisor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FNT = new System.Windows.Forms.TextBox();
            this.LNT = new System.Windows.Forms.TextBox();
            this.CONT = new System.Windows.Forms.TextBox();
            this.EMAILT = new System.Windows.Forms.TextBox();
            this.SALARYT = new System.Windows.Forms.TextBox();
            this.GENT = new System.Windows.Forms.ComboBox();
            this.personBH = new System.Windows.Forms.Button();
            this.deletea_b = new System.Windows.Forms.Button();
            this.updatea_b = new System.Windows.Forms.Button();
            this.adda_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DOBT = new System.Windows.Forms.DateTimePicker();
            this.DESGT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(49, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(49, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(49, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(49, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(49, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salary";
            // 
            // FNT
            // 
            this.FNT.Location = new System.Drawing.Point(169, 71);
            this.FNT.Name = "FNT";
            this.FNT.Size = new System.Drawing.Size(100, 20);
            this.FNT.TabIndex = 8;
            this.FNT.TextChanged += new System.EventHandler(this.FNT_TextChanged);
            this.FNT.Validating += new System.ComponentModel.CancelEventHandler(this.FNT_Validating);
            // 
            // LNT
            // 
            this.LNT.Location = new System.Drawing.Point(169, 116);
            this.LNT.Name = "LNT";
            this.LNT.Size = new System.Drawing.Size(100, 20);
            this.LNT.TabIndex = 9;
            this.LNT.Validating += new System.ComponentModel.CancelEventHandler(this.LNT_Validating);
            // 
            // CONT
            // 
            this.CONT.Location = new System.Drawing.Point(169, 158);
            this.CONT.Name = "CONT";
            this.CONT.Size = new System.Drawing.Size(100, 20);
            this.CONT.TabIndex = 10;
            this.CONT.TextChanged += new System.EventHandler(this.CONT_TextChanged);
            this.CONT.Validating += new System.ComponentModel.CancelEventHandler(this.CONT_Validating);
            // 
            // EMAILT
            // 
            this.EMAILT.Location = new System.Drawing.Point(169, 195);
            this.EMAILT.Name = "EMAILT";
            this.EMAILT.Size = new System.Drawing.Size(100, 20);
            this.EMAILT.TabIndex = 11;
            this.EMAILT.Validating += new System.ComponentModel.CancelEventHandler(this.EMAILT_Validating);
            // 
            // SALARYT
            // 
            this.SALARYT.Location = new System.Drawing.Point(169, 351);
            this.SALARYT.Name = "SALARYT";
            this.SALARYT.Size = new System.Drawing.Size(100, 20);
            this.SALARYT.TabIndex = 14;
            this.SALARYT.TextChanged += new System.EventHandler(this.SALARYT_TextChanged);
            this.SALARYT.Validating += new System.ComponentModel.CancelEventHandler(this.SALARYT_Validating);
            // 
            // GENT
            // 
            this.GENT.FormattingEnabled = true;
            this.GENT.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GENT.Location = new System.Drawing.Point(169, 273);
            this.GENT.Name = "GENT";
            this.GENT.Size = new System.Drawing.Size(100, 21);
            this.GENT.TabIndex = 16;
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(216, 3);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(399, 63);
            this.personBH.TabIndex = 17;
            this.personBH.Text = "ADVISOR";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // deletea_b
            // 
            this.deletea_b.BackColor = System.Drawing.Color.Teal;
            this.deletea_b.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.deletea_b.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletea_b.Location = new System.Drawing.Point(611, 386);
            this.deletea_b.Name = "deletea_b";
            this.deletea_b.Size = new System.Drawing.Size(88, 37);
            this.deletea_b.TabIndex = 18;
            this.deletea_b.Text = "DELETE";
            this.deletea_b.UseVisualStyleBackColor = false;
            this.deletea_b.Click += new System.EventHandler(this.deletea_b_Click);
            // 
            // updatea_b
            // 
            this.updatea_b.BackColor = System.Drawing.Color.Teal;
            this.updatea_b.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.updatea_b.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updatea_b.Location = new System.Drawing.Point(418, 386);
            this.updatea_b.Name = "updatea_b";
            this.updatea_b.Size = new System.Drawing.Size(95, 37);
            this.updatea_b.TabIndex = 19;
            this.updatea_b.Text = "UPDATE";
            this.updatea_b.UseVisualStyleBackColor = false;
            this.updatea_b.Click += new System.EventHandler(this.updatea_b_Click);
            // 
            // adda_b
            // 
            this.adda_b.BackColor = System.Drawing.Color.Teal;
            this.adda_b.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.adda_b.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adda_b.Location = new System.Drawing.Point(186, 386);
            this.adda_b.Name = "adda_b";
            this.adda_b.Size = new System.Drawing.Size(83, 37);
            this.adda_b.TabIndex = 20;
            this.adda_b.Text = "ADD";
            this.adda_b.UseVisualStyleBackColor = false;
            this.adda_b.Click += new System.EventHandler(this.adda_b_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 259);
            this.dataGridView1.TabIndex = 23;
            // 
            // DOBT
            // 
            this.DOBT.Location = new System.Drawing.Point(169, 234);
            this.DOBT.Name = "DOBT";
            this.DOBT.Size = new System.Drawing.Size(100, 20);
            this.DOBT.TabIndex = 25;
            // 
            // DESGT
            // 
            this.DESGT.FormattingEnabled = true;
            this.DESGT.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.DESGT.Location = new System.Drawing.Point(169, 310);
            this.DESGT.Name = "DESGT";
            this.DESGT.Size = new System.Drawing.Size(100, 21);
            this.DESGT.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(665, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DESGT);
            this.Controls.Add(this.DOBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adda_b);
            this.Controls.Add(this.updatea_b);
            this.Controls.Add(this.deletea_b);
            this.Controls.Add(this.personBH);
            this.Controls.Add(this.GENT);
            this.Controls.Add(this.SALARYT);
            this.Controls.Add(this.EMAILT);
            this.Controls.Add(this.CONT);
            this.Controls.Add(this.LNT);
            this.Controls.Add(this.FNT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.Load += new System.EventHandler(this.Advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FNT;
        private System.Windows.Forms.TextBox LNT;
        private System.Windows.Forms.TextBox CONT;
        private System.Windows.Forms.TextBox EMAILT;
        private System.Windows.Forms.TextBox SALARYT;
        private System.Windows.Forms.ComboBox GENT;
        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.Button deletea_b;
        private System.Windows.Forms.Button updatea_b;
        private System.Windows.Forms.Button adda_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DOBT;
        private System.Windows.Forms.ComboBox DESGT;
        private System.Windows.Forms.Button button1;
    }
}