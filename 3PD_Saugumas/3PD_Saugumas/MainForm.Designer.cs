namespace _3PD_Saugumas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlgorithmName = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptorSelect = new System.Windows.Forms.Button();
            this.DecryptorSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstPrimeInput = new System.Windows.Forms.TextBox();
            this.SecondPrimeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EncryptedOutputDecimal = new System.Windows.Forms.TextBox();
            this.EncryptorPanel = new System.Windows.Forms.Panel();
            this.SavePublicKey = new System.Windows.Forms.Button();
            this.SaveEncryptedData = new System.Windows.Forms.Button();
            this.EncryptionEOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PhiOutput = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ModulusNOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DecryptorPanel = new System.Windows.Forms.Panel();
            this.LoadEncryptedData = new System.Windows.Forms.Button();
            this.PrivateExponentInput = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.publicExponentInput = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SecondPrimeNumbr = new System.Windows.Forms.Label();
            this.SecondPrimeNumber = new System.Windows.Forms.Label();
            this.FirstPrimeNumber = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.phiFunctionInput = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DecryptOutputChar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DecryptOutputDecimal = new System.Windows.Forms.TextBox();
            this.ModulusNInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DecyptSelect = new System.Windows.Forms.Button();
            this.EncryptorPanel.SuspendLayout();
            this.DecryptorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlgorithmName
            // 
            this.AlgorithmName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AlgorithmName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmName.ForeColor = System.Drawing.Color.White;
            this.AlgorithmName.Location = new System.Drawing.Point(-1, -2);
            this.AlgorithmName.Name = "AlgorithmName";
            this.AlgorithmName.Size = new System.Drawing.Size(556, 96);
            this.AlgorithmName.TabIndex = 0;
            this.AlgorithmName.Text = "RSA Algorithm";
            this.AlgorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputText.Location = new System.Drawing.Point(0, 24);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(530, 79);
            this.InputText.TabIndex = 1;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cipher Message";
            // 
            // EncryptorSelect
            // 
            this.EncryptorSelect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EncryptorSelect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.EncryptorSelect.FlatAppearance.BorderSize = 3;
            this.EncryptorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptorSelect.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptorSelect.ForeColor = System.Drawing.Color.White;
            this.EncryptorSelect.Location = new System.Drawing.Point(12, 116);
            this.EncryptorSelect.Name = "EncryptorSelect";
            this.EncryptorSelect.Size = new System.Drawing.Size(225, 61);
            this.EncryptorSelect.TabIndex = 3;
            this.EncryptorSelect.Text = "Encryptor";
            this.EncryptorSelect.UseVisualStyleBackColor = false;
            this.EncryptorSelect.Click += new System.EventHandler(this.EncryptorSelect_Click);
            // 
            // DecryptorSelect
            // 
            this.DecryptorSelect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DecryptorSelect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DecryptorSelect.FlatAppearance.BorderSize = 0;
            this.DecryptorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptorSelect.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptorSelect.ForeColor = System.Drawing.Color.White;
            this.DecryptorSelect.Location = new System.Drawing.Point(317, 116);
            this.DecryptorSelect.Name = "DecryptorSelect";
            this.DecryptorSelect.Size = new System.Drawing.Size(225, 61);
            this.DecryptorSelect.TabIndex = 3;
            this.DecryptorSelect.Text = "Decryptor";
            this.DecryptorSelect.UseVisualStyleBackColor = false;
            this.DecryptorSelect.Click += new System.EventHandler(this.DecryptorSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Prime Number";
            // 
            // FirstPrimeInput
            // 
            this.FirstPrimeInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPrimeInput.Location = new System.Drawing.Point(0, 154);
            this.FirstPrimeInput.Multiline = true;
            this.FirstPrimeInput.Name = "FirstPrimeInput";
            this.FirstPrimeInput.Size = new System.Drawing.Size(225, 41);
            this.FirstPrimeInput.TabIndex = 4;
            this.FirstPrimeInput.TextChanged += new System.EventHandler(this.FirstPrimeInput_TextChanged);
            // 
            // SecondPrimeInput
            // 
            this.SecondPrimeInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPrimeInput.Location = new System.Drawing.Point(305, 154);
            this.SecondPrimeInput.Multiline = true;
            this.SecondPrimeInput.Name = "SecondPrimeInput";
            this.SecondPrimeInput.Size = new System.Drawing.Size(225, 41);
            this.SecondPrimeInput.TabIndex = 4;
            this.SecondPrimeInput.TextChanged += new System.EventHandler(this.SecondPrimeInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second Prime Number";
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EncryptButton.FlatAppearance.BorderSize = 0;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptButton.ForeColor = System.Drawing.Color.White;
            this.EncryptButton.Location = new System.Drawing.Point(0, 223);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(530, 61);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Encrypted Message (DECIMAL)";
            // 
            // EncryptedOutputDecimal
            // 
            this.EncryptedOutputDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptedOutputDecimal.Location = new System.Drawing.Point(0, 516);
            this.EncryptedOutputDecimal.Multiline = true;
            this.EncryptedOutputDecimal.Name = "EncryptedOutputDecimal";
            this.EncryptedOutputDecimal.Size = new System.Drawing.Size(530, 79);
            this.EncryptedOutputDecimal.TabIndex = 7;
            // 
            // EncryptorPanel
            // 
            this.EncryptorPanel.Controls.Add(this.SavePublicKey);
            this.EncryptorPanel.Controls.Add(this.SaveEncryptedData);
            this.EncryptorPanel.Controls.Add(this.EncryptionEOutput);
            this.EncryptorPanel.Controls.Add(this.label14);
            this.EncryptorPanel.Controls.Add(this.PhiOutput);
            this.EncryptorPanel.Controls.Add(this.label9);
            this.EncryptorPanel.Controls.Add(this.ModulusNOutput);
            this.EncryptorPanel.Controls.Add(this.label7);
            this.EncryptorPanel.Controls.Add(this.EncryptedOutputDecimal);
            this.EncryptorPanel.Controls.Add(this.label4);
            this.EncryptorPanel.Controls.Add(this.InputText);
            this.EncryptorPanel.Controls.Add(this.label1);
            this.EncryptorPanel.Controls.Add(this.EncryptButton);
            this.EncryptorPanel.Controls.Add(this.label2);
            this.EncryptorPanel.Controls.Add(this.FirstPrimeInput);
            this.EncryptorPanel.Controls.Add(this.SecondPrimeInput);
            this.EncryptorPanel.Controls.Add(this.label3);
            this.EncryptorPanel.Location = new System.Drawing.Point(12, 199);
            this.EncryptorPanel.Name = "EncryptorPanel";
            this.EncryptorPanel.Size = new System.Drawing.Size(530, 697);
            this.EncryptorPanel.TabIndex = 9;
            // 
            // SavePublicKey
            // 
            this.SavePublicKey.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SavePublicKey.FlatAppearance.BorderSize = 0;
            this.SavePublicKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePublicKey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SavePublicKey.ForeColor = System.Drawing.Color.White;
            this.SavePublicKey.Location = new System.Drawing.Point(307, 624);
            this.SavePublicKey.Name = "SavePublicKey";
            this.SavePublicKey.Size = new System.Drawing.Size(223, 61);
            this.SavePublicKey.TabIndex = 19;
            this.SavePublicKey.Text = "Save Public Key";
            this.SavePublicKey.UseVisualStyleBackColor = false;
            this.SavePublicKey.Click += new System.EventHandler(this.SavePublicKey_Click);
            // 
            // SaveEncryptedData
            // 
            this.SaveEncryptedData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SaveEncryptedData.FlatAppearance.BorderSize = 0;
            this.SaveEncryptedData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEncryptedData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEncryptedData.ForeColor = System.Drawing.Color.White;
            this.SaveEncryptedData.Location = new System.Drawing.Point(0, 624);
            this.SaveEncryptedData.Name = "SaveEncryptedData";
            this.SaveEncryptedData.Size = new System.Drawing.Size(223, 61);
            this.SaveEncryptedData.TabIndex = 18;
            this.SaveEncryptedData.Text = "Save Encrypted Data";
            this.SaveEncryptedData.UseVisualStyleBackColor = false;
            this.SaveEncryptedData.Click += new System.EventHandler(this.SaveEncryptedData_Click);
            // 
            // EncryptionEOutput
            // 
            this.EncryptionEOutput.BackColor = System.Drawing.Color.Silver;
            this.EncryptionEOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptionEOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EncryptionEOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EncryptionEOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EncryptionEOutput.Location = new System.Drawing.Point(0, 420);
            this.EncryptionEOutput.Name = "EncryptionEOutput";
            this.EncryptionEOutput.Size = new System.Drawing.Size(225, 41);
            this.EncryptionEOutput.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(0, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Public Exponent (Key)";
            // 
            // PhiOutput
            // 
            this.PhiOutput.BackColor = System.Drawing.Color.Silver;
            this.PhiOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhiOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PhiOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhiOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PhiOutput.Location = new System.Drawing.Point(305, 334);
            this.PhiOutput.Name = "PhiOutput";
            this.PhiOutput.Size = new System.Drawing.Size(225, 41);
            this.PhiOutput.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(305, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Totient (phi) function";
            // 
            // ModulusNOutput
            // 
            this.ModulusNOutput.BackColor = System.Drawing.Color.Silver;
            this.ModulusNOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModulusNOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ModulusNOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModulusNOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ModulusNOutput.Location = new System.Drawing.Point(0, 334);
            this.ModulusNOutput.Name = "ModulusNOutput";
            this.ModulusNOutput.Size = new System.Drawing.Size(225, 41);
            this.ModulusNOutput.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Modulus N";
            // 
            // DecryptorPanel
            // 
            this.DecryptorPanel.Controls.Add(this.LoadEncryptedData);
            this.DecryptorPanel.Controls.Add(this.PrivateExponentInput);
            this.DecryptorPanel.Controls.Add(this.label23);
            this.DecryptorPanel.Controls.Add(this.publicExponentInput);
            this.DecryptorPanel.Controls.Add(this.label22);
            this.DecryptorPanel.Controls.Add(this.SecondPrimeNumbr);
            this.DecryptorPanel.Controls.Add(this.SecondPrimeNumber);
            this.DecryptorPanel.Controls.Add(this.FirstPrimeNumber);
            this.DecryptorPanel.Controls.Add(this.label21);
            this.DecryptorPanel.Controls.Add(this.phiFunctionInput);
            this.DecryptorPanel.Controls.Add(this.label17);
            this.DecryptorPanel.Controls.Add(this.DecryptOutputChar);
            this.DecryptorPanel.Controls.Add(this.label11);
            this.DecryptorPanel.Controls.Add(this.label8);
            this.DecryptorPanel.Controls.Add(this.DecryptOutputDecimal);
            this.DecryptorPanel.Controls.Add(this.ModulusNInput);
            this.DecryptorPanel.Controls.Add(this.label5);
            this.DecryptorPanel.Controls.Add(this.MessageInput);
            this.DecryptorPanel.Controls.Add(this.label6);
            this.DecryptorPanel.Controls.Add(this.DecyptSelect);
            this.DecryptorPanel.Location = new System.Drawing.Point(12, 199);
            this.DecryptorPanel.Name = "DecryptorPanel";
            this.DecryptorPanel.Size = new System.Drawing.Size(530, 779);
            this.DecryptorPanel.TabIndex = 10;
            // 
            // LoadEncryptedData
            // 
            this.LoadEncryptedData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoadEncryptedData.FlatAppearance.BorderSize = 0;
            this.LoadEncryptedData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadEncryptedData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadEncryptedData.ForeColor = System.Drawing.Color.White;
            this.LoadEncryptedData.Location = new System.Drawing.Point(305, 145);
            this.LoadEncryptedData.Name = "LoadEncryptedData";
            this.LoadEncryptedData.Size = new System.Drawing.Size(225, 41);
            this.LoadEncryptedData.TabIndex = 20;
            this.LoadEncryptedData.Text = "Load Encrypted Data";
            this.LoadEncryptedData.UseVisualStyleBackColor = false;
            this.LoadEncryptedData.Click += new System.EventHandler(this.LoadEncryptedData_Click);
            // 
            // PrivateExponentInput
            // 
            this.PrivateExponentInput.BackColor = System.Drawing.Color.Silver;
            this.PrivateExponentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrivateExponentInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrivateExponentInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrivateExponentInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PrivateExponentInput.Location = new System.Drawing.Point(0, 491);
            this.PrivateExponentInput.Name = "PrivateExponentInput";
            this.PrivateExponentInput.Size = new System.Drawing.Size(225, 41);
            this.PrivateExponentInput.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(0, 470);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(165, 21);
            this.label23.TabIndex = 30;
            this.label23.Text = "Private Exponent (Key)";
            // 
            // publicExponentInput
            // 
            this.publicExponentInput.BackColor = System.Drawing.Color.Silver;
            this.publicExponentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publicExponentInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.publicExponentInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publicExponentInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.publicExponentInput.Location = new System.Drawing.Point(0, 398);
            this.publicExponentInput.Name = "publicExponentInput";
            this.publicExponentInput.Size = new System.Drawing.Size(225, 41);
            this.publicExponentInput.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(0, 377);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(159, 21);
            this.label22.TabIndex = 26;
            this.label22.Text = "Public Exponent (Key)";
            // 
            // SecondPrimeNumbr
            // 
            this.SecondPrimeNumbr.BackColor = System.Drawing.Color.Silver;
            this.SecondPrimeNumbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondPrimeNumbr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SecondPrimeNumbr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPrimeNumbr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SecondPrimeNumbr.Location = new System.Drawing.Point(305, 312);
            this.SecondPrimeNumbr.Name = "SecondPrimeNumbr";
            this.SecondPrimeNumbr.Size = new System.Drawing.Size(225, 41);
            this.SecondPrimeNumbr.TabIndex = 24;
            // 
            // SecondPrimeNumber
            // 
            this.SecondPrimeNumber.AutoSize = true;
            this.SecondPrimeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondPrimeNumber.Location = new System.Drawing.Point(305, 291);
            this.SecondPrimeNumber.Name = "SecondPrimeNumber";
            this.SecondPrimeNumber.Size = new System.Drawing.Size(168, 21);
            this.SecondPrimeNumber.TabIndex = 22;
            this.SecondPrimeNumber.Text = "Second Prime Number";
            // 
            // FirstPrimeNumber
            // 
            this.FirstPrimeNumber.BackColor = System.Drawing.Color.Silver;
            this.FirstPrimeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstPrimeNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FirstPrimeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPrimeNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FirstPrimeNumber.Location = new System.Drawing.Point(0, 312);
            this.FirstPrimeNumber.Name = "FirstPrimeNumber";
            this.FirstPrimeNumber.Size = new System.Drawing.Size(225, 41);
            this.FirstPrimeNumber.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(0, 291);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 21);
            this.label21.TabIndex = 23;
            this.label21.Text = "First Prime Number";
            // 
            // phiFunctionInput
            // 
            this.phiFunctionInput.BackColor = System.Drawing.Color.Silver;
            this.phiFunctionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phiFunctionInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.phiFunctionInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phiFunctionInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phiFunctionInput.Location = new System.Drawing.Point(305, 398);
            this.phiFunctionInput.Name = "phiFunctionInput";
            this.phiFunctionInput.Size = new System.Drawing.Size(225, 41);
            this.phiFunctionInput.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(305, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 21);
            this.label17.TabIndex = 20;
            this.label17.Text = "Totient (phi) function";
            // 
            // DecryptOutputChar
            // 
            this.DecryptOutputChar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecryptOutputChar.Location = new System.Drawing.Point(0, 700);
            this.DecryptOutputChar.Multiline = true;
            this.DecryptOutputChar.Name = "DecryptOutputChar";
            this.DecryptOutputChar.Size = new System.Drawing.Size(530, 79);
            this.DecryptOutputChar.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 676);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Decrypted Message (CHAR)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Modulus N";
            // 
            // DecryptOutputDecimal
            // 
            this.DecryptOutputDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecryptOutputDecimal.Location = new System.Drawing.Point(0, 576);
            this.DecryptOutputDecimal.Multiline = true;
            this.DecryptOutputDecimal.Name = "DecryptOutputDecimal";
            this.DecryptOutputDecimal.Size = new System.Drawing.Size(530, 79);
            this.DecryptOutputDecimal.TabIndex = 7;
            // 
            // ModulusNInput
            // 
            this.ModulusNInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModulusNInput.Location = new System.Drawing.Point(0, 145);
            this.ModulusNInput.Multiline = true;
            this.ModulusNInput.Name = "ModulusNInput";
            this.ModulusNInput.Size = new System.Drawing.Size(225, 41);
            this.ModulusNInput.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decrypted Message (DECIMAL)";
            // 
            // MessageInput
            // 
            this.MessageInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageInput.Location = new System.Drawing.Point(0, 24);
            this.MessageInput.Multiline = true;
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(530, 79);
            this.MessageInput.TabIndex = 1;
            this.MessageInput.TextChanged += new System.EventHandler(this.MessageInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Message To Decypher (DECIMAL)";
            // 
            // DecyptSelect
            // 
            this.DecyptSelect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DecyptSelect.FlatAppearance.BorderSize = 0;
            this.DecyptSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecyptSelect.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecyptSelect.ForeColor = System.Drawing.Color.White;
            this.DecyptSelect.Location = new System.Drawing.Point(0, 214);
            this.DecyptSelect.Name = "DecyptSelect";
            this.DecyptSelect.Size = new System.Drawing.Size(530, 61);
            this.DecyptSelect.TabIndex = 6;
            this.DecyptSelect.Text = "Decrypt";
            this.DecyptSelect.UseVisualStyleBackColor = false;
            this.DecyptSelect.Click += new System.EventHandler(this.DecyptSelect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 990);
            this.Controls.Add(this.EncryptorPanel);
            this.Controls.Add(this.DecryptorSelect);
            this.Controls.Add(this.EncryptorSelect);
            this.Controls.Add(this.AlgorithmName);
            this.Controls.Add(this.DecryptorPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.EncryptorPanel.ResumeLayout(false);
            this.EncryptorPanel.PerformLayout();
            this.DecryptorPanel.ResumeLayout(false);
            this.DecryptorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label AlgorithmName;
        private TextBox InputText;
        private Label label1;
        private Button EncryptorSelect;
        private Button DecryptorSelect;
        private Label label2;
        private TextBox FirstPrimeInput;
        private TextBox SecondPrimeInput;
        private Label label3;
        private Button EncryptButton;
        private Label label4;
        private TextBox EncryptedOutputDecimal;
        private Panel EncryptorPanel;
        private Panel DecryptorPanel;
        private TextBox DecryptOutputDecimal;
        private Label label5;
        private TextBox MessageInput;
        private Label label6;
        private Button DecyptSelect;
        private Label label7;
        private Label PhiOutput;
        private Label label9;
        private Label ModulusNOutput;
        private Label EncryptionEOutput;
        private Label label14;
        private Label label8;
        private TextBox ModulusNInput;
        private Label FirstPrimeNumber;
        private Label label21;
        private Label phiFunctionInput;
        private Label label17;
        private TextBox DecryptOutputChar;
        private Label label11;
        private Label publicExponentInput;
        private Label label22;
        private Label PrivateExponentInput;
        private Label label23;
        private Label SecondPrimeNumbr;
        private Label SecondPrimeNumber;
        private Button SavePublicKey;
        private Button SaveEncryptedData;
        private Button LoadEncryptedData;
    }
}