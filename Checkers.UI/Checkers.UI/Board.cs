using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Checkers.UI
{
    class Board : Grid
    {
        public int Columns 
        {
            get { return ColumnDefinitions.Count; }
            set {setUpPanels(value, Rows); } 
        }

        public int Rows
        {
            get { return RowDefinitions.Count; }
            set { setUpPanels(Columns, value);}
        }

        private IValueConverter _converter;
        public IValueConverter Converter
        {
            get { return _converter; }
            set
            {
                _converter = value;
                setUpPanels(Columns, Rows);
            }
        }

        private void setUpPanels(int colums, int rows)
        {
            if (colums > 0 && rows > 0)
            {
                
            }
        }
    }
}
