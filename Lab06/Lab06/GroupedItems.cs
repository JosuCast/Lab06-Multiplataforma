using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab06
{
    public class GroupedItems : ObservableCollection<Contacto>
    {
        public string Category { get; private set; }

        public GroupedItems(string category, IEnumerable<Contacto> items)
        {
            Category = category;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
