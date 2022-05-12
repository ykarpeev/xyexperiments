using NUnit.Framework;
using YK.GantrySplit.Services;
using GantrySplit;
using System.Collections.Generic;

namespace GantrySplit.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var workWindow = new WorkingWindow(0, 100, 0, 100);
            var totalWindow = new FullWindow(0, 400, 0, 400);

            var ent1 = new EntityObject(0, 5, 0, 5, 0);
            var ent2 = new EntityObject(0, 101, 0, 5, 1);
            var ent3 = new EntityObject(0, 15, 0, 15, 0);
            var ent4 = new EntityObject(300, 315, 0, 15, 0);

            var l = new List<EntityObject>() { ent1, ent2, ent3, ent4 };


            new GantrySplit().Split(workWindow, totalWindow, l);

        }
    }
}