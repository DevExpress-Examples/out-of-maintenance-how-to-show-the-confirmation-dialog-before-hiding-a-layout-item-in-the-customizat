using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
      
        private void OnCanHideItem(object sender, CanHideItemEventArgs e)
        {
            BaseLayoutItem item = sender as BaseLayoutItem;
            if (XtraMessageBox.Show(string.Format("Do you wish to hide this item ({0})? ", item.Name), "HideItemDialog", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.CanHideItem = false;
        }
    }
}
