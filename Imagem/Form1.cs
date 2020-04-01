using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Imagem
{
    public partial class Form1 : Form
    {
        Point local;

        public Form1()
        {
            InitializeComponent();
        }

        private void MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                local=e.Location;
            }
        }

        private void MouseMoveEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                panel1.Left=e.X+panel1.Left-local.X;
                panel1.Top=e.Y+panel1.Top-local.Y;
            }
        }
    }
}
