# How to show the Confirmation Dialog before hiding a layout item in the Customization Form


<p>This example illustrates how to add a custom <strong>LayoutControl.CanHideItem event</strong>. This event is raised when a layout item is going to be hidden in the Customization Form. In the LayoutControl.CanHideItem event handler, you can show the Confirmation Dialog and, based upon its result, set the <strong>CanHideItemEventArgs.CanHide</strong><strong>Item</strong><strong> property</strong> to false to prevent a processed item from being hidden.</p>

<br/>


