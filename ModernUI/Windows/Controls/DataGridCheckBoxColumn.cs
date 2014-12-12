namespace ModernUI.Windows.Controls
{
    using System;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;

    using ModernUI.Windows.Validators;

    /// <summary>
    /// A DataGrid checkbox column using default Modern UI element styles.
    /// </summary>
    public class DataGridCheckBoxColumn
        : Microsoft.Windows.Controls.DataGridCheckBoxColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridCheckBoxColumn"/> class.
        /// </summary>
        public DataGridCheckBoxColumn()
        {
            SetStyle();
        }


        public static readonly DependencyProperty HorizontalAlignmentProperty = DependencyProperty.Register("HorizontalAlignment",
            typeof(HorizontalAlignment),
            typeof(DataGridCheckBoxColumn),
            new FrameworkPropertyMetadata(HorizontalAlignment.Left, FrameworkPropertyMetadataOptions.AffectsArrange), FrameworkElementValidator.ValidateHorizontalAlignmentValue);

        public static readonly DependencyProperty VerticalAlignmentProperty = DependencyProperty.Register("VerticalAlignment",
            typeof(VerticalAlignment),
            typeof(DataGridCheckBoxColumn),
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

        private Style _checkboxStyle;

        public Style CheckboxStyle
        {
            get
            {
                return this._checkboxStyle
                       ?? (this._checkboxStyle = Application.Current.Resources["DataGridCheckBoxStyle"] as Style);
            }
        }

        private void SetStyle(
            HorizontalAlignment horizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment verticalAlignment = VerticalAlignment.Top)
        {
            var editingStyle = new Style(typeof(CheckBox)) { BasedOn = CheckboxStyle };
            editingStyle.Setters.Add(new Setter(FrameworkElement.HorizontalAlignmentProperty, horizontalAlignment));
            editingStyle.Setters.Add(new Setter(FrameworkElement.VerticalAlignmentProperty, verticalAlignment));

            var elementStyle = new Style(typeof(CheckBox)) { BasedOn = editingStyle };
            elementStyle.Setters.Add(new Setter(UIElement.IsHitTestVisibleProperty, false));
            elementStyle.Setters.Add(new Setter(UIElement.FocusableProperty, false));

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
                this.SetStyle(HorizontalAlignment,v);
            }
            base.OnPropertyChanged(e);
        }
    }
}
