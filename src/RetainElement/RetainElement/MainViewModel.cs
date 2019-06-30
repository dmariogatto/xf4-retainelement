using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RetainElement
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Items = new ObservableRangeCollection<Item>();
            Items.AddRange(GetItems());
        }

        public ObservableRangeCollection<Item> Items { get; set; }

        private IList<Item> GetItems()
        {
            var items = new List<Item>();

            for (var i = 0; i < 50; i++)
            {
                items.Add(new Item()
                {
                    Id = i,
                    Header = $"Header {i}",
                    Body = i % 2 == 0 ? $"This item {i} has a body!" : string.Empty,
                    Footer = $"Footer {i}",
                });
            }

            return items;
        }
    }
}
