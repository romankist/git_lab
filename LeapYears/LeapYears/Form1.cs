using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeapYears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //берем значение из текстбокса и конвертируем его в число:
            int year = Convert.ToInt32( textBox1.Text );
            //вызываем функцию для проверки:
	        bool result = DateFunctions.IsLeapYear( year );
	        //показываем сообщение пользователю:
            label_Result.Text =( result ? "Високосный" : "Не високосный");
	        //MessageBox.Show( result ? "Високосный" : "Не високосный"); 

        }
    }
}
