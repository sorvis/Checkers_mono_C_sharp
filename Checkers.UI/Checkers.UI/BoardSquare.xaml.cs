using Checkers.UI.Converters;
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
        static BoardSquare()
        {
            XPositionProperty =
                 DependencyProperty.Register("XPosition", typeof(int),
                 typeof(BoardSquare), new PropertyMetadata(
                     new PropertyChangedCallback((objectInstance, args) =>
                     {
                         BoardSquare boardSquare = (BoardSquare)objectInstance;
                         boardSquare.Location.X = (int)args.NewValue;
                         boardSquare.resetBackgroundColorToPosition();
                     })));
            YPositionProperty =
                DependencyProperty.Register("YPosition", typeof(int),
                typeof(BoardSquare), new PropertyMetadata(
                    new PropertyChangedCallback((objectInstance, args) =>
                    {
                        BoardSquare boardSquare = (BoardSquare)objectInstance;
                        boardSquare.Location.Y = (int)args.NewValue;
                        boardSquare.resetBackgroundColorToPosition();
                    })));
        }

        public BoardSquare()
        {
            InitializeComponent();
            Location = new BoardLocation(Int32.MinValue, Int32.MinValue);
        }

        private void resetBackgroundColorToPosition()
        {
            this.Background = (Brush)(new ColorEnumToBrushesConverter()).Convert(Location.GetSquareColor(), typeof(BlackWhiteColor), null, null);
        }

        public static readonly DependencyProperty XPositionProperty;
        public static readonly DependencyProperty YPositionProperty;

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

        public int YPosition 
        { 
            get
            {
                return (int)GetValue(YPositionProperty);
            }
            set
            {
                SetValue(YPositionProperty, value);
            }
        }

        public BoardLocation Location { get; set; }
    }
}
