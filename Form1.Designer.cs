namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblData = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            radioButtonPR = new RadioButton();
            radioButtonLK = new RadioButton();
            btnReset = new Button();
            btnClose = new Button();
            btnDaftar = new Button();
            comboBoxTahun = new ComboBox();
            comboBoxBulan = new ComboBox();
            comboBoxTanggal = new ComboBox();
            txtEmail = new TextBox();
            txtTempatLahir = new TextBox();
            txtNoHP = new TextBox();
            txtAlamat = new TextBox();
            txtNama = new TextBox();
            txtNomor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label19 = new Label();
            button5 = new Button();
            button4 = new Button();
            monthCalendar1 = new MonthCalendar();
            txtTanggalDaftar = new TextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 30);
            label1.Name = "label1";
            label1.Size = new Size(439, 28);
            label1.TabIndex = 0;
            label1.Text = "Formulir Pendaftaran Siswa Baru Tahun 2023";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblData);
            groupBox1.Location = new Point(469, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 158);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Pendaftar";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(21, 20);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 9;
            lblData.Text = "Data";
            lblData.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(radioButtonPR);
            groupBox2.Controls.Add(radioButtonLK);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnDaftar);
            groupBox2.Controls.Add(comboBoxTahun);
            groupBox2.Controls.Add(comboBoxBulan);
            groupBox2.Controls.Add(comboBoxTanggal);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtTempatLahir);
            groupBox2.Controls.Add(txtNoHP);
            groupBox2.Controls.Add(txtAlamat);
            groupBox2.Controls.Add(txtNama);
            groupBox2.Controls.Add(txtNomor);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(31, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 399);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formulir";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(128, 313);
            label18.Name = "label18";
            label18.Size = new Size(10, 15);
            label18.TabIndex = 61;
            label18.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(128, 281);
            label17.Name = "label17";
            label17.Size = new Size(10, 15);
            label17.TabIndex = 60;
            label17.Text = ":";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(128, 252);
            label16.Name = "label16";
            label16.Size = new Size(10, 15);
            label16.TabIndex = 59;
            label16.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(128, 222);
            label15.Name = "label15";
            label15.Size = new Size(10, 15);
            label15.TabIndex = 58;
            label15.Text = ":";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(128, 193);
            label14.Name = "label14";
            label14.Size = new Size(10, 15);
            label14.TabIndex = 57;
            label14.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(128, 78);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 56;
            label13.Text = ":";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(128, 50);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 55;
            label12.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(128, 20);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 54;
            label11.Text = ":";
            // 
            // radioButtonPR
            // 
            radioButtonPR.AutoSize = true;
            radioButtonPR.Location = new Point(269, 219);
            radioButtonPR.Name = "radioButtonPR";
            radioButtonPR.Size = new Size(86, 19);
            radioButtonPR.TabIndex = 53;
            radioButtonPR.TabStop = true;
            radioButtonPR.Text = "Perempuan";
            radioButtonPR.UseVisualStyleBackColor = true;
            // 
            // radioButtonLK
            // 
            radioButtonLK.AutoSize = true;
            radioButtonLK.Location = new Point(156, 220);
            radioButtonLK.Name = "radioButtonLK";
            radioButtonLK.Size = new Size(69, 19);
            radioButtonLK.TabIndex = 52;
            radioButtonLK.TabStop = true;
            radioButtonLK.Text = "Laki-laki";
            radioButtonLK.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(142, 359);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 51;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(254, 359);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 50;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(22, 359);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 49;
            btnDaftar.Text = "DAFTAR";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click_1;
            // 
            // comboBoxTahun
            // 
            comboBoxTahun.FormattingEnabled = true;
            comboBoxTahun.Items.AddRange(new object[] { "", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029" });
            comboBoxTahun.Location = new Point(306, 279);
            comboBoxTahun.Name = "comboBoxTahun";
            comboBoxTahun.Size = new Size(57, 23);
            comboBoxTahun.TabIndex = 48;
            // 
            // comboBoxBulan
            // 
            comboBoxBulan.FormattingEnabled = true;
            comboBoxBulan.Items.AddRange(new object[] { "", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            comboBoxBulan.Location = new Point(203, 279);
            comboBoxBulan.Name = "comboBoxBulan";
            comboBoxBulan.Size = new Size(97, 23);
            comboBoxBulan.TabIndex = 47;
            // 
            // comboBoxTanggal
            // 
            comboBoxTanggal.FormattingEnabled = true;
            comboBoxTanggal.Items.AddRange(new object[] { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxTanggal.Location = new Point(156, 279);
            comboBoxTanggal.Name = "comboBoxTanggal";
            comboBoxTanggal.Size = new Size(40, 23);
            comboBoxTanggal.TabIndex = 46;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 45;
            // 
            // txtTempatLahir
            // 
            txtTempatLahir.Location = new Point(152, 244);
            txtTempatLahir.Name = "txtTempatLahir";
            txtTempatLahir.Size = new Size(213, 23);
            txtTempatLahir.TabIndex = 44;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(152, 190);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(213, 23);
            txtNoHP.TabIndex = 43;
            txtNoHP.KeyPress += txtnohp_KeyPress;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(152, 79);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(213, 100);
            txtAlamat.TabIndex = 42;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(152, 47);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(213, 23);
            txtNama.TabIndex = 41;
            // 
            // txtNomor
            // 
            txtNomor.Location = new Point(152, 17);
            txtNomor.Name = "txtNomor";
            txtNomor.Size = new Size(213, 23);
            txtNomor.TabIndex = 40;
            txtNomor.KeyPress += txtnodaftar_Keypress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 314);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 39;
            label9.Text = "Alamat E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 282);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 38;
            label8.Text = "Tanggal Lahir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 250);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 37;
            label7.Text = "Tempat Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 223);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 36;
            label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 195);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 35;
            label5.Text = "No HP/WA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 78);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 34;
            label4.Text = "Alamat Lengkap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 47);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 33;
            label3.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 20);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 32;
            label2.Text = "No. Pendaftaran";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(monthCalendar1);
            groupBox3.Controls.Add(txtTanggalDaftar);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(469, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 239);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tanggal";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(95, 25);
            label19.Name = "label19";
            label19.Size = new Size(10, 15);
            label19.TabIndex = 58;
            label19.Text = ":";
            // 
            // button5
            // 
            button5.Location = new Point(256, 61);
            button5.Name = "button5";
            button5.Size = new Size(58, 23);
            button5.TabIndex = 32;
            button5.Text = "Hide";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(256, 27);
            button4.Name = "button4";
            button4.Size = new Size(58, 23);
            button4.TabIndex = 31;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 51);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 59;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // txtTanggalDaftar
            // 
            txtTanggalDaftar.Location = new Point(111, 22);
            txtTanggalDaftar.Name = "txtTanggalDaftar";
            txtTanggalDaftar.ReadOnly = true;
            txtTanggalDaftar.Size = new Size(100, 23);
            txtTanggalDaftar.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 25);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 28;
            label10.Text = "Tanggal Daftar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblData;
        private GroupBox groupBox2;
        private RadioButton radioButtonPR;
        private RadioButton radioButtonLK;
        private Button btnReset;
        private Button btnClose;
        private Button btnDaftar;
        private ComboBox comboBoxTahun;
        private ComboBox comboBoxBulan;
        private ComboBox comboBoxTanggal;
        private TextBox txtEmail;
        private TextBox txtTempatLahir;
        private TextBox txtNoHP;
        private TextBox txtAlamat;
        private TextBox txtNama;
        private TextBox txtNomor;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private MonthCalendar monthCalendar1;
        private TextBox txtTanggalDaftar;
        private Label label10;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label19;
    }
}