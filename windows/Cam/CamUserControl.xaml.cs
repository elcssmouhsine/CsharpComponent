using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Cam
{
    public sealed partial class CamUserControl : Control
    {
        public static DependencyProperty LabelProperty { get; private set; }

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }
        }

        static CamUserControl()
        {
            LabelProperty = DependencyProperty.Register(
                nameof(Label),
                typeof(string),
                typeof(CamUserControl),
                new PropertyMetadata(default(string))
                );
        }

        public CamUserControl()
        {
            DefaultStyleKey = typeof(CamUserControl);
        }
    }
}
