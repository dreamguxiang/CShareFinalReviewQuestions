namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //当用户点击button控件时，lable控件显示“欢迎您，班级姓名”
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "欢迎您，xx班xxx";
            

        }
    }
}