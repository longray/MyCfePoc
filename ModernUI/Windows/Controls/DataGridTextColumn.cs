namespace ModernUI.Windows.Controls
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    using ModernUI.Windows.Validators;

    /// <summary>
    /// A DataGrid text column using default Modern UI element styles.
    /// </summary>
    public class DataGridTextColumn: Microsoft.Windows.Controls.DataGridTextColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridTextColumn"/> class.
        /// </summary>
        public DataGridTextColumn()
        {
            //this.ElementStyle = Application.Current.Resources["DataGridTextStyle"] as Style;
            //this.EditingElementStyle = Application.Current.Resources["DataGridEditingTextStyle"] as Style;
            this.SetStyle();
        }

        public static readonly DependencyProperty HorizontalAlignmentProperty = DependencyProperty.Register("HorizontalAlignment",
            typeof(HorizontalAlignment),
            typeof(DataGridTextColumn),
            new FrameworkPropertyMetadata(HorizontalAlignment.Left, FrameworkPropertyMetadataOptions.AffectsArrange), FrameworkElementValidator.ValidateHorizontalAlignmentValue);

        public static readonly DependencyProperty VerticalAlignmentProperty = DependencyProperty.Register("VerticalAlignment",
            typeof(VerticalAlignment),
            typeof(DataGridTextColumn),
            new FrameworkPropertyMetadata(VerticalAlignment.Top, FrameworkPropertyMetadataOptions.AffectsArrange), FrameworkElementValidator.ValidateVerticalAlignmentValue);

        /// <summary>
        /// get/set HorizontalAlignment
        /// </summary>
        public HorizontalAlignment HorizontalAlignment
        {
            get { return (HorizontalAlignment)this.GetValue(HorizontalAlignmentProperty); }
            set { this.SetValue(HorizontalAlignmentProperty, value); }
        }

        /// <summary>
        /// get/set VerticalAlignment
        /// </summary>
        public VerticalAlignment VerticalAlignment
        {
            get { return (VerticalAlignment)this.GetValue(VerticalAlignmentProperty); }
            set { this.SetValue(VerticalAlignmentProperty, value); }
        }

        private Style _textStyle;

        public Style TextStyle
        {
            get
            {
                return this._textStyle
                       ?? (this._textStyle = Application.Current.Resources["DataGridTextStyle"] as Style);
            }
        }

        private Style _editingTextStyle;

        public Style EditingTextStyle
        {
            get
            {
                return this._editingTextStyle
                       ?? (this._editingTextStyle = Application.Current.Resources["DataGridEditingTextStyle"] as Style);
            }
        }

        private void SetStyle(
            HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left,
            VerticalAlignment verticalAlignment = VerticalAlignment.Top)
        {

            var editingStyle = new Style(typeof(TextBox)) { BasedOn = EditingTextStyle };
            editingStyle.Setters.Add(new Setter(FrameworkElement.HorizontalAlignmentProperty, horizontalAlignment));
            editingStyle.Setters.Add(new Setter(FrameworkElement.VerticalAlignmentProperty, verticalAlignment));

            var elementStyle = new Style(typeof(TextBlock)) { BasedOn = TextStyle };
            elementStyle.Setters.Add(new Setter(FrameworkElement.HorizontalAlignmentProperty, horizontalAlignment));
            elementStyle.Setters.Add(new Setter(FrameworkElement.VerticalAlignmentProperty, verticalAlignment));

            this.ElementStyle = elementStyle;
            this.EditingElementStyle = editingStyle;
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property == HorizontalAlignmentProperty)
            {
                var h = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), e.NewValue.ToString());
                this.SetStyle(h, VerticalAlignment);
            }
            else if (e.Property == VerticalAlignmentProperty)
            {
                var v = (VerticalAlignment)Enum.Parse(typeof(VerticalAlignment), e.NewValue.ToString());
                this.SetStyle(HorizontalAlignment, v);
            }
            base.OnPropertyChanged(e);
        }
    }
}
