using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LazyLoadListView
{
    public class ItemIDDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate FromTemplate { get; set; }
        public DataTemplate ToTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            //throw new NotImplementedException();

            return (((MyData)item).Id % 2).Equals(0) ? FromTemplate : ToTemplate;
        }
    }
}
