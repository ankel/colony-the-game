using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace colony
{
    /// <summary>
    /// Basic resource: use once after gathered
    /// </summary>
    class SimpleResource : Resource
    {
        private string name;
        private long current;

        public long Current
        {
            get { return current; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Current value of " + this.name + " is being set to negative");
                }
                else
                {
                    this.current = value;
                }

            }
        }

        public string Name
        {
            get { return this.name; }
        }

        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private long cap;

        public long Cap
        {
            get { return cap; }
            set { cap = value; }
        }

        public SimpleResource(string name, int current, int cap, int rate)
        {
            this.name = name;
            this.current = current;
            this.cap = cap;
            this.rate = rate;
        }

        public void Tick()
        {
            this.current += this.Rate;
            if (this.current >= this.Cap)
                this.current = this.Cap;
        }

        public override string ToString()
        {
            return String.Format("{0}", this.current, this.Cap);
        }

        public string Tooltip
        {
            get { return String.Format("{0:+#;-#;0} per day", this.Rate);}
        }

        public bool IsFull
        {
            get { return current >= cap; }
        }
    }

    [TestFixture]
    class TestSimpleResource
    {
        SimpleResource res;

        [SetUp]
        public void SetUp()
        {
            res = new SimpleResource("Metal", 500, 1000, 100);
        }

        [Test]
        public void TestInitialization()
        {
            Assert.AreEqual(res.Name, "Metal");
            Assert.AreEqual(res.Current, 500);
            Assert.AreEqual(res.Cap, 1000);
            Assert.AreEqual(res.Rate, 100);
        }

        [Test]
        public void TestTick()
        {
            res.Tick();
            Assert.AreEqual(res.Current, 500 + 100);

            res.Current = 950;
            res.Tick();
            Assert.AreEqual(res.Current, res.Cap);
        }

    }
}
