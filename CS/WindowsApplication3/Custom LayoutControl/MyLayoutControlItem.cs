using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout;

namespace DXSample {
    public class MyLayoutControlItem : LayoutControlItem
    {
        public MyLayoutControlItem() : base() { }
        public MyLayoutControlItem(LayoutControlGroup parent) : base(parent) { }
        public MyLayoutControlItem(LayoutControl layoutControl, Control control) : base(layoutControl, control) { }

        public override void HideToCustomization()
        {
            CanHideItemEventArgs args = new CanHideItemEventArgs(true);
            LayoutControl.RaiseCanHideItem(this, args);
            if (args.CanHideItem)
                base.HideToCustomization();
        }

        MyLayoutControl LayoutControl
        {
            get
            {
                return Owner as MyLayoutControl;
            }
        }
    }
}