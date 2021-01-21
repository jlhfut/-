using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    class Publisher
    {
        //编写一个事件的四个步骤

        //1.在事件发行者中定义一个事件
        //2.在事件发行者中触发事件
        //3.在事件订阅这种定义事件处理程序
        //4.向事件发行者订阅一个事件


        //声明事件所需的委托
        public delegate void Courier(string magazineName);

        //声明事件
        public event Courier OnPubComputer;  //
        public event Courier OnPubLife;

        //定义事件触发的方法

        public void issueComputer()//事件触发方法
        {
            if (OnPubComputer != null)
            {
                //MessageBox.show("发行《电脑》杂志");
                OnPubComputer("《电脑杂志》");//方法
            }
        }

        public void issueLife()
        {
            if (OnPubLife != null)
            {
                OnPubLife("《生活》杂志");
            }
        }
    }
}
