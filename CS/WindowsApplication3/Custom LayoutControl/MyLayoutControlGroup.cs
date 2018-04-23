using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout;

namespace DXSample {
    public class MyLayoutControlGroup : LayoutControlGroup
    {
        public MyLayoutControlGroup() : base() { }
        public MyLayoutControlGroup(LayoutGroup lg) : base(lg) { }

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