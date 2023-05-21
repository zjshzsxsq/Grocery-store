using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_calculate
{
    public partial class Form4 : Form
    {
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        public Form4()
        {
            InitializeComponent(); 
            x = this.Width;
            y = this.Height;
            //setTag(this);
        }
        /*private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }*/
        private void Form4_Resize(object sender, EventArgs e)
        {
            /*float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);*/
            x = this.Width;
            y = this.Height;
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer2.Location = new Point(Convert.ToInt32(x) / 2 - 5, 0);
            axWindowsMediaPlayer3.Location = new Point(0, Convert.ToInt32(y) / 2 - 10);
            axWindowsMediaPlayer4.Location = new Point(Convert.ToInt32(x) / 2 - 5, Convert.ToInt32(y) / 2 - 10);
            axWindowsMediaPlayer1.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            axWindowsMediaPlayer2.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            axWindowsMediaPlayer3.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            axWindowsMediaPlayer4.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
       
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer2.Location = new Point(Convert.ToInt32(x) / 2 - 5, 0);
            axWindowsMediaPlayer3.Location = new Point(0, Convert.ToInt32(y) / 2 - 10);
            axWindowsMediaPlayer4.Location = new Point(Convert.ToInt32(x) / 2 - 5, Convert.ToInt32(y) / 2 - 10);
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 nf = new Form5();
            nf.Show();
            this.Hide();
        }
        public void VedioPlay(string filePath1,string filePath2,string filePath3,string filePath4)
        {
            axWindowsMediaPlayer1.URL = filePath1;
            axWindowsMediaPlayer2.URL = filePath2;
            axWindowsMediaPlayer3.URL = filePath3;
            axWindowsMediaPlayer4.URL = filePath4;
        }
 
    }
}
