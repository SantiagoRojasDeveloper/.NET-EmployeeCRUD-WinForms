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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdentification = new System.Windows.Forms.TextBox();
            this.TxtTypeIdentification = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DtgEmployees = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PictureEmployee = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnClearEdit = new System.Windows.Forms.Button();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCellphone = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD De Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(158, 79);
            this.TxtName.MaxLength = 30;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(165, 20);
            this.TxtName.TabIndex = 3;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(475, 79);
            this.TxtSurname.MaxLength = 30;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(165, 20);
            this.TxtSurname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Identificación";
            // 
            // TxtIdentification
            // 
            this.TxtIdentification.Location = new System.Drawing.Point(475, 105);
            this.TxtIdentification.MaxLength = 12;
            this.TxtIdentification.Name = "TxtIdentification";
            this.TxtIdentification.Size = new System.Drawing.Size(165, 20);
            this.TxtIdentification.TabIndex = 8;
            this.TxtIdentification.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtTypeIdentification
            // 
            this.TxtTypeIdentification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtTypeIdentification.FormattingEnabled = true;
            this.TxtTypeIdentification.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Número de Identidad",
            "Registro Civil",
            "Pasaporte"});
            this.TxtTypeIdentification.Location = new System.Drawing.Point(158, 105);
            this.TxtTypeIdentification.Name = "TxtTypeIdentification";
            this.TxtTypeIdentification.Size = new System.Drawing.Size(165, 21);
            this.TxtTypeIdentification.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Identificación";
            // 
            // TxtGender
            // 
            this.TxtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtGender.FormattingEnabled = true;
            this.TxtGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.TxtGender.Location = new System.Drawing.Point(158, 132);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(165, 21);
            this.TxtGender.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genero";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(565, 244);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(484, 244);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // DtgEmployees
            // 
            this.DtgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmployees.Location = new System.Drawing.Point(19, 273);
            this.DtgEmployees.Name = "DtgEmployees";
            this.DtgEmployees.Size = new System.Drawing.Size(840, 165);
            this.DtgEmployees.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(755, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtBirthDate
            // 
            this.TxtBirthDate.Location = new System.Drawing.Point(475, 132);
            this.TxtBirthDate.Mask = "00/00/0000";
            this.TxtBirthDate.Name = "TxtBirthDate";
            this.TxtBirthDate.Size = new System.Drawing.Size(165, 20);
            this.TxtBirthDate.TabIndex = 18;
            this.TxtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PictureEmployee
            // 
            this.PictureEmployee.Location = new System.Drawing.Point(671, 79);
            this.PictureEmployee.Name = "PictureEmployee";
            this.PictureEmployee.Size = new System.Drawing.Size(188, 188);
            this.PictureEmployee.TabIndex = 19;
            this.PictureEmployee.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cargar imagen\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Imagen de perfil";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(484, 244);
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
            this.BtnClearEdit.Location = new System.Drawing.Point(371, 244);
            this.BtnClearEdit.Name = "BtnClearEdit";
            this.BtnClearEdit.Size = new System.Drawing.Size(107, 23);
            this.BtnClearEdit.TabIndex = 23;
            this.BtnClearEdit.Text = "Limpiar Edición";
            this.BtnClearEdit.UseVisualStyleBackColor = true;
            this.BtnClearEdit.Visible = false;
            this.BtnClearEdit.Click += new System.EventHandler(this.BtnClearEdit_Click);
            // 
            // TxtPosition
            // 
            this.TxtPosition.Location = new System.Drawing.Point(158, 161);
            this.TxtPosition.MaxLength = 30;
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(165, 20);
            this.TxtPosition.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Puesto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(158, 187);
            this.TxtCountry.MaxLength = 30;
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(165, 20);
            this.TxtCountry.TabIndex = 26;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(475, 187);
            this.TxtCode.MaxLength = 30;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(165, 20);
            this.TxtCode.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Nacionalidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Código";
            // 
            // TxtCellphone
            // 
            this.TxtCellphone.Location = new System.Drawing.Point(158, 213);
            this.TxtCellphone.MaxLength = 30;
            this.TxtCellphone.Name = "TxtCellphone";
            this.TxtCellphone.Size = new System.Drawing.Size(165, 20);
            this.TxtCellphone.TabIndex = 30;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(475, 213);
            this.TxtPhone.MaxLength = 30;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(165, 20);
            this.TxtPhone.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(330, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Teléfono Fijo";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 466);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtCellphone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.BtnClearEdit);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PictureEmployee);
            this.Controls.Add(this.TxtBirthDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DtgEmployees);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTypeIdentification);
            this.Controls.Add(this.TxtIdentification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdentification;
        private System.Windows.Forms.ComboBox TxtTypeIdentification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TxtGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DtgEmployees;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox TxtBirthDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PictureEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClearEdit;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCellphone;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}