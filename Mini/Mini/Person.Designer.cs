namespace Mini
{
    partial class Person
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
            this.dobT = new System.Windows.Forms.TextBox();
            this.genderT = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.dataL = new System.Windows.Forms.Label();
            this.regNoT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(47, 71);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(48, 120);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(48, 201);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(44, 13);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(47, 239);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(47, 278);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(66, 13);
            this.dob.TabIndex = 6;
            this.dob.Text = "Date of Birth";
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(48, 319);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 7;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.label7_Click);
            // 
            // firstNameT
            // 
            this.firstNameT.Location = new System.Drawing.Point(174, 71);
            this.firstNameT.Name = "firstNameT";
            this.firstNameT.Size = new System.Drawing.Size(100, 20);
            this.firstNameT.TabIndex = 8;
            // 
            // LastNameT
            // 
            this.LastNameT.Location = new System.Drawing.Point(174, 117);
            this.LastNameT.Name = "LastNameT";
            this.LastNameT.Size = new System.Drawing.Size(100, 20);
            this.LastNameT.TabIndex = 9;
            // 
            // contactT
            // 
            this.contactT.Location = new System.Drawing.Point(174, 201);
            this.contactT.Name = "contactT";
            this.contactT.Size = new System.Drawing.Size(100, 20);
            this.contactT.TabIndex = 10;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(174, 239);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 20);
            this.emailT.TabIndex = 11;
            // 
            // dobT
            // 
            this.dobT.Location = new System.Drawing.Point(174, 278);
            this.dobT.Name = "dobT";
            this.dobT.Size = new System.Drawing.Size(100, 20);
            this.dobT.TabIndex = 12;
            // 
            // genderT
            // 
            this.genderT.FormattingEnabled = true;
            this.genderT.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderT.Location = new System.Drawing.Point(174, 316);
            this.genderT.Name = "genderT";
            this.genderT.Size = new System.Drawing.Size(100, 21);
            this.genderT.TabIndex = 14;
            this.genderT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(199, 360);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 17;
            this.addB.Text = "ADD";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(580, 268);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 18;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // updateB
            // 
            this.updateB.Location = new System.Drawing.Point(694, 268);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 20;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // dataL
            // 
            this.dataL.AutoSize = true;
            this.dataL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataL.Location = new System.Drawing.Point(482, 44);
            this.dataL.Name = "dataL";
            this.dataL.Size = new System.Drawing.Size(52, 24);
            this.dataL.TabIndex = 21;
            this.dataL.Text = "Data:";
            this.dataL.Click += new System.EventHandler(this.label3_Click);
            // 
            // regNoT
            // 
            this.regNoT.Location = new System.Drawing.Point(174, 156);
            this.regNoT.Name = "regNoT";
            this.regNoT.Size = new System.Drawing.Size(100, 20);
            this.regNoT.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registration No.";
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regNoT);
            this.Controls.Add(this.dataL);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.genderT);
            this.Controls.Add(this.dobT);
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
            this.Name = "Person";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox dobT;
        private System.Windows.Forms.ComboBox genderT;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Label dataL;
        private System.Windows.Forms.TextBox regNoT;
        private System.Windows.Forms.Label label1;
    }
}

