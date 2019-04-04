namespace Mini
{
    partial class Student
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
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.firstNameT = new System.Windows.Forms.TextBox();
            this.LastNameT = new System.Windows.Forms.TextBox();
            this.contactT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.genderT = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.regNoT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personBH = new System.Windows.Forms.Button();
            this.dobT = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(47, 71);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(89, 19);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lastName.Location = new System.Drawing.Point(48, 120);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(86, 19);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.contact.Location = new System.Drawing.Point(48, 201);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(66, 19);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(47, 239);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 19);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.dob.Location = new System.Drawing.Point(47, 278);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(103, 19);
            this.dob.TabIndex = 6;
            this.dob.Text = "Date of Birth";
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.gender.Location = new System.Drawing.Point(48, 319);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(62, 19);
            this.gender.TabIndex = 7;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.label7_Click);
            // 
            // firstNameT
            // 
            this.firstNameT.Location = new System.Drawing.Point(187, 72);
            this.firstNameT.Name = "firstNameT";
            this.firstNameT.Size = new System.Drawing.Size(100, 20);
            this.firstNameT.TabIndex = 8;
            this.firstNameT.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameT_Validating);
            // 
            // LastNameT
            // 
            this.LastNameT.Location = new System.Drawing.Point(187, 119);
            this.LastNameT.Name = "LastNameT";
            this.LastNameT.Size = new System.Drawing.Size(100, 20);
            this.LastNameT.TabIndex = 9;
            this.LastNameT.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameT_Validating);
            // 
            // contactT
            // 
            this.contactT.Location = new System.Drawing.Point(187, 201);
            this.contactT.Name = "contactT";
            this.contactT.Size = new System.Drawing.Size(100, 20);
            this.contactT.TabIndex = 10;
            this.contactT.TextChanged += new System.EventHandler(this.contactT_TextChanged);
            this.contactT.Validating += new System.ComponentModel.CancelEventHandler(this.contactT_Validating);
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(187, 239);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 20);
            this.emailT.TabIndex = 11;
            this.emailT.TextChanged += new System.EventHandler(this.emailT_TextChanged);
            this.emailT.Validating += new System.ComponentModel.CancelEventHandler(this.emailT_Validating);
            // 
            // genderT
            // 
            this.genderT.FormattingEnabled = true;
            this.genderT.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderT.Location = new System.Drawing.Point(181, 317);
            this.genderT.Name = "genderT";
            this.genderT.Size = new System.Drawing.Size(106, 21);
            this.genderT.TabIndex = 14;
            this.genderT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 267);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.Teal;
            this.addB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.addB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addB.Location = new System.Drawing.Point(187, 363);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(87, 35);
            this.addB.TabIndex = 17;
            this.addB.Text = "ADD";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.Teal;
            this.deleteB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.deleteB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteB.Location = new System.Drawing.Point(712, 363);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(86, 40);
            this.deleteB.TabIndex = 18;
            this.deleteB.Text = "DELETE";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // updateB
            // 
            this.updateB.BackColor = System.Drawing.Color.Teal;
            this.updateB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.updateB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateB.Location = new System.Drawing.Point(541, 363);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(90, 40);
            this.updateB.TabIndex = 20;
            this.updateB.Text = "UPDATE";
            this.updateB.UseVisualStyleBackColor = false;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // regNoT
            // 
            this.regNoT.Location = new System.Drawing.Point(187, 156);
            this.regNoT.Name = "regNoT";
            this.regNoT.Size = new System.Drawing.Size(100, 20);
            this.regNoT.TabIndex = 22;
            this.regNoT.Validating += new System.ComponentModel.CancelEventHandler(this.regNoT_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registration No.";
            // 
            // personBH
            // 
            this.personBH.BackColor = System.Drawing.Color.Teal;
            this.personBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personBH.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personBH.Location = new System.Drawing.Point(209, 0);
            this.personBH.Name = "personBH";
            this.personBH.Size = new System.Drawing.Size(439, 65);
            this.personBH.TabIndex = 24;
            this.personBH.Text = "STUDENT";
            this.personBH.UseVisualStyleBackColor = false;
            // 
            // dobT
            // 
            this.dobT.Location = new System.Drawing.Point(181, 278);
            this.dobT.Name = "dobT";
            this.dobT.Size = new System.Drawing.Size(106, 20);
            this.dobT.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(750, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(927, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dobT);
            this.Controls.Add(this.personBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regNoT);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.genderT);
            this.Controls.Add(this.emailT);
            this.Controls.Add(this.contactT);
            this.Controls.Add(this.LastNameT);
            this.Controls.Add(this.firstNameT);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox firstNameT;
        private System.Windows.Forms.TextBox LastNameT;
        private System.Windows.Forms.TextBox contactT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.ComboBox genderT;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.TextBox regNoT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personBH;
        private System.Windows.Forms.DateTimePicker dobT;
        private System.Windows.Forms.Button button1;
    }
}

