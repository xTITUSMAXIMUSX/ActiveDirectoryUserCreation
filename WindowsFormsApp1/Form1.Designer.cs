using System.Windows.Forms;

namespace ActiveDirectoryUserCreationApp
{
    partial class ActiveDirectoryTool
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.btnRemoveConfiguration = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.comboBoxConfigurations = new System.Windows.Forms.ComboBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIPPhoneValue = new System.Windows.Forms.TextBox();
            this.txtFaxValue = new System.Windows.Forms.TextBox();
            this.txtMobileValue = new System.Windows.Forms.TextBox();
            this.txtPagerValue = new System.Windows.Forms.TextBox();
            this.txtHomePhoneValue = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtManagerValue = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTitleValue = new System.Windows.Forms.TextBox();
            this.txtNewCompanyValue = new System.Windows.Forms.TextBox();
            this.txtNewDepartmentValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbxChangePasswordLogon = new System.Windows.Forms.CheckBox();
            this.chbxEnabled = new System.Windows.Forms.CheckBox();
            this.chbxCannotChangePassword = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtUPNSuffixValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewConfigurationName = new System.Windows.Forms.TextBox();
            this.txtNewContainerValue = new System.Windows.Forms.TextBox();
            this.OU = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtConnectValue = new System.Windows.Forms.TextBox();
            this.txthomeDirectoryValue = new System.Windows.Forms.TextBox();
            this.txtscriptPathValue = new System.Windows.Forms.TextBox();
            this.txtprofilePathValue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtZipValue = new System.Windows.Forms.TextBox();
            this.txtStateValue = new System.Windows.Forms.TextBox();
            this.txtStreetValue = new System.Windows.Forms.TextBox();
            this.txtPOBoxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCityValue = new System.Windows.Forms.TextBox();
            this.txtNewCountryValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNewWebPageValue = new System.Windows.Forms.TextBox();
            this.txtNewDescriptionValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewTelephoneValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewOfficeValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewMailValue = new System.Windows.Forms.TextBox();
            this.BtnSaveConfiguration = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewConfigurations = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigurations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtlastName);
            this.tabPage1.Controls.Add(this.btnRemoveConfiguration);
            this.tabPage1.Controls.Add(this.btnCreateUser);
            this.tabPage1.Controls.Add(this.comboBoxConfigurations);
            this.tabPage1.Controls.Add(this.txtfirstName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.Password);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Last Name";
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(321, 227);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(100, 20);
            this.txtlastName.TabIndex = 4;
            // 
            // btnRemoveConfiguration
            // 
            this.btnRemoveConfiguration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveConfiguration.Location = new System.Drawing.Point(455, 205);
            this.btnRemoveConfiguration.Name = "btnRemoveConfiguration";
            this.btnRemoveConfiguration.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveConfiguration.TabIndex = 8;
            this.btnRemoveConfiguration.Text = "Remove Config";
            this.btnRemoveConfiguration.UseVisualStyleBackColor = true;
            this.btnRemoveConfiguration.Click += new System.EventHandler(this.btnRemoveConfiguration_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateUser.Location = new System.Drawing.Point(321, 253);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 6;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // comboBoxConfigurations
            // 
            this.comboBoxConfigurations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigurations.FormattingEnabled = true;
            this.comboBoxConfigurations.Location = new System.Drawing.Point(455, 178);
            this.comboBoxConfigurations.Name = "comboBoxConfigurations";
            this.comboBoxConfigurations.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConfigurations.TabIndex = 5;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(321, 201);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(100, 20);
            this.txtfirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(321, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(246, 178);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(321, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.BtnSaveConfiguration);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Config";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.txtIPPhoneValue);
            this.groupBox6.Controls.Add(this.txtFaxValue);
            this.groupBox6.Controls.Add(this.txtMobileValue);
            this.groupBox6.Controls.Add(this.txtPagerValue);
            this.groupBox6.Controls.Add(this.txtHomePhoneValue);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Location = new System.Drawing.Point(278, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 151);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Telephones";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "IP Phone";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 95);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Fax";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Mobile";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Pager";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "Home";
            // 
            // txtIPPhoneValue
            // 
            this.txtIPPhoneValue.Location = new System.Drawing.Point(94, 118);
            this.txtIPPhoneValue.Name = "txtIPPhoneValue";
            this.txtIPPhoneValue.Size = new System.Drawing.Size(100, 20);
            this.txtIPPhoneValue.TabIndex = 19;
            // 
            // txtFaxValue
            // 
            this.txtFaxValue.Location = new System.Drawing.Point(94, 92);
            this.txtFaxValue.Name = "txtFaxValue";
            this.txtFaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtFaxValue.TabIndex = 18;
            // 
            // txtMobileValue
            // 
            this.txtMobileValue.Location = new System.Drawing.Point(94, 66);
            this.txtMobileValue.Name = "txtMobileValue";
            this.txtMobileValue.Size = new System.Drawing.Size(100, 20);
            this.txtMobileValue.TabIndex = 17;
            // 
            // txtPagerValue
            // 
            this.txtPagerValue.Location = new System.Drawing.Point(94, 40);
            this.txtPagerValue.Name = "txtPagerValue";
            this.txtPagerValue.Size = new System.Drawing.Size(100, 20);
            this.txtPagerValue.TabIndex = 16;
            // 
            // txtHomePhoneValue
            // 
            this.txtHomePhoneValue.Location = new System.Drawing.Point(94, 14);
            this.txtHomePhoneValue.Name = "txtHomePhoneValue";
            this.txtHomePhoneValue.Size = new System.Drawing.Size(100, 20);
            this.txtHomePhoneValue.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtManagerValue);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.txtTitleValue);
            this.groupBox5.Controls.Add(this.txtNewCompanyValue);
            this.groupBox5.Controls.Add(this.txtNewDepartmentValue);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Location = new System.Drawing.Point(6, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 151);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Organization";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 99);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Manager";
            // 
            // txtManagerValue
            // 
            this.txtManagerValue.Location = new System.Drawing.Point(142, 96);
            this.txtManagerValue.Name = "txtManagerValue";
            this.txtManagerValue.Size = new System.Drawing.Size(100, 20);
            this.txtManagerValue.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Title";
            // 
            // txtTitleValue
            // 
            this.txtTitleValue.Location = new System.Drawing.Point(142, 70);
            this.txtTitleValue.Name = "txtTitleValue";
            this.txtTitleValue.Size = new System.Drawing.Size(100, 20);
            this.txtTitleValue.TabIndex = 8;
            // 
            // txtNewCompanyValue
            // 
            this.txtNewCompanyValue.Location = new System.Drawing.Point(142, 18);
            this.txtNewCompanyValue.Name = "txtNewCompanyValue";
            this.txtNewCompanyValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewCompanyValue.TabIndex = 6;
            // 
            // txtNewDepartmentValue
            // 
            this.txtNewDepartmentValue.Location = new System.Drawing.Point(142, 44);
            this.txtNewDepartmentValue.Name = "txtNewDepartmentValue";
            this.txtNewDepartmentValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewDepartmentValue.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Company";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Department";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbxChangePasswordLogon);
            this.groupBox4.Controls.Add(this.chbxEnabled);
            this.groupBox4.Controls.Add(this.chbxCannotChangePassword);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtUPNSuffixValue);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNewConfigurationName);
            this.groupBox4.Controls.Add(this.txtNewContainerValue);
            this.groupBox4.Controls.Add(this.OU);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 174);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuration";
            // 
            // chbxChangePasswordLogon
            // 
            this.chbxChangePasswordLogon.AutoSize = true;
            this.chbxChangePasswordLogon.Location = new System.Drawing.Point(35, 151);
            this.chbxChangePasswordLogon.Name = "chbxChangePasswordLogon";
            this.chbxChangePasswordLogon.Size = new System.Drawing.Size(207, 17);
            this.chbxChangePasswordLogon.TabIndex = 17;
            this.chbxChangePasswordLogon.Text = "Change password on next logon";
            this.chbxChangePasswordLogon.UseVisualStyleBackColor = true;
            // 
            // chbxEnabled
            // 
            this.chbxEnabled.AutoSize = true;
            this.chbxEnabled.Location = new System.Drawing.Point(35, 105);
            this.chbxEnabled.Name = "chbxEnabled";
            this.chbxEnabled.Size = new System.Drawing.Size(72, 17);
            this.chbxEnabled.TabIndex = 4;
            this.chbxEnabled.Text = "Enabled";
            this.chbxEnabled.UseVisualStyleBackColor = true;
            // 
            // chbxCannotChangePassword
            // 
            this.chbxCannotChangePassword.AutoSize = true;
            this.chbxCannotChangePassword.Location = new System.Drawing.Point(35, 128);
            this.chbxCannotChangePassword.Name = "chbxCannotChangePassword";
            this.chbxCannotChangePassword.Size = new System.Drawing.Size(169, 17);
            this.chbxCannotChangePassword.TabIndex = 5;
            this.chbxCannotChangePassword.Text = "Cannot change password";
            this.chbxCannotChangePassword.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 70);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "UPN Suffix";
            // 
            // txtUPNSuffixValue
            // 
            this.txtUPNSuffixValue.Location = new System.Drawing.Point(142, 66);
            this.txtUPNSuffixValue.Name = "txtUPNSuffixValue";
            this.txtUPNSuffixValue.Size = new System.Drawing.Size(100, 20);
            this.txtUPNSuffixValue.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Configuration Name";
            // 
            // txtNewConfigurationName
            // 
            this.txtNewConfigurationName.Location = new System.Drawing.Point(142, 14);
            this.txtNewConfigurationName.Name = "txtNewConfigurationName";
            this.txtNewConfigurationName.Size = new System.Drawing.Size(100, 20);
            this.txtNewConfigurationName.TabIndex = 1;
            // 
            // txtNewContainerValue
            // 
            this.txtNewContainerValue.Location = new System.Drawing.Point(142, 40);
            this.txtNewContainerValue.Name = "txtNewContainerValue";
            this.txtNewContainerValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewContainerValue.TabIndex = 2;
            // 
            // OU
            // 
            this.OU.AutoSize = true;
            this.OU.Location = new System.Drawing.Point(6, 43);
            this.OU.Name = "OU";
            this.OU.Size = new System.Drawing.Size(25, 13);
            this.OU.TabIndex = 14;
            this.OU.Text = "OU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtConnectValue);
            this.groupBox3.Controls.Add(this.txthomeDirectoryValue);
            this.groupBox3.Controls.Add(this.txtscriptPathValue);
            this.groupBox3.Controls.Add(this.txtprofilePathValue);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(498, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 151);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile";
            // 
            // txtConnectValue
            // 
            this.txtConnectValue.Location = new System.Drawing.Point(105, 96);
            this.txtConnectValue.Name = "txtConnectValue";
            this.txtConnectValue.Size = new System.Drawing.Size(100, 20);
            this.txtConnectValue.TabIndex = 29;
            // 
            // txthomeDirectoryValue
            // 
            this.txthomeDirectoryValue.Location = new System.Drawing.Point(105, 71);
            this.txthomeDirectoryValue.Name = "txthomeDirectoryValue";
            this.txthomeDirectoryValue.Size = new System.Drawing.Size(100, 20);
            this.txthomeDirectoryValue.TabIndex = 28;
            // 
            // txtscriptPathValue
            // 
            this.txtscriptPathValue.Location = new System.Drawing.Point(105, 45);
            this.txtscriptPathValue.Name = "txtscriptPathValue";
            this.txtscriptPathValue.Size = new System.Drawing.Size(100, 20);
            this.txtscriptPathValue.TabIndex = 27;
            // 
            // txtprofilePathValue
            // 
            this.txtprofilePathValue.Location = new System.Drawing.Point(105, 20);
            this.txtprofilePathValue.Name = "txtprofilePathValue";
            this.txtprofilePathValue.Size = new System.Drawing.Size(100, 20);
            this.txtprofilePathValue.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Connect";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Local Path";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Logon Script";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Profile Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtZipValue);
            this.groupBox2.Controls.Add(this.txtStateValue);
            this.groupBox2.Controls.Add(this.txtStreetValue);
            this.groupBox2.Controls.Add(this.txtPOBoxValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNewCityValue);
            this.groupBox2.Controls.Add(this.txtNewCountryValue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(498, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 174);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Zip/Postal Code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "State/Province";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Street";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "P.O Box";
            // 
            // txtZipValue
            // 
            this.txtZipValue.Location = new System.Drawing.Point(105, 145);
            this.txtZipValue.Name = "txtZipValue";
            this.txtZipValue.Size = new System.Drawing.Size(100, 20);
            this.txtZipValue.TabIndex = 25;
            // 
            // txtStateValue
            // 
            this.txtStateValue.Location = new System.Drawing.Point(105, 119);
            this.txtStateValue.Name = "txtStateValue";
            this.txtStateValue.Size = new System.Drawing.Size(100, 20);
            this.txtStateValue.TabIndex = 24;
            // 
            // txtStreetValue
            // 
            this.txtStreetValue.Location = new System.Drawing.Point(105, 15);
            this.txtStreetValue.Name = "txtStreetValue";
            this.txtStreetValue.Size = new System.Drawing.Size(100, 20);
            this.txtStreetValue.TabIndex = 20;
            // 
            // txtPOBoxValue
            // 
            this.txtPOBoxValue.Location = new System.Drawing.Point(105, 41);
            this.txtPOBoxValue.Name = "txtPOBoxValue";
            this.txtPOBoxValue.Size = new System.Drawing.Size(100, 20);
            this.txtPOBoxValue.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "City";
            // 
            // txtNewCityValue
            // 
            this.txtNewCityValue.Location = new System.Drawing.Point(105, 67);
            this.txtNewCityValue.Name = "txtNewCityValue";
            this.txtNewCityValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewCityValue.TabIndex = 22;
            // 
            // txtNewCountryValue
            // 
            this.txtNewCountryValue.Location = new System.Drawing.Point(105, 93);
            this.txtNewCountryValue.Name = "txtNewCountryValue";
            this.txtNewCountryValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewCountryValue.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Country";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtNewWebPageValue);
            this.groupBox1.Controls.Add(this.txtNewDescriptionValue);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNewTelephoneValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNewOfficeValue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNewMailValue);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(278, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 174);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Web Page";
            // 
            // txtNewWebPageValue
            // 
            this.txtNewWebPageValue.Location = new System.Drawing.Point(94, 94);
            this.txtNewWebPageValue.Name = "txtNewWebPageValue";
            this.txtNewWebPageValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewWebPageValue.TabIndex = 13;
            // 
            // txtNewDescriptionValue
            // 
            this.txtNewDescriptionValue.Location = new System.Drawing.Point(94, 120);
            this.txtNewDescriptionValue.Name = "txtNewDescriptionValue";
            this.txtNewDescriptionValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewDescriptionValue.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telephone";
            // 
            // txtNewTelephoneValue
            // 
            this.txtNewTelephoneValue.Location = new System.Drawing.Point(94, 68);
            this.txtNewTelephoneValue.Name = "txtNewTelephoneValue";
            this.txtNewTelephoneValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewTelephoneValue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Office";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description";
            // 
            // txtNewOfficeValue
            // 
            this.txtNewOfficeValue.Location = new System.Drawing.Point(94, 42);
            this.txtNewOfficeValue.Name = "txtNewOfficeValue";
            this.txtNewOfficeValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewOfficeValue.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // txtNewMailValue
            // 
            this.txtNewMailValue.Location = new System.Drawing.Point(94, 16);
            this.txtNewMailValue.Name = "txtNewMailValue";
            this.txtNewMailValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewMailValue.TabIndex = 10;
            // 
            // BtnSaveConfiguration
            // 
            this.BtnSaveConfiguration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSaveConfiguration.Location = new System.Drawing.Point(333, 392);
            this.BtnSaveConfiguration.Name = "BtnSaveConfiguration";
            this.BtnSaveConfiguration.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveConfiguration.TabIndex = 30;
            this.BtnSaveConfiguration.Text = "Save Config";
            this.BtnSaveConfiguration.UseVisualStyleBackColor = true;
            this.BtnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewConfigurations);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(740, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConfigurations
            // 
            this.dataGridViewConfigurations.AllowUserToAddRows = false;
            this.dataGridViewConfigurations.AllowUserToDeleteRows = false;
            this.dataGridViewConfigurations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewConfigurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigurations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewConfigurations.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConfigurations.Name = "dataGridViewConfigurations";
            this.dataGridViewConfigurations.Size = new System.Drawing.Size(734, 418);
            this.dataGridViewConfigurations.TabIndex = 0;
            this.dataGridViewConfigurations.CellEndEdit += dataGridViewConfigurations_CellEndEdit;
            // 
            // ActiveDirectoryTool
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(772, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "ActiveDirectoryTool";
            this.Text = "Active Directory Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigurations)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxConfigurations;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNewDescriptionValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewMailValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewCompanyValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCityValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewConfigurationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button BtnSaveConfiguration;
        private System.Windows.Forms.Button btnRemoveConfiguration;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewConfigurations;
        private Label OU;
        private TextBox txtNewContainerValue;
        private Label label11;
        private Label label10;
        private TextBox txtNewDepartmentValue;
        private TextBox txtNewCountryValue;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNewOfficeValue;
        private Label label12;
        private TextBox txtlastName;
        private Label label13;
        private TextBox txtNewTelephoneValue;
        private Label label14;
        private TextBox txtNewWebPageValue;
        private GroupBox groupBox2;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtZipValue;
        private TextBox txtStateValue;
        private TextBox txtStreetValue;
        private TextBox txtPOBoxValue;
        private GroupBox groupBox3;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox txtConnectValue;
        private TextBox txthomeDirectoryValue;
        private TextBox txtscriptPathValue;
        private TextBox txtprofilePathValue;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label24;
        private TextBox txtManagerValue;
        private Label label23;
        private TextBox txtTitleValue;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private TextBox txtIPPhoneValue;
        private TextBox txtFaxValue;
        private TextBox txtMobileValue;
        private TextBox txtPagerValue;
        private TextBox txtHomePhoneValue;
        private Label label25;
        private TextBox txtUPNSuffixValue;
        private CheckBox chbxEnabled;
        private CheckBox chbxCannotChangePassword;
        private CheckBox chbxChangePasswordLogon;
    }
}

