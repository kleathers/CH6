using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB7.Test
{
    [TestClass]
    public class Lab7
    {
        private const string ERROR = "error";

        [TestMethod]
        public void nights_negative()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "-1";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(ERROR, form.lblNightlyRate.Text);
                Assert.AreEqual(ERROR, form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_zero()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "0";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(ERROR, form.lblNightlyRate.Text);
                Assert.AreEqual(ERROR, form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_1()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "1";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$200.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$200.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_2()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "2";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$200.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$400.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_3()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "3";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$180.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$540.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_4()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "4";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$180.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$720.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_5()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "5";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$160.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$800.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_6()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "6";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$160.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$960.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_7()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "7";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$160.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$1,120.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_8()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "8";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$145.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$1,160.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_9()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "9";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$145.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$1,305.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_10()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "10";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$145.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$1,450.00", form.lblTotalCost.Text);
            }
        }

        [TestMethod]
        public void nights_100()
        {
            using (var form = new ReservationForm())
            {
                form.Show();
                form.txtNightsStayed.Text = "100";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$145.00", form.lblNightlyRate.Text);
                Assert.AreEqual("$14,500.00", form.lblTotalCost.Text);
            }
        }
    }
}
