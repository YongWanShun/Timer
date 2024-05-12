using System;
using System.Windows.Forms;
namespace timer
{
    public partial class Form1 : Form
    {
        private int count = 100;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
        }
        //按下按鈕的時候啓動計時器，時間間隔是1000毫秒
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;

        }
        //每秒減少count的值并且顯示在label1上
        private void Timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label1.Text = count.ToString();
            if (count == 0)//如果count變數達到0
            {
                timer1.Stop();//計時器會停止
                MessageBox.Show("時間到了！");//彈出訊息框
                //重置狀態
                label1.Text = "";
                count = 100;
            }
        }
    }
}
