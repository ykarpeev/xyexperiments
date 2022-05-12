using NUnit.Framework;

namespace YK.GantrySplit.Services.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PropertySetTests()
        {
            var entityObject = new EntityObject(-10.1, 20.0, -55.4, 0.4, 125);

            Assert.That(entityObject.MinimumX, Is.EqualTo(-10.1));
            Assert.That(entityObject.MaximumX, Is.EqualTo(20.0));

            Assert.That(entityObject.MinimumY, Is.EqualTo(-55.4));
            Assert.That(entityObject.MaximumY, Is.EqualTo(0.4));

            Assert.That(entityObject.CenterX, Is.EqualTo(-17.69).Within(0.01));
            Assert.That(entityObject.CenterY, Is.EqualTo(-27.5).Within(0.01));

            Assert.That(entityObject.Width, Is.EqualTo(30.1).Within(0.1));
            Assert.That(entityObject.Height, Is.EqualTo(10.5).Within(0.1));

            Assert.That(entityObject.Hash, Is.EqualTo(125));
        }

        [Test]
        public void ConstructorNoParamstest()
        {
            var entityObject = new EntityObject();
            Assert.That(entityObject.MinimumX, Is.EqualTo(0));
            Assert.That(entityObject.MaximumX, Is.EqualTo(0));

            Assert.That(entityObject.MinimumY, Is.EqualTo(0));
            Assert.That(entityObject.MaximumY, Is.EqualTo(0));

            Assert.That(entityObject.CenterX, Is.EqualTo(0));
            Assert.That(entityObject.CenterY, Is.EqualTo(0));

            Assert.That(entityObject.Width, Is.EqualTo(0));
            Assert.That(entityObject.Height, Is.EqualTo(0));
        }
    }
}