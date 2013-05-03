using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuvariStoreManagement
{
    public partial class güncellesorgu : Form
    {
        public güncellesorgu()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MagazaUpdate s = new MagazaUpdate();
            s.Show();
        }
    }
}
