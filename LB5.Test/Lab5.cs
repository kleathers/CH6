using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB5.Test
{
    [TestClass]
    public class Lab5
    {
        [TestMethod]
        public void all_zero_avg()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "0";
                form.txtTemp2.Text = "0";
                form.txtTemp3.Text = "0";
                form.txtTemp4.Text = "0";
                form.txtTemp5.Text = "0";
                form.txtTemp6.Text = "0";
                form.txtTemp7.Text = "0";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("Average: 0", form.lblAvgAll.Text);
            }
        }

        [TestMethod]
        public void all_zero_deltas()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "0";
                form.txtTemp2.Text = "0";
                form.txtTemp3.Text = "0";
                form.txtTemp4.Text = "0";
                form.txtTemp5.Text = "0";
                form.txtTemp6.Text = "0";
                form.txtTemp7.Text = "0";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("same as avg", form.lblDelta1.Text);
                Assert.AreEqual("same as avg", form.lblDelta2.Text);
                Assert.AreEqual("same as avg", form.lblDelta3.Text);
                Assert.AreEqual("same as avg", form.lblDelta4.Text);
                Assert.AreEqual("same as avg", form.lblDelta5.Text);
                Assert.AreEqual("same as avg", form.lblDelta6.Text);
                Assert.AreEqual("same as avg", form.lblDelta7.Text);
            }
        }

        [TestMethod]
        public void all_70_avg()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "70";
                form.txtTemp2.Text = "70";
                form.txtTemp3.Text = "70";
                form.txtTemp4.Text = "70";
                form.txtTemp5.Text = "70";
                form.txtTemp6.Text = "70";
                form.txtTemp7.Text = "70";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("Average: 70", form.lblAvgAll.Text);
            }
        }

        [TestMethod]
        public void all_70_deltas()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "70";
                form.txtTemp2.Text = "70";
                form.txtTemp3.Text = "70";
                form.txtTemp4.Text = "70";
                form.txtTemp5.Text = "70";
                form.txtTemp6.Text = "70";
                form.txtTemp7.Text = "70";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("same as avg", form.lblDelta1.Text);
                Assert.AreEqual("same as avg", form.lblDelta2.Text);
                Assert.AreEqual("same as avg", form.lblDelta3.Text);
                Assert.AreEqual("same as avg", form.lblDelta4.Text);
                Assert.AreEqual("same as avg", form.lblDelta5.Text);
                Assert.AreEqual("same as avg", form.lblDelta6.Text);
                Assert.AreEqual("same as avg", form.lblDelta7.Text);
            }
        }

        [TestMethod]
        public void ascending_avg()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "39";
                form.txtTemp2.Text = "41";
                form.txtTemp3.Text = "43";
                form.txtTemp4.Text = "45";
                form.txtTemp5.Text = "47";
                form.txtTemp6.Text = "49";
                form.txtTemp7.Text = "51";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("Average: 45", form.lblAvgAll.Text);
            }
        }

        [TestMethod]
        public void ascending_deltas()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "39";
                form.txtTemp2.Text = "41";
                form.txtTemp3.Text = "43";
                form.txtTemp4.Text = "45";
                form.txtTemp5.Text = "47";
                form.txtTemp6.Text = "49";
                form.txtTemp7.Text = "51";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("6\u00B0 below avg", form.lblDelta1.Text);
                Assert.AreEqual("4\u00B0 below avg", form.lblDelta2.Text);
                Assert.AreEqual("2\u00B0 below avg", form.lblDelta3.Text);
                Assert.AreEqual("same as avg", form.lblDelta4.Text);
                Assert.AreEqual("2\u00B0 above avg", form.lblDelta5.Text);
                Assert.AreEqual("4\u00B0 above avg", form.lblDelta6.Text);
                Assert.AreEqual("6\u00B0 above avg", form.lblDelta7.Text);
            }
        }

        [TestMethod]
        public void descending_avg()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "51";
                form.txtTemp2.Text = "49";
                form.txtTemp3.Text = "47";
                form.txtTemp4.Text = "45";
                form.txtTemp5.Text = "43";
                form.txtTemp6.Text = "41";
                form.txtTemp7.Text = "39";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("Average: 45", form.lblAvgAll.Text);
            }
        }

        [TestMethod]
        public void descending_deltas()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "51";
                form.txtTemp2.Text = "49";
                form.txtTemp3.Text = "47";
                form.txtTemp4.Text = "45";
                form.txtTemp5.Text = "43";
                form.txtTemp6.Text = "41";
                form.txtTemp7.Text = "39";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("6\u00B0 above avg", form.lblDelta1.Text);
                Assert.AreEqual("4\u00B0 above avg", form.lblDelta2.Text);
                Assert.AreEqual("2\u00B0 above avg", form.lblDelta3.Text);
                Assert.AreEqual("same as avg", form.lblDelta4.Text);
                Assert.AreEqual("2\u00B0 below avg", form.lblDelta5.Text);
                Assert.AreEqual("4\u00B0 below avg", form.lblDelta6.Text);
                Assert.AreEqual("6\u00B0 below avg", form.lblDelta7.Text);
            }
        }

        [TestMethod]
        public void x_unorderd_avg()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "51";
                form.txtTemp2.Text = "39";
                form.txtTemp3.Text = "49";
                form.txtTemp4.Text = "41";
                form.txtTemp5.Text = "47";
                form.txtTemp6.Text = "43";
                form.txtTemp7.Text = "45";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("Average: 45", form.lblAvgAll.Text);
            }
        }

        [TestMethod]
        public void x_unorderd_deltas()
        {
            using (var form = new TemperaturesForm())
            {
                form.Show();
                form.txtTemp1.Text = "51";
                form.txtTemp2.Text = "39";
                form.txtTemp3.Text = "49";
                form.txtTemp4.Text = "41";
                form.txtTemp5.Text = "47";
                form.txtTemp6.Text = "43";
                form.txtTemp7.Text = "45";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("6\u00B0 above avg", form.lblDelta1.Text);
                Assert.AreEqual("6\u00B0 below avg", form.lblDelta2.Text);
                Assert.AreEqual("4\u00B0 above avg", form.lblDelta3.Text);
                Assert.AreEqual("4\u00B0 below avg", form.lblDelta4.Text);
                Assert.AreEqual("2\u00B0 above avg", form.lblDelta5.Text);
                Assert.AreEqual("2\u00B0 below avg", form.lblDelta6.Text);
                Assert.AreEqual("same as avg", form.lblDelta7.Text);
            }
        }
    }
}
