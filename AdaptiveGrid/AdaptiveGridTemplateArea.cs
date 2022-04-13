using System.Collections.Generic;
using System.Windows;

namespace AdaptiveGrid
{

    /// <summary>
    /// A collection of <see cref="AdaptiveGridArea"/>
    /// </summary>
    public class AdaptiveGridTemplateArea : FrameworkContentElement
    {


        /// <summary>
        /// Property for <see cref="FromWidth"/>.
        /// </summary>
        public static readonly DependencyProperty FromWidthProperty =
            DependencyProperty.Register(nameof(FromWidth), typeof(int), typeof(AdaptiveGridTemplateArea),
                new FrameworkPropertyMetadata(0));

        /// <summary>
        /// Property for <see cref="Areas"/>.
        /// </summary>
        public static readonly DependencyProperty AreasProperty =
            DependencyProperty.Register(nameof(Areas), typeof(List<AdaptiveGridArea>), typeof(AdaptiveGridTemplateArea),
                new FrameworkPropertyMetadata(new List<AdaptiveGridArea>()) { BindsTwoWayByDefault = true });


        /// <summary>
        /// Set or get the minimum width to display this template
        /// </summary>
        public int FromWidth
        {
            get => (int)GetValue(FromWidthProperty);
            set => SetValue(FromWidthProperty, value);
        }

        /// <summary>
        /// Set or get the areas that define this template
        /// </summary>
        public List<AdaptiveGridArea> Areas
        {
            get => (List<AdaptiveGridArea>)GetValue(AreasProperty);
            set => SetValue(AreasProperty, value);
        }

        public AdaptiveGridTemplateArea() : base()
        {
            Areas = new List<AdaptiveGridArea>();
        }
    }
}
