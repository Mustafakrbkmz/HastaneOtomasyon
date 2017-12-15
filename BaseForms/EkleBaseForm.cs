using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPFinalHastane.Entity;

namespace OOPFinalHastane.WFA.BaseForms
{
    public partial class EkleBaseForm : BaseForm
    {
        public EkleBaseForm()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            MyTool.FormTemizle(this.Controls);
        }
    }
}
