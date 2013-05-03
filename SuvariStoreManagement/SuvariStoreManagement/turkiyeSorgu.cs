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
    public partial class turkiyeSorgu : Form
    {
        public turkiyeSorgu()
        {
            InitializeComponent();
        }

        private void turkiyeSorgu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suvariData.MagazaTanim' table. You can move, or remove it, as needed.
            this.magazaTanimTableAdapter.Fill(this.suvariData.MagazaTanim);

        }
    }
}
