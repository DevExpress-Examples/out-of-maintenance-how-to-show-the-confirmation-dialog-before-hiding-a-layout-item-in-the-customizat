using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout;

namespace DXSample {
    public class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner layout) : base(layout) { }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            return new MyLayoutControlItem((LayoutControlGroup)parent);
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            return new MyLayoutControlGroup(parent);
        }
    }

}