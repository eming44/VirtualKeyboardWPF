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

namespace VirtualKeyboard
{
    public class VButton : Button
    {
        static VButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VButton), new FrameworkPropertyMetadata(typeof(VButton)));
            HorizontalContentAlignmentProperty.OverrideMetadata(typeof(VButton), new FrameworkPropertyMetadata(HorizontalAlignment.Center));
            VerticalContentAlignmentProperty.OverrideMetadata(typeof(VButton), new FrameworkPropertyMetadata(VerticalAlignment.Center));
            //BackgroundProperty.OverrideMetadata(typeof(VButton), new FrameworkPropertyMetadata(Brushes.Transparent));
            //ContentProperty.OverrideMetadata(typeof(VButton), new FrameworkPropertyMetadata())


            
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(VButton), new FrameworkPropertyMetadata(new CornerRadius(0)));

        //public static readonly DependencyProperty PrimaryValueProperty =
        //    DependencyProperty.Register("PrimaryValue", typeof(object), typeof(VButton), new FrameworkPropertyMetadata(null));
        //public static readonly DependencyProperty PrimaryValueTemplateProperty =
        //    DependencyProperty.Register("PrimaryValueTemplate", typeof(DataTemplate), typeof(VButton), new FrameworkPropertyMetadata(null));
        //public static readonly DependencyProperty PrimaryValueFontSizeProperty =
        //    DependencyProperty.Register("PrimaryValueFontSize", typeof(double), typeof(VButton), new FrameworkPropertyMetadata((double)10));
        //public static readonly DependencyProperty PrimaryValueForegroundProperty =
        //    DependencyProperty.Register("PrimaryValueForeground", typeof(Brush), typeof(VButton), new FrameworkPropertyMetadata(Brushes.Black));
        //public static readonly DependencyProperty PrimaryValueHorizontalAlignmentProperty =
        //    DependencyProperty.Register("PrimaryValueHorizontalAlignment", typeof(HorizontalAlignment), typeof(VButton), new FrameworkPropertyMetadata(HorizontalAlignment.Center));
        //public static readonly DependencyProperty PrimaryValueVerticalAlignmentProperty =
        //    DependencyProperty.Register("PrimaryValueVerticalAlignment", typeof(VerticalAlignment), typeof(VButton), new FrameworkPropertyMetadata(VerticalAlignment.Center));
        public static readonly DependencyProperty PrimaryValueMarginProperty =
            DependencyProperty.Register("PrimaryValueMargin", typeof(Thickness), typeof(VButton), new PropertyMetadata(new Thickness(0)));




        public static readonly DependencyProperty SecondaryValueProperty =
            DependencyProperty.Register("SecondaryValue", typeof(object), typeof(VButton), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty SecondaryValueTemplateProperty =
            DependencyProperty.Register("SecondaryValueTemplate", typeof(DataTemplate), typeof(VButton), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty SecondaryValueFontSizeProperty =
            DependencyProperty.Register("SecondaryValueFontSize", typeof(double), typeof(VButton), new FrameworkPropertyMetadata((double)10));
        public static readonly DependencyProperty SecondaryValueForegroundProperty =
            DependencyProperty.Register("SecondaryValueForeground", typeof(Brush), typeof(VButton), new FrameworkPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty SecondaryValueHorizontalAlignmentProperty =
            DependencyProperty.Register("SecondaryValueHorizontalAlignment", typeof(HorizontalAlignment), typeof(VButton), new FrameworkPropertyMetadata(HorizontalAlignment.Center));
        public static readonly DependencyProperty SecondaryValueVerticalAlignmentProperty =
            DependencyProperty.Register("SecondaryValueVerticalAlignment", typeof(VerticalAlignment), typeof(VButton), new FrameworkPropertyMetadata(VerticalAlignment.Center));
        public static readonly DependencyProperty SecondaryValueMarginProperty =
            DependencyProperty.Register("SecondaryValueMargin", typeof(Thickness), typeof(VButton), new FrameworkPropertyMetadata(new Thickness(0)));
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), typeof(VButton), new FrameworkPropertyMetadata(/*(Brushes)BackgroundProperty.DefaultMetadata.DefaultValue*/Brushes.Transparent));
        public static new readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(VButton), new FrameworkPropertyMetadata(Brushes.Transparent));


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public Thickness PrimaryValueMargin
        {
            get { return (Thickness)GetValue(PrimaryValueMarginProperty); }
            set { SetValue(PrimaryValueMarginProperty, value); }
        }

        public object SecondaryValue
        {
            get { return (object)GetValue(SecondaryValueProperty); }
            set { SetValue(SecondaryValueProperty, value); }
        }

        public DataTemplate SecondaryValueTemplate
        {
            get { return (DataTemplate)GetValue(SecondaryValueTemplateProperty); }
            set { SetValue(SecondaryValueTemplateProperty, value); }
        }

        public double SecondaryValueFontSize
        {
            get { return (double)GetValue(SecondaryValueFontSizeProperty); }
            set { SetValue(SecondaryValueFontSizeProperty, value); }
        }

        public Brush SecondaryValueForeground
        {
            get { return (Brush)GetValue(SecondaryValueForegroundProperty); }
            set { SetValue(SecondaryValueForegroundProperty, value); }
        }

        public HorizontalAlignment SecondaryValueHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(SecondaryValueHorizontalAlignmentProperty); }
            set { SetValue(SecondaryValueHorizontalAlignmentProperty, value); }
        }

        public VerticalAlignment SecondaryValueVerticalAlignment
        {
            get { return (VerticalAlignment)GetValue(SecondaryValueVerticalAlignmentProperty); }
            set { SetValue(SecondaryValueVerticalAlignmentProperty, value); }
        }

        public Thickness SecondaryValueMargin
        {
            get { return (Thickness)GetValue(SecondaryValueMarginProperty); }
            set { SetValue(SecondaryValueMarginProperty, value); }
        }

        public Brush BackgroundPressed
        {
            get { return (Brush)GetValue(BackgroundPressedProperty); }
            set { SetValue(BackgroundPressedProperty, value); }
        }

        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

















    }
}
