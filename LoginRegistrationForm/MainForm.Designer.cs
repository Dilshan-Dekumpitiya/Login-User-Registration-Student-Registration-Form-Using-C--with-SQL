
namespace LoginRegistrationForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStuRegNo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtParentContact = new System.Windows.Forms.TextBox();
            this.txtParentNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStuHomePhone = new System.Windows.Forms.TextBox();
            this.txtStuMobile = new System.Windows.Forms.TextBox();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStuLastName = new System.Windows.Forms.TextBox();
            this.txtStuFirstName = new System.Windows.Forms.TextBox();
            this.dtpStuDOB = new System.Windows.Forms.DateTimePicker();
            this.rbtnStuFemale = new System.Windows.Forms.RadioButton();
            this.rbtnStuMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStuReg = new System.Windows.Forms.Button();
            this.btnStuUpdate = new System.Windows.Forms.Button();
            this.btnStuClear = new System.Windows.Forms.Button();
            this.btnStuDelete = new System.Windows.Forms.Button();
            this.logOutbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbStuRegNo);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 719);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // cmbStuRegNo
            // 
            this.cmbStuRegNo.FormattingEnabled = true;
            this.cmbStuRegNo.ItemHeight = 20;
            this.cmbStuRegNo.Location = new System.Drawing.Point(213, 38);
            this.cmbStuRegNo.Name = "cmbStuRegNo";
            this.cmbStuRegNo.Size = new System.Drawing.Size(220, 28);
            this.cmbStuRegNo.TabIndex = 5;
            this.cmbStuRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbStuRegNo_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtParentContact);
            this.groupBox5.Controls.Add(this.txtParentNIC);
            this.groupBox5.Controls.Add(this.txtParentName);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(27, 529);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 176);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parent Details";
            // 
            // txtParentContact
            // 
            this.txtParentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentContact.Location = new System.Drawing.Point(176, 124);
            this.txtParentContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtParentContact.Multiline = true;
            this.txtParentContact.Name = "txtParentContact";
            this.txtParentContact.Size = new System.Drawing.Size(324, 36);
            this.txtParentContact.TabIndex = 26;
            // 
            // txtParentNIC
            // 
            this.txtParentNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentNIC.Location = new System.Drawing.Point(176, 74);
            this.txtParentNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtParentNIC.Multiline = true;
            this.txtParentNIC.Name = "txtParentNIC";
            this.txtParentNIC.Size = new System.Drawing.Size(324, 36);
            this.txtParentNIC.TabIndex = 25;
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.Location = new System.Drawing.Point(176, 22);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtParentName.Multiline = true;
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(324, 36);
            this.txtParentName.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Contact Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parent Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(-9, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 118);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStuAddress);
            this.groupBox3.Controls.Add(this.txtStuHomePhone);
            this.groupBox3.Controls.Add(this.txtStuMobile);
            this.groupBox3.Controls.Add(this.txtStuEmail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(29, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // txtStuHomePhone
            // 
            this.txtStuHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuHomePhone.Location = new System.Drawing.Point(397, 165);
            this.txtStuHomePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuHomePhone.Multiline = true;
            this.txtStuHomePhone.Name = "txtStuHomePhone";
            this.txtStuHomePhone.Size = new System.Drawing.Size(161, 36);
            this.txtStuHomePhone.TabIndex = 21;
            // 
            // txtStuMobile
            // 
            this.txtStuMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuMobile.Location = new System.Drawing.Point(129, 165);
            this.txtStuMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuMobile.Multiline = true;
            this.txtStuMobile.Name = "txtStuMobile";
            this.txtStuMobile.Size = new System.Drawing.Size(168, 36);
            this.txtStuMobile.TabIndex = 20;
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuEmail.Location = new System.Drawing.Point(183, 113);
            this.txtStuEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuEmail.Multiline = true;
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(324, 36);
            this.txtStuEmail.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Home Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mobile Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStuLastName);
            this.groupBox2.Controls.Add(this.txtStuFirstName);
            this.groupBox2.Controls.Add(this.dtpStuDOB);
            this.groupBox2.Controls.Add(this.rbtnStuFemale);
            this.groupBox2.Controls.Add(this.rbtnStuMale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // txtStuLastName
            // 
            this.txtStuLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuLastName.Location = new System.Drawing.Point(183, 61);
            this.txtStuLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuLastName.Multiline = true;
            this.txtStuLastName.Name = "txtStuLastName";
            this.txtStuLastName.Size = new System.Drawing.Size(324, 36);
            this.txtStuLastName.TabIndex = 18;
            // 
            // txtStuFirstName
            // 
            this.txtStuFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuFirstName.Location = new System.Drawing.Point(184, 22);
            this.txtStuFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuFirstName.Multiline = true;
            this.txtStuFirstName.Name = "txtStuFirstName";
            this.txtStuFirstName.Size = new System.Drawing.Size(324, 36);
            this.txtStuFirstName.TabIndex = 17;
            // 
            // dtpStuDOB
            // 
            this.dtpStuDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStuDOB.Location = new System.Drawing.Point(183, 105);
            this.dtpStuDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStuDOB.Name = "dtpStuDOB";
            this.dtpStuDOB.Size = new System.Drawing.Size(325, 27);
            this.dtpStuDOB.TabIndex = 12;
            // 
            // rbtnStuFemale
            // 
            this.rbtnStuFemale.AutoSize = true;
            this.rbtnStuFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStuFemale.Location = new System.Drawing.Point(324, 155);
            this.rbtnStuFemale.Name = "rbtnStuFemale";
            this.rbtnStuFemale.Size = new System.Drawing.Size(85, 24);
            this.rbtnStuFemale.TabIndex = 11;
            this.rbtnStuFemale.Text = "Female";
            this.rbtnStuFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnStuMale
            // 
            this.rbtnStuMale.AutoSize = true;
            this.rbtnStuMale.Checked = true;
            this.rbtnStuMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStuMale.Location = new System.Drawing.Point(184, 155);
            this.rbtnStuMale.Name = "rbtnStuMale";
            this.rbtnStuMale.Size = new System.Drawing.Size(66, 24);
            this.rbtnStuMale.TabIndex = 10;
            this.rbtnStuMale.TabStop = true;
            this.rbtnStuMale.Text = "Male";
            this.rbtnStuMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registration No";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnStuReg
            // 
            this.btnStuReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnStuReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuReg.FlatAppearance.BorderSize = 0;
            this.btnStuReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuReg.ForeColor = System.Drawing.Color.White;
            this.btnStuReg.Location = new System.Drawing.Point(56, 791);
            this.btnStuReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuReg.Name = "btnStuReg";
            this.btnStuReg.Size = new System.Drawing.Size(133, 43);
            this.btnStuReg.TabIndex = 7;
            this.btnStuReg.Text = "REGISTER";
            this.btnStuReg.UseVisualStyleBackColor = false;
            this.btnStuReg.Click += new System.EventHandler(this.btnStuReg_Click);
            // 
            // btnStuUpdate
            // 
            this.btnStuUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.btnStuUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuUpdate.FlatAppearance.BorderSize = 0;
            this.btnStuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuUpdate.ForeColor = System.Drawing.Color.White;
            this.btnStuUpdate.Location = new System.Drawing.Point(214, 791);
            this.btnStuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuUpdate.Name = "btnStuUpdate";
            this.btnStuUpdate.Size = new System.Drawing.Size(133, 43);
            this.btnStuUpdate.TabIndex = 8;
            this.btnStuUpdate.Text = "UPDATE";
            this.btnStuUpdate.UseVisualStyleBackColor = false;
            this.btnStuUpdate.Click += new System.EventHandler(this.btnStuUpdate_Click);
            // 
            // btnStuClear
            // 
            this.btnStuClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.btnStuClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuClear.FlatAppearance.BorderSize = 0;
            this.btnStuClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuClear.ForeColor = System.Drawing.Color.White;
            this.btnStuClear.Location = new System.Drawing.Point(373, 791);
            this.btnStuClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuClear.Name = "btnStuClear";
            this.btnStuClear.Size = new System.Drawing.Size(133, 43);
            this.btnStuClear.TabIndex = 9;
            this.btnStuClear.Text = "CLEAR";
            this.btnStuClear.UseVisualStyleBackColor = false;
            this.btnStuClear.Click += new System.EventHandler(this.btnStuClear_Click);
            // 
            // btnStuDelete
            // 
            this.btnStuDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnStuDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuDelete.FlatAppearance.BorderSize = 0;
            this.btnStuDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuDelete.ForeColor = System.Drawing.Color.White;
            this.btnStuDelete.Location = new System.Drawing.Point(541, 791);
            this.btnStuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuDelete.Name = "btnStuDelete";
            this.btnStuDelete.Size = new System.Drawing.Size(133, 43);
            this.btnStuDelete.TabIndex = 10;
            this.btnStuDelete.Text = "DELETE";
            this.btnStuDelete.UseVisualStyleBackColor = false;
            this.btnStuDelete.Click += new System.EventHandler(this.btnStuDelete_Click);
            // 
            // logOutbtn
            // 
            this.logOutbtn.AutoSize = true;
            this.logOutbtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.logOutbtn.Location = new System.Drawing.Point(581, 21);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(82, 20);
            this.logOutbtn.TabIndex = 1;
            this.logOutbtn.Text = "Log Out ";
            this.logOutbtn.Click += new System.EventHandler(this.logOutbtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(193, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Skills International";
            // 
            // txtStuAddress
            // 
            this.txtStuAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuAddress.Location = new System.Drawing.Point(183, 22);
            this.txtStuAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStuAddress.Multiline = true;
            this.txtStuAddress.Name = "txtStuAddress";
            this.txtStuAddress.Size = new System.Drawing.Size(325, 74);
            this.txtStuAddress.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 846);
            this.Controls.Add(this.logOutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStuClear);
            this.Controls.Add(this.btnStuReg);
            this.Controls.Add(this.btnStuUpdate);
            this.Controls.Add(this.btnStuDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnStuFemale;
        private System.Windows.Forms.RadioButton rbtnStuMale;
        private System.Windows.Forms.DateTimePicker dtpStuDOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbStuRegNo;
        private System.Windows.Forms.Button btnStuReg;
        private System.Windows.Forms.TextBox txtStuLastName;
        private System.Windows.Forms.TextBox txtStuFirstName;
        private System.Windows.Forms.TextBox txtStuHomePhone;
        private System.Windows.Forms.TextBox txtStuMobile;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.TextBox txtParentNIC;
        private System.Windows.Forms.Button btnStuUpdate;
        private System.Windows.Forms.Button btnStuClear;
        private System.Windows.Forms.Button btnStuDelete;
        private System.Windows.Forms.Label logOutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuAddress;
    }
}