using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;

namespace DXSample {
    public delegate void CanHideItemEventHandler(object sender, CanHideItemEventArgs e);

    public class CanHideItemEventArgs : EventArgs
    {
        bool canHideItem = true;

        public CanHideItemEventArgs(bool canHideItem)
            : base()
        {
            this.canHideItem = canHideItem;
        }

        public bool CanHideItem
        {
            get { return canHideItem; }
            set
            {
                if (canHideItem != value)
                    canHideItem = value;
            }
        }
    }
}