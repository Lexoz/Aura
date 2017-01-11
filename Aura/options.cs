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
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            InitializeComponent();
            int sW = Screen.PrimaryScreen.Bounds.Width;
            int sH = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(sW / 4, sH/4);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void options_Load(object sender, EventArgs e)
        {

        }

        private void options_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
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
    }
}
