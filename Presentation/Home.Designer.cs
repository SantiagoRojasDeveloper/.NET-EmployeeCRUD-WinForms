namespace Presentation
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PictureEmployee = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClearEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.TxtAcNo = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.ComboBox();
            this.TxtNacionality = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtCodTar = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDischargeDate = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.TxtRol = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "AC No.";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(565, 205);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(565, 205);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PictureEmployee
            // 
            this.PictureEmployee.Location = new System.Drawing.Point(672, 33);
            this.PictureEmployee.Name = "PictureEmployee";
            this.PictureEmployee.Size = new System.Drawing.Size(177, 177);
            this.PictureEmployee.TabIndex = 19;
            this.PictureEmployee.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Imagen de perfil";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(484, 205);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 22;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnClearEdit
            // 
            this.BtnClearEdit.Location = new System.Drawing.Point(371, 205);
            this.BtnClearEdit.Name = "BtnClearEdit";
            this.BtnClearEdit.Size = new System.Drawing.Size(107, 23);
            this.BtnClearEdit.TabIndex = 23;
            this.BtnClearEdit.Text = "Limpiar Edición";
            this.BtnClearEdit.UseVisualStyleBackColor = true;
            this.BtnClearEdit.Visible = false;
            this.BtnClearEdit.Click += new System.EventHandler(this.BtnClearEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cargar imagen\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtBirthdate
            // 
            this.TxtBirthdate.Location = new System.Drawing.Point(148, 123);
            this.TxtBirthdate.Mask = "00/00/0000";
            this.TxtBirthdate.Name = "TxtBirthdate";
            this.TxtBirthdate.Size = new System.Drawing.Size(165, 20);
            this.TxtBirthdate.TabIndex = 18;
            this.TxtBirthdate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtAcNo
            // 
            this.TxtAcNo.Location = new System.Drawing.Point(148, 18);
            this.TxtAcNo.MaxLength = 30;
            this.TxtAcNo.Name = "TxtAcNo";
            this.TxtAcNo.Size = new System.Drawing.Size(165, 20);
            this.TxtAcNo.TabIndex = 34;
            this.TxtAcNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtGender
            // 
            this.TxtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtGender.FormattingEnabled = true;
            this.TxtGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.TxtGender.Location = new System.Drawing.Point(148, 44);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(165, 21);
            this.TxtGender.TabIndex = 35;
            // 
            // TxtNacionality
            // 
            this.TxtNacionality.Location = new System.Drawing.Point(148, 71);
            this.TxtNacionality.MaxLength = 30;
            this.TxtNacionality.Name = "TxtNacionality";
            this.TxtNacionality.Size = new System.Drawing.Size(165, 20);
            this.TxtNacionality.TabIndex = 36;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(148, 97);
            this.TxtCargo.MaxLength = 30;
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(165, 20);
            this.TxtCargo.TabIndex = 37;
            // 
            // TxtCodTar
            // 
            this.TxtCodTar.Location = new System.Drawing.Point(148, 149);
            this.TxtCodTar.MaxLength = 30;
            this.TxtCodTar.Name = "TxtCodTar";
            this.TxtCodTar.Size = new System.Drawing.Size(165, 20);
            this.TxtCodTar.TabIndex = 38;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(148, 175);
            this.TxtAddress.MaxLength = 30;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(165, 20);
            this.TxtAddress.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nacionalidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha Nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cod. tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Domicilio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "No. Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Fecha Alta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Privilegios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(382, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Tel. Oficina";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(436, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "No.";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(475, 149);
            this.TxtPhone.MaxLength = 30;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(165, 20);
            this.TxtPhone.TabIndex = 52;
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Location = new System.Drawing.Point(475, 71);
            this.TxtTelephone.MaxLength = 30;
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(165, 20);
            this.TxtTelephone.TabIndex = 50;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(475, 18);
            this.TxtName.MaxLength = 30;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(165, 20);
            this.TxtName.TabIndex = 48;
            // 
            // TxtDischargeDate
            // 
            this.TxtDischargeDate.Location = new System.Drawing.Point(475, 123);
            this.TxtDischargeDate.Mask = "00/00/0000";
            this.TxtDischargeDate.Name = "TxtDischargeDate";
            this.TxtDischargeDate.Size = new System.Drawing.Size(165, 20);
            this.TxtDischargeDate.TabIndex = 47;
            this.TxtDischargeDate.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(410, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Nombre";
            // 
            // TxtNo
            // 
            this.TxtNo.Location = new System.Drawing.Point(475, 45);
            this.TxtNo.MaxLength = 30;
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(165, 20);
            this.TxtNo.TabIndex = 58;
            // 
            // TxtRol
            // 
            this.TxtRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtRol.FormattingEnabled = true;
            this.TxtRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.TxtRol.Location = new System.Drawing.Point(475, 97);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(165, 21);
            this.TxtRol.TabIndex = 59;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(484, 205);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 60;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 240);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtRol);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtDischargeDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtCodTar);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.TxtNacionality);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.TxtAcNo);
            this.Controls.Add(this.BtnClearEdit);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PictureEmployee);
            this.Controls.Add(this.TxtBirthdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.PictureEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PictureEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClearEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox TxtBirthdate;
        private System.Windows.Forms.TextBox TxtAcNo;
        private System.Windows.Forms.ComboBox TxtGender;
        private System.Windows.Forms.TextBox TxtNacionality;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtCodTar;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox TxtDischargeDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.ComboBox TxtRol;
        private System.Windows.Forms.Button BtnSearch;
    }
}