using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Licens : Form
    {
        public Licens()
        {
            InitializeComponent();
        }

        //обрабатываем нажатие на кнопку Exit 
        private void btnExit_Click(object sender, EventArgs e)
        {
            //скрываем действующую форму
            this.Hide();
        }
    }
}
