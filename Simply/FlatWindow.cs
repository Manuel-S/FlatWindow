using System.Windows;

namespace Simply
{
    public class FlatWindow : Window
    {
        #region Init

        static FlatWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlatWindow),
                new FrameworkPropertyMetadata(typeof(FlatWindow)));
        }

        #endregion
    }
}