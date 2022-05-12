// <copyright file="EntityObject.cs" company="y">
// Copyright (c) y. All rights reserved.
// </copyright>

namespace YK.GantrySplit.Services
{
    /// <summary>
    /// Entity object.
    /// </summary>
    public class EntityObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityObject"/> class.
        /// </summary>
        /// <param name="minx">Minimum X..</param>
        /// <param name="maxx">Maximum X.</param>
        /// <param name="miny">Minimum Y.</param>
        /// <param name="maxy">Maximum Y.</param>
        public EntityObject(double minx, double maxx, double miny, double maxy, long hash)
        {
            /*
                       max y
           ┌───────────────────────────┐
           │                           │
           │                           │
       miny│                           │maxx
           │                           │
           │                           │
           │                           │
           └───────────────────────────┘
                       min y
          */

            this.MinimumX = minx;
            this.MinimumY = miny;
            this.MaximumX = maxx;
            this.MaximumY = maxy;
            this.Hash = hash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityObject"/> class.
        /// </summary>
        public EntityObject()
            : this(0, 0, 0, 0, 0)
        {
        }

        /// <summary>
        /// Gets the minimum x value.
        /// </summary>
        public double MinimumX { get; }

        /// <summary>
        ///  Gets the minimum y value.
        /// </summary>
        public double MinimumY { get; }

        /// <summary>
        /// Gets the maximum x value.
        /// </summary>
        public double MaximumX { get; }

        /// <summary>
        /// Gets the maximum y value.
        /// </summary>
        public double MaximumY { get; }

        /// <summary>
        /// Gets the X center of the entity.
        /// </summary>
        public double CenterX => (this.MaximumX + this.MinimumY) / 2;

        /// <summary>
        /// Gets the Y center of the entity.
        /// </summary>
        public double CenterY => (this.MaximumY + this.MinimumY) / 2;

        /// <summary>
        /// Gets the width of the entity.
        /// </summary>
        public double Width
        {
            get
            {
                return Math.Sqrt(Math.Pow(this.MaximumX - this.MinimumX, 2));
            }
        }

        /// <summary>
        /// Gets the height of the entity.
        /// </summary>
        public double Height
        {
            get
            {
                return Math.Sqrt(Math.Pow(this.MaximumY - this.MinimumX, 2));
            }
        }

        /// <summary>
        /// Gets the object hash.
        /// </summary>
        public long Hash { get; }
    }
}