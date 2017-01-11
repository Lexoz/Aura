using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aura
{
    public partial class Form1 : Form
    {
        Form2 forma = new Form2();
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            Opacity = .5;
            BackColor = Color.Black;
            int sRW = Screen.PrimaryScreen.Bounds.Width;
            int sW = Screen.PrimaryScreen.Bounds.Width/12;
            int sH = Screen.PrimaryScreen.Bounds.Height;
            this.Width = sW;
            this.Height = sH;
            this.Location = new Point(sRW - sW, 0);
            this.StartPosition = FormStartPosition.Manual;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forma.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            forma.TopMost = true;
            forma.TopMost = false;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        //Parameter override from: 
        // https://social.msdn.microsoft.com/forums/windows/en-us/0eefb6f4-3619-4f7a-b144-48df80e2c603/how-to-hide-form-from-alttab-dialog
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on WS_EX_TOOLWINDOW style bit
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000080;
                return cp;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            forma.TopMost = true;
            forma.TopMost = false;
        }
    }
}
