using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.ViewModels
{
    //a variation on Line model that is bindable to a single item in Lines list
    //with a boolean parameter to indecate wheather it's selected or not.
    public class SelectableLine : ViewModelBase
    {
        public SelectableLine(Line line)
        {
            IsSelected = false;
            _item = line;
        }

        private Line _item;
        private bool _isSelected;

        public bool IsSelected { get => _isSelected; set { SetProperty(ref _isSelected, value); } }
        public Line Item { get => _item; set => SetProperty(ref _item, value); }
    }

}
