using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzy.WebWx.Sdk;

namespace Xzy.WebWx.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WxManager wx = new WxManager();
        private void button1_Click(object sender, EventArgs e)
        {      
            wx.getQrCode += Wx_getQrCode;
            wx.getWxModel += Wx_getWxModel;
            wx.getReceiveMsg += Wx_getReceiveMsg;
            wx.Start();
        }


        /// <summary>
        /// 接收微信文字消息
        /// </summary>
        /// <param name="model"></param>
        private void Wx_getReceiveMsg(string model)
        {
            //包含消息内容 时间戳 发送人 消息ID等内容。
        }

        /// <summary>
        /// 获取微信登陆信息
        /// </summary>
        /// <param name="model"></param>
        private void Wx_getWxModel(string model)
        {
            //接收到登陆后的好友信息 其中UserName 是微信返回的TokenID 每次登陆会变
        }

        /// <summary>
        /// 获取登陆二维码
        /// </summary>
        /// <param name="code"></param>
        private void Wx_getQrCode(Image image)
        {
            //微信登陆二维码图片
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wx.SendMessage(textBox1.Text,textBox2.Text);
        }
    }
}
