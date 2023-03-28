using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kgcalculation
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數
        public MainWindow()
        {
            InitializeComponent();
        }

        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtMG.Text = string.Format("{0:0.##########}", _value * 1000);
            if (_kind != 1)
                txtG.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 2)
                txtKG.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 3)
                txtMT.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 4)
                txtOZ.Text = string.Format("{0:0.##########}", _value * 0.035274);
            if (_kind != 5)
                txtLB.Text = string.Format("{0:0.##########}", _value * 0.002205);
        }
        private void txtMG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMG.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(0, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMG.Text = "";
            }
        }

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtG.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(1, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtG.Text = "";
            }
        }

        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKG.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(2, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKG.Text = "";
            }
        }

        private void txtMT_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMT.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(3, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMT.Text = "";
            }
        }

        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOZ.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(4, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOZ.Text = "";
            }
        }

        private void txtLB_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtLB.Text;
            if (double.TryParse(strInput, out douOutput) == true)
                caculateAnswer(5, douOutput);
            else
            {
                txtInfo.Text = "請輸入數字";
                txtLB.Text = "";
            }
        }

        
        private void btnAllClea_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtMT.Text = "";
            txtOZ.Text = "";
            txtLB.Text = "";
        }       
    }
}
