using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public class SwappingToolStripMenuItem : ToolStripMenuItem
    {
        private ToolStripMenuItem? m_previousItem;

        public SwappingToolStripMenuItem()
        {
            DropDownItemClicked += onDropDownItemClicked;
        }

        private void onDropDownItemClicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is not ToolStripMenuItem clickedItem)
                return;

            // Step 1: Re-add previous item if exists
            if (m_previousItem != null)
            {
                DropDownItems.Add(m_previousItem);
            }

            // Step 2: Store current parent info as a new menu item
            m_previousItem = new ToolStripMenuItem(Text, Image);

            // Step 3: Remove clicked item and replace parent label
            DropDownItems.Remove(clickedItem);
            Text = clickedItem.Text;
            Image = clickedItem.Image;
        }
    }
}
