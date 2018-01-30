using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB6.Test
{
    [TestClass]
    public class Lab6
    {
        private const string NOT_IN_AREA = "not in delivery area";
        
        [TestMethod]
        public void zip_11111()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "11111";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(NOT_IN_AREA, form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63101()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63101";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$20.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63103()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63103";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$12.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63105()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63105";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$25.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63109()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63109";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$15.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63113()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63113";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$10.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63118()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63118";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$23.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63130()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63130";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$18.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63133()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63133";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$20.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63136()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63136";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$17.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_63137()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "63137";
                form.btnCalculate.PerformClick();

                Assert.AreEqual("$12.00", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_blank()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(NOT_IN_AREA, form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_zzz()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "zzz";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(NOT_IN_AREA, form.lblResult.Text);
            }
        }

        [TestMethod]
        public void zip_zzzzz()
        {
            using (var form = new DeliveryForm())
            {
                form.Show();
                form.txtZipCode.Text = "zzzzz";
                form.btnCalculate.PerformClick();

                Assert.AreEqual(NOT_IN_AREA, form.lblResult.Text);
            }
        }
    }
}
