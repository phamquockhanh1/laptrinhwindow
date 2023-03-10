using System.Globalization;

namespace WinFormsApp2
{
    public partial class formsoluoc : Form
    {
        public formsoluoc()
        {
            InitializeComponent();
        }

        private void tieude_Click(object sender, EventArgs e)
        {
            tieude.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btxoaanh.Image.Dispose(); // Giải phóng tài nguyên hình ảnh của nút
            btxoaanh.Image = null; // Gán giá trị null cho thuộc tính Image của nút
        }



        private void gbsoluoc_Enter(object sender, EventArgs e)
        {



        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            string hoten = tbhoten.Text;
            string diachi = tbdiachi.Text;
            string sdt = tbsdt.Text;
            string ghichu = tbghichu.Text;
            DateTime ngay = dtnthangnsinh.Value;

            gbsoluoc.Text = "Họ và Tên: " + hoten + "\nĐịa chỉ: " + "\nNgày/Tháng/Năm/Sinh: " + ngay.ToString("dd/MM/yyyy") + diachi + "\nSố Điện Thoại: " + sdt + "\n *Note: " + ghichu;






        }

        private void lbtuoi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btthemanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                string imagepath = openfiledialog1.FileName;
                pbanh.Image = Image.FromFile(imagepath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtnthangnsinh_ValueChanged(object sender, EventArgs e)

        {
            DateTimePicker datetimepicker1 = sender as DateTimePicker;
            if (datetimepicker1 != null)
            {
                CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                datetimepicker1.Format = DateTimePickerFormat.Short;
                datetimepicker1.CustomFormat = culture.DateTimeFormat.ShortDatePattern;
                datetimepicker1.Value = DateTime.Now;
            }

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formsoluoc_Load(object sender, EventArgs e)
        {

        }
    }
}