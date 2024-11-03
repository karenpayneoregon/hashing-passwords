using System.ComponentModel;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace AdminApplication.Classes
{
    /// <summary>
    /// VS2019 there is no BindingNavigator, here you go :-)
    /// </summary>
    [DefaultProperty("BindingSource")]
    public sealed class CoreBindingNavigator : BindingNavigator
    {
        public CoreBindingNavigator()
        {
            AddStandardItems();

            Items.Add(new ToolStripSeparator());
            Items.Add(new ToolStripButton() { Name = "bindingNavigatorAboutItem", Text = "About"});
            Items.Add(new ToolStripButton() { Name = "bindingNavigatorCurrentItem", Text = "Current"});

            DeleteItemButton.Enabled = false;
        }

        /// <summary>
        /// Set Enable for add button
        /// </summary>
        public void AddButtonEnable(bool enable = false)
        {
            AddNewItem.Enabled = enable;
        }

        /// <summary>
        /// Set Enable for delete button
        /// </summary>
        public void RemoveButtonEnable(bool enable = false)
        {
            DeleteItem.Enabled = false;
        }
        
        /// <summary>
        /// Remove default actions for delete and add buttons
        /// </summary>
        public void RemoveDefaultHandlers()
        {
            AddNewItem = null;
            DeleteItem = null;
        }

        /// <summary>
        /// Hide about button
        /// </summary>
        public void HideAboutButton()
        {
            AboutItemButton.Visible = false;
        }

        /// <summary>
        /// Show about button
        /// </summary>
        public void ShowAboutButton()
        {
            AboutItemButton.Visible = true;
        }
        
        /// <summary>
        /// Provide access to the add new button
        /// </summary>
        public ToolStripItem AddItemButton => Items["bindingNavigatorAddNewItem"]!;
        /// <summary>
        /// Provides access to the delete current row
        /// </summary>
        public ToolStripItem DeleteItemButton => Items["bindingNavigatorDeleteItem"]!;
        public ToolStripItem AboutItemButton => Items["bindingNavigatorAboutItem"]!;
        public ToolStripItem CurrentItemButton => Items["bindingNavigatorCurrentItem"]!;
    }
}
