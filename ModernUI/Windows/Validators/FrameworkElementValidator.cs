namespace ModernUI.Windows.Validators
{
    using System.Windows;

    public class FrameworkElementValidator
    {

        public static bool ValidateHorizontalAlignmentValue(object value)
        {
            var horizontalAlignment = (HorizontalAlignment)value;
            switch (horizontalAlignment)
            {
                case HorizontalAlignment.Left:
                case HorizontalAlignment.Center:
                case HorizontalAlignment.Right:
                    return true;
                default:
                    return horizontalAlignment == HorizontalAlignment.Stretch;
            }
        }

        public static bool ValidateVerticalAlignmentValue(object value)
        {
            var verticalAlignment = (VerticalAlignment)value;
            switch (verticalAlignment)
            {
                case VerticalAlignment.Top:
                case VerticalAlignment.Center:
                case VerticalAlignment.Bottom:
                    return true;
                default:
                    return verticalAlignment == VerticalAlignment.Stretch;
            }
        }
    }
}
