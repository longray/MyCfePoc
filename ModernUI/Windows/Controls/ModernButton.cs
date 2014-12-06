namespace ModernUI.Windows.Controls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// 图标按钮
    /// </summary>
    public class ModernButton
        : Button
    {
        /// <summary>
        /// 椭圆直径
        /// </summary>
        public static readonly DependencyProperty EllipseDiameterProperty = DependencyProperty.Register("EllipseDiameter", typeof(double), typeof(ModernButton), new PropertyMetadata(22D));
        /// <summary>
        /// 椭圆笔触粗细
        /// </summary>
        public static readonly DependencyProperty EllipseStrokeThicknessProperty = DependencyProperty.Register("EllipseStrokeThickness", typeof(double), typeof(ModernButton), new PropertyMetadata(1D));
        /// <summary>
        /// 图标数据
        /// </summary>
        public static readonly DependencyProperty IconDataProperty = DependencyProperty.Register("IconData", typeof(Geometry), typeof(ModernButton));
        /// <summary>
        /// 图标高度
        /// </summary>
        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight", typeof(double), typeof(ModernButton), new PropertyMetadata(12D));
        /// <summary>
        /// 图标宽度
        /// </summary>
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth", typeof(double), typeof(ModernButton), new PropertyMetadata(12D));

        /// <summary>
        /// 初始化 <see cref="ModernButton"/> 类.
        /// </summary>
        public ModernButton()
        {
            this.DefaultStyleKey = typeof(ModernButton);
        }

        /// <summary>
        /// get/set 椭圆直径
        /// </summary>
        public double EllipseDiameter
        {
            get { return (double)this.GetValue(EllipseDiameterProperty); }
            set { this.SetValue(EllipseDiameterProperty, value); }
        }

        /// <summary>
        /// get/set 椭圆笔触粗细
        /// </summary>
        public double EllipseStrokeThickness
        {
            get { return (double)this.GetValue(EllipseStrokeThicknessProperty); }
            set { this.SetValue(EllipseStrokeThicknessProperty, value); }
        }

        /// <summary>
        /// Gets or sets the icon path data.
        /// </summary>
        /// <value>
        /// The icon path data.
        /// </value>
        public Geometry IconData
        {
            get { return (Geometry)this.GetValue(IconDataProperty); }
            set { this.SetValue(IconDataProperty, value); }
        }

        /// <summary>
        /// Gets or sets the icon height.
        /// </summary>
        /// <value>
        /// The icon height.
        /// </value>
        public double IconHeight
        {
            get { return (double)this.GetValue(IconHeightProperty); }
            set { this.SetValue(IconHeightProperty, value); }
        }

        /// <summary>
        /// Gets or sets the icon width.
        /// </summary>
        /// <value>
        /// The icon width.
        /// </value>
        public double IconWidth
        {
            get { return (double)this.GetValue(IconWidthProperty); }
            set { this.SetValue(IconWidthProperty, value); }
        }
    }
}
