<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633132/11.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3592)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CanHideItemEventArgs.cs](./CS/WindowsApplication3/Custom LayoutControl/CanHideItemEventArgs.cs) (VB: [CanHideItemEventArgs.vb](./VB/WindowsApplication3/Custom LayoutControl/CanHideItemEventArgs.vb))
* [MyLayoutControl.cs](./CS/WindowsApplication3/Custom LayoutControl/MyLayoutControl.cs) (VB: [MyLayoutControlImplementor.vb](./VB/WindowsApplication3/Custom LayoutControl/MyLayoutControlImplementor.vb))
* [MyLayoutControlGroup.cs](./CS/WindowsApplication3/Custom LayoutControl/MyLayoutControlGroup.cs) (VB: [MyLayoutControlGroup.vb](./VB/WindowsApplication3/Custom LayoutControl/MyLayoutControlGroup.vb))
* [MyLayoutControlImplementor.cs](./CS/WindowsApplication3/Custom LayoutControl/MyLayoutControlImplementor.cs) (VB: [MyLayoutControlImplementor.vb](./VB/WindowsApplication3/Custom LayoutControl/MyLayoutControlImplementor.vb))
* [MyLayoutControlItem.cs](./CS/WindowsApplication3/Custom LayoutControl/MyLayoutControlItem.cs) (VB: [MyLayoutControlItem.vb](./VB/WindowsApplication3/Custom LayoutControl/MyLayoutControlItem.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to show the Confirmation Dialog before hiding a layout item in the Customization Form


<p>This example illustrates how to add a custom <strong>LayoutControl.CanHideItem event</strong>. This event is raised when a layout item is going to be hidden in the Customization Form. In the LayoutControl.CanHideItem event handler, you can show the Confirmation Dialog and, based upon its result, set the <strong>CanHideItemEventArgs.CanHide</strong><strong>Item</strong><strong> property</strong> to false to prevent a processed item from being hidden.</p>

<br/>


