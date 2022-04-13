using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdaptiveGrid
{

    /// <summary>
    /// A responsive <see cref="Grid"/> alternative.
    /// Change the layout distribution based on the grid's width.
    /// Inspired by CSS grid
    /// </summary>
    public class AdaptiveGrid : Grid
    {

        private AdaptiveGridTemplateArea _latestGridTemplateArea = null;

        #region Properties
        /// <summary>
        /// Property for <see cref="TemplateArea"/>.
        /// </summary>
        public static DependencyProperty TemplateAreaProperty =
            DependencyProperty.Register(nameof(TemplateAreas), typeof(List<AdaptiveGridTemplateArea>), typeof(AdaptiveGrid),
                new FrameworkPropertyMetadata(new List<AdaptiveGridTemplateArea>()) { BindsTwoWayByDefault = true });


        /// <summary>
        /// Template for grid areas
        /// </summary>
        public List<AdaptiveGridTemplateArea> TemplateAreas
        {
            get => (List<AdaptiveGridTemplateArea>)GetValue(TemplateAreaProperty);
            set => SetValue(TemplateAreaProperty, value);
        }

        /// <summary>
        /// Area name attached dependency property
        /// </summary>
        public static readonly DependencyProperty AreaProperty =
            DependencyProperty.RegisterAttached("Area", typeof(string), typeof(AdaptiveGrid),
                new FrameworkPropertyMetadata(defaultValue: null, flags: FrameworkPropertyMetadataOptions.AffectsRender));

        public static string GetArea(UIElement target) => (string)target.GetValue(AreaProperty);

        public static void SetArea(UIElement target, string value) => target.SetValue(AreaProperty, value);
        #endregion

        public AdaptiveGrid()
        {
            SizeChanged += GridSizeChanged;
            TemplateAreas = new List<AdaptiveGridTemplateArea>();
        }

        private void GridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Responsive grid, change children distribution based on width
            var width = ActualWidth;
            var templateArea = TemplateAreas.FindLast(it => width > it.FromWidth);
            if (templateArea == null || templateArea == _latestGridTemplateArea) return;

            _latestGridTemplateArea = templateArea;
            foreach (var area in templateArea.Areas)
            {
                var elements = Children.OfType<UIElement>()
                    .Where(it => GetArea(it) == area.Area)
                    .ToList();

                foreach (var element in elements)
                {

                    //For every control that defined its "Area" property,
                    //change the position on the grid
                    SetColumn(element, area.Column);
                    SetRow(element, area.Row);
                    SetRowSpan(element, area.RowSpan);
                    SetColumnSpan(element, area.ColumnSpan);
                }
            }

        }

    }
}
