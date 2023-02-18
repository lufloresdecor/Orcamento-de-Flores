using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orçamento_Flores.Paginas
{
    public partial class TabConsultarFlores : UserControl
    {
        public TabConsultarFlores()
        {
            InitializeComponent();
        }

        private void btnProcurarFlores_Click(object sender, EventArgs e)
        {
            txtFlor.Text = "Lucas";
        }
    }
}
