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
using OOPFinalHastane.WFA.BaseForms;

namespace OOPFinalHastane.WFA.HemsireForms
{
    public partial class FormHemsireListeleIntermediate : ListeleBaseForm<Hemsire>
    {
        public FormHemsireListeleIntermediate()
        {
            InitializeComponent();
            this.BaseClass = new Hemsire();
        }
    }
}
