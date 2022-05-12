// <copyright file="SplitRectangle.cs" company="y">
// Copyright (c) y. All rights reserved.
// </copyright>

namespace YK.GantrySplit.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WorkingWindow : EntityObject
    {
        public WorkingWindow(double minx, double maxx, double miny, double maxy)
      : base(minx, maxx, miny, maxy, 0)
        {
        }
    }
}
