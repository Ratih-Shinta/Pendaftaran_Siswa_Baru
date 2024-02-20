using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            lblData.Visible = true;
            if (radioButtonLK.Checked)
            {
                lblData.Text = "No. Pendaftaran : " + txtNomor.Text +
                "\nNama Lengkap : " + txtNama.Text +
                "\nAlamat Lengkap : " + txtAlamat.Text +
                "\nNo. Hp/WA : " + txtNoHP.Text +
                "\nJenis Kelamin : " + radioButtonLK.Text +
                "\nTempat Lahir : " + txtTempatLahir.Text +
                "\nTanggal Lahir : " + comboBoxTanggal.Text + comboBoxBulan.Text + comboBoxTahun.Text +
                "\nEmail : " + txtEmail.Text +
                "\nTanggal daftar : " + txtTanggalDaftar.Text;
            }
            else if (radioButtonPR.Checked)
            {
                lblData.Text = "No. Pendaftaran : " + txtNomor.Text +
                "\nNama Lengkap : " + txtNama.Text +
                "\nAlamat Lengkap : " + txtAlamat.Text +
                "\nNo. Hp/WA : " + txtNoHP.Text +
                "\nJenis Kelamin : " + radioButtonPR.Text +
                "\nTempat Lahir : " + txtTempatLahir.Text +
                "\nTanggal Lahir : " + comboBoxTanggal.Text + comboBoxBulan.Text + comboBoxTahun.Text +
                "\nEmail : " + txtEmail.Text +
                "\nTanggal daftar : " + txtTanggalDaftar.Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNomor.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtNoHP.Text = "";
            txtTempatLahir.Text = "";
            txtTanggalDaftar.Text = "";
            radioButtonLK.Checked = false;
            radioButtonPR.Checked = false;

            comboBoxTanggal.SelectedIndex = 0;
            comboBoxBulan.SelectedIndex = 0;
            comboBoxTahun.SelectedIndex = 0;

            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Height = 255;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Height = 53;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        public bool validate(char c)
        {
            int asci = Convert.ToInt32(c);
            if (asci >= 48 && asci <= 57 || asci == 13 || asci == 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtnohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validate(e.KeyChar);
        }

        private void txtnodaftar_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validate(e.KeyChar);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string formattedDate = selectedDate.ToString("dd-MM-yyyy");
            txtTanggalDaftar.Text = formattedDate;
        }

        private void btnDaftar_Click_1(object sender, EventArgs e)
        {
            lblData.Visible = true;

            string genderText =
                radioButtonLK.Checked && radioButtonPR.Checked ? radioButtonLK.Text + " dan " + radioButtonPR.Text :
                radioButtonLK.Checked ? radioButtonLK.Text :
                radioButtonPR.Checked ? radioButtonPR.Text : "";

            lblData.Text =
                "No.Pendaftaran : " + txtNomor.Text +
                "\nNama Lengkap : " + txtNama.Text +
                "\nAlamat Lengkap : " + txtAlamat.Text +
                "\nNo.HP/WA : " + txtNoHP.Text +
                "\nJenis Kelamin : " + genderText +
                "\nTempat Lahir : " + txtTempatLahir.Text +
                "\nTanggal Lahir : " + comboBoxTanggal.Text + comboBoxBulan.Text + comboBoxTahun.Text +
                "\nAlamat Email : " + txtEmail.Text +
                "\nTanggal Daftar : " + txtTanggalDaftar.Text;
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            txtTanggalDaftar.Text = e.Start.ToShortDateString();
        }
    }
}