using System.Windows;

namespace AdaptiveGrid
{

    /// <summary>
    /// Defines a <see cref="AdaptiveGrid"/> area
    /// </summary>
    public class AdaptiveGridArea : FrameworkContentElement
    {
        /// <summary>
        /// Property for <see cref="Area"/>.
        /// </summary>
        public static readonly DependencyProperty AreaProperty =
            DependencyProperty.Register(nameof(Area), typeof(string), typeof(AdaptiveGridArea),
                new FrameworkPropertyMetadata(""));

        /// <summary>
        /// Property for <see cref="Column"/>.
        /// </summary>
        public static readonly DependencyProperty ColumnProperty =
            DependencyProperty.Register(nameof(Column), typeof(int), typeof(AdaptiveGridArea),
                new FrameworkPropertyMetadata(0));

        /// <summary>
        /// Property for <see cref="Row"/>.
        /// </summary>
        public static readonly DependencyProperty RowProperty =
            DependencyProperty.Register(nameof(Row), typeof(int), typeof(AdaptiveGridArea),
                new FrameworkPropertyMetadata(0));

        /// <summary>
        /// Property for <see cref="ColumnSpan"/>.
        /// </summary>
        public static readonly DependencyProperty ColumnSpanProperty =
            DependencyProperty.Register(nameof(ColumnSpan), typeof(int), typeof(AdaptiveGridArea),
                new FrameworkPropertyMetadata(1));

        /// <summary>
        /// Property for <see cref="RowSpan"/>.
        /// </summary>
        public static readonly DependencyProperty RowSpanProperty =
            DependencyProperty.Register(nameof(RowSpan), typeof(int), typeof(AdaptiveGridArea),
                new FrameworkPropertyMetadata(1));


        /// <summary>
        /// Set or get the area name
        /// </summary>
        public string Area
        {
            get => (string)GetValue(AreaProperty);
            set => SetValue(AreaProperty, value);
        }

        /// <summary>
        /// Set or get the area column position
        /// </summary>
        public int Column
        {
            get => (int)GetValue(ColumnProperty);
            set => SetValue(ColumnProperty, value);
        }

        /// <summary>
        /// Set or get the area row position
        /// </summary>
        public int Row
        {
            get => (int)GetValue(RowProperty);
            set => SetValue(RowProperty, value);
        }

        /// <summary>
        /// Set or get the area column span
        /// </summary>
        public int ColumnSpan
        {
            get => (int)GetValue(ColumnSpanProperty);
            set => SetValue(ColumnSpanProperty, value);
        }

        /// <summary>
        /// Set or get the area row span
        /// </summary>
        public int RowSpan
        {
            get => (int)GetValue(RowSpanProperty);
            set => SetValue(RowSpanProperty, value);
        }

    }
}
