using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class Form1 : Form
    {

        //编写一个事件的四个步骤

        //1.在事件发行者中定义一个事件
        //2.在事件发行者中触发事件
        //3.在事件订阅这种定义事件处理程序
        //4.向事件发行者订阅一个事件

        Publisher SanDonPublisher = new Publisher();
        Subscriber zhangSan = new Subscriber("张三");
        Subscriber liSi = new Subscriber("李四");

        public Form1()
        {
            InitializeComponent();

            
        }

        /// <summary>
        /// 发行电脑刊物
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIssueComputer_Click(object sender, EventArgs e)
        {
            SanDonPublisher.issueComputer();
        }

        private void btnIssueLife_Click(object sender, EventArgs e)
        {
            SanDonPublisher.issueLife();
        }

        private void chkComputerZs_CheckedChanged(object sender, EventArgs e)
        {
            if (true == chkComputerZs.Checked)
            {
                SanDonPublisher.OnPubComputer += new Publisher.Courier(zhangSan.ReceiveManazine);
            }
            else {
                SanDonPublisher.OnPubComputer -= new Publisher.Courier(zhangSan.ReceiveManazine); 
                }
        }

        private void SanDonPublisher_OnPubComputer(string magazineName)
        {
            MessageBox.Show("发行《电脑》杂志");        }

        private void chkLifeZs_CheckedChanged(object sender, EventArgs e)
        {
            if (true == chkLifeZs.Checked)
            {
                SanDonPublisher.OnPubLife += new Publisher.Courier(zhangSan.ReceiveManazine);
            }
            else
            {
                SanDonPublisher.OnPubLife -= new Publisher.Courier(zhangSan.ReceiveManazine);
            }
        }

        private void SanDonPublisher_OnPubLife(string magazineName)
        {
            MessageBox.Show("发行《生活》杂志");
        }

        private void chkComputerLs_CheckedChanged(object sender, EventArgs e)
        {
            if (true == chkComputerLs.Checked)
            {
                SanDonPublisher.OnPubComputer += new Publisher.Courier(liSi.ReceiveManazine);
            }
            else
            {
                SanDonPublisher.OnPubLife -= new Publisher.Courier(liSi.ReceiveManazine);
            }
        }

        private void SanDonPublisher_OnPubLife1(string magazineName)
        {
            throw new NotImplementedException();
        }

        private void chkLifeLs_CheckedChanged(object sender, EventArgs e)
        {
            if (true == chkLifeLs.Checked)
            {
                SanDonPublisher.OnPubLife += new Publisher.Courier(liSi.ReceiveManazine);
            }
            else
            {
                SanDonPublisher.OnPubLife -= new Publisher.Courier(liSi.ReceiveManazine);
            }
        }

        private void SanDonPublisher_OnPubLife2(string magazineName)
        {
            throw new NotImplementedException();
        }
    }
}
