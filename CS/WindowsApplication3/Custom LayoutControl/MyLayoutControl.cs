using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout;

namespace DXSample {
    public class MyLayoutControl : LayoutControl
    {
        public MyLayoutControl() : base() { }
        public MyLayoutControl(bool createFast) : base(createFast) { }
        public MyLayoutControl(bool fAllowUseSplitters, bool fAllowUseTabbedGroup) : base(fAllowUseSplitters, fAllowUseTabbedGroup) { }

        public event CanHideItemEventHandler CanHideItem;

        internal void RaiseCanHideItem(BaseLayoutItem sender, CanHideItemEventArgs e)
        {
            if (CanHideItem != null)
                CanHideItem(sender, e);
        }

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }
}