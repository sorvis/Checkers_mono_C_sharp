using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Checkers.UI
{
    /// <summary>
    /// Interaction logic for BoardSquare.xaml
    /// </summary>
    public partial class BoardSquare : UserControl
    {
        public BoardSquare()
        {
            InitializeComponent();
            Location = new BoardLocation(Int32.MinValue, Int32.MinValue);

            XPositionProperty =
             DependencyProperty.Register("XPosition", typeof(int),
             typeof(BoardSquare), new PropertyMetadata(
                 new PropertyChangedCallback((value, args) => Location.X = (int)args.NewValue)));
        }

        public readonly DependencyProperty XPositionProperty;

        public int XPosition
        {
            get
            {
                return (int)GetValue(XPositionProperty);
            }
            set
            {
                SetValue(XPositionProperty, value);
            }
        }

        public BoardLocation Location { get; set; }
    }
}
