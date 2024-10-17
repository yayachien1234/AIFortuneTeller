namespace Form測試一
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "AI大神請告訴我答案吧")
            {
                button1.Text = "來，下面一位";
                label1.Text = "神諭時刻";
                label2.Location = new Point(220, 60);
                label2.Text = "姓名\n" + textBox1.Text;
                label3.Location = new Point(510, 60);
                label3.Text = "性別\n" + textBox2.Text;
                label4.Location = new Point(70, 120);
                label4.Text = "出生年月日\n" + textBox3.Text;
                label5.Location = new Point(370, 120);
                label5.Text = "今日日期\n" + textBox4.Text;
                label6.Location = new Point(640, 120);
                label6.Text = "貓派or狗派\n" + textBox5.Text;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = true;
                label13.Visible = true;


            }
            else if (button1.Text == "來，下面一位")
            {
                button1.Text = "AI大神請告訴我答案吧";
                label1.Text = "資料輸入";
                label2.Location = new Point(120, 80);
                label2.Text = "姓名";
                label3.Location = new Point(120, 140);
                label3.Text = "性別";
                label4.Location = new Point(120, 200);
                label4.Text = "出生年月日";
                label5.Location = new Point(120, 260);
                label5.Text = "今日日期";
                label6.Location = new Point(120, 320);
                label6.Text = "貓派or狗派";



                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))// 檢查TextBox1中是否有文字
            {
                label7.Text = "";
            }
            else
            {
                // 如果沒有文字，將Label1的Text設置為其他內容（根據需要）
                label7.Text = "此欄未填寫";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox2.Text))// 檢查TextBox1中是否有文字
            {
                if (textBox2.Text == "男" || textBox2.Text == "女")
                {

                    label8.Text = "";// 如果是，清空Label8的Text
                }
                else
                {

                    label8.Text = "輸入應為男or女";// 如果不是，設置Label7的Text為提示信息
                }
                // 如果有文字，將Label1的Text設置為空字符串

            }
            else
            {
                // 如果沒有文字，將Label1的Text設置為其他內容（根據需要）
                label8.Text = "此欄未填寫";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))// 檢查TextBox1中是否有文字
            {
                label9.Text = "";
            }
            else
            {
                // 如果沒有文字，將Label1的Text設置為其他內容（根據需要）
                label9.Text = "此欄未填寫";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))// 檢查TextBox1中是否有文字
            {
                label10.Text = "";
            }
            else
            {
                // 如果沒有文字，將Label1的Text設置為其他內容（根據需要）
                label10.Text = "此欄未填寫";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox5.Text))// 檢查TextBox1中是否有文字
            {
                if (textBox5.Text == "貓" || textBox5.Text == "狗")
                {

                    label11.Text = "";// 如果是，清空Label11的Text
                }
                else
                {

                    label11.Text = "輸入應為貓or狗";// 如果不是，設置Label11的Text為提示信息
                }
                // 如果有文字，將Label1的Text設置為空字符串

            }
            else
            {
                // 如果沒有文字，將Label11的Text設置為其他內容（根據需要）
                label11.Text = "此欄未填寫";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}