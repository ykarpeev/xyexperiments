// <copyright file="GantrySplit.cs" company="y">
// Copyright (c) y. All rights reserved.
// </copyright>

namespace GantrySplit
{
    using YK.GantrySplit.Services;

    public class GantrySplit
    {
        public void Split(WorkingWindow workWindow, FullWindow fullWindow, IList<EntityObject> objects)
        {
            // We will want to find all of the objects that will not fit into our work window.
            var largerThanWorkWindow = objects.Where(x => x.Width > workWindow.Width || x.Height > workWindow.Height);

            // Here is what does fit.
            var withinWithinWorkWindow = objects.Except(largerThanWorkWindow);

            // We won't do much optimization for this mode.
            var maxx = withinWithinWorkWindow.Select(entity => entity.MaximumX).Concat(new double[] { }).Max();
            var maxy = withinWithinWorkWindow.Select(entity => entity.MaximumY).Concat(new double[] { }).Max();

            var miny = withinWithinWorkWindow.Select(entity => entity.MinimumX).Concat(new double[] { }).Min();
            var minx = withinWithinWorkWindow.Select(entity => entity.MinimumX).Concat(new double[] { }).Min();

            var allents = new EntityObject(minx, maxx, miny, maxy, 0);
            /*
                 ┌───────────────────┼────────────────────┐
                 │                   │                    │
                 │                   │                    │
                 │                   │                    │
                 │                   │                    │
                 │        ┌──────────┼──────────┐         │
                 │        │          │     ent3 │         │
                 │        │ent1      │          │         │
                 │        │          │          │         │
                 │        │          │          │         │
                ─┼────────┼──────────┼──────────┼─────────┼─
                 │        │          │          │         │
                 │        │          │          │         │
                 │        │          │      ent2│         │
                 │        └──────────┼──────────┘         │
                 │                   │                    │
                 │                   │                    │
                 │                   │                    │
                 └───────────────────┼────────────────────┘
            */

            var l = new List<List<EntityObject>>();

            if (allents.Width <= workWindow.Width && allents.Height <= workWindow.Height)
            {
                var x = 0;
            }
            else
            {
                // We'll iterate through each object and build up our lists

            }
        }


    }
}