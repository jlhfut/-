using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    class Subscriber  //用户订阅者
    {
        private string userName;

        public Subscriber(string name)//构造函数
        {
            this.userName = name;
        }

        public void ReceiveManazine(string magazineName)
        {
            MessageBox.Show(userName + "已经收到" + magazineName);
        }
    }
}
