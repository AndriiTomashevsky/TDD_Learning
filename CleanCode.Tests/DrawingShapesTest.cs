using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    [TestClass]
    public class DrawingShapesTest
    {
        public List<IShape> GetList()
        {
            return new List<IShape>();
        }

        public Painter GetPainter()
        {
            return new Painter(new ShapeComparer());
        }


        [TestMethod]
        public void TestDrawOneShape()
        {
            Painter circle = GetPainter();
            var shapes = GetList();
            shapes.Add(new Circle());

            Assert.AreEqual("Circle", circle.Draw(shapes));
        }

        [TestMethod]
        public void TestDrawTwoShapes()
        {
            var painter = GetPainter();
            var shapes = GetList();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            Assert.AreEqual("CircleRectangle", painter.Draw(shapes));
        }

        [TestMethod]
        public void TestPriority()
        {
            var painter = GetPainter();
            var shapes = GetList();
            shapes.Add(new Rectangle());
            shapes.Add(new Circle());

            Assert.AreEqual("CircleRectangle", painter.Draw(shapes));
        }

        [TestMethod]
        public void TestTwoSameShape()
        {
            var painter = GetPainter();
            var shapes = GetList();
            shapes.Add(new Circle());
            shapes.Add(new Circle());

            Assert.AreEqual("CircleCircle", painter.Draw(shapes));
        }
    }

    public struct Rectangle : IShape
    {
        public string Draw()
        {
            return "Rectangle";
        }
    }

    public struct Circle : IShape
    {
        public string Draw()
        {
            return "Circle";
        }
    }

    public interface IShape
    {
        string Draw();
    }

    public class Painter
    {
        IComparer<IShape> comparer;

        public Painter(IComparer<IShape> comparer)
        {
            this.comparer = comparer;
        }

        internal string Draw(List<IShape> shapes)
        {
            string shape = "";

            shapes.Sort(comparer);

            foreach (var s in shapes)
            {
                shape += s.Draw();
            }

            return shape;
        }
    }

    internal class ShapeComparer : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            if (x is Circle)
            {
                return -1;
            }

            return 1;
        }
    }
}
