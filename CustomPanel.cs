using System;
using Avalonia;
using Avalonia.Controls;

namespace AvaloniaMeasureArrange
{
    public class RandomPanel : Panel
    {
         protected override Size MeasureOverride(Size constraint)
         {
            double height = 0, width = 0;

            foreach (Control child in Children)
            {
                child.Measure(constraint);

                width += child.DesiredSize.Width;
                height += child.DesiredSize.Height;
            }

            return new Size(width, height);
         }

         protected override Size ArrangeOverride(Size arrangeBounds)
         {
   
            foreach (var child in Children)
            {
                child.Arrange(new Rect(
                    mRandom.Next(0, (int)(arrangeBounds.Width - child.DesiredSize.Width)),
                    mRandom.Next(0, (int)(arrangeBounds.Height - child.DesiredSize.Height)),
                    child.DesiredSize.Width,
                    child.DesiredSize.Height));
            }
    
            return arrangeBounds;
         }

        Random mRandom = new Random();
    }
}