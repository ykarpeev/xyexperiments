// <copyright file="FullWindow.cs" company="y">
// Copyright (c) y. All rights reserved.
// </copyright>

namespace YK.GantrySplit.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FullWindow : EntityObject
    {
        public FullWindow(double minx, double maxx, double miny, double maxy)
            : base(minx, maxx, miny, maxy, 0)
        {
        }
    }
}
