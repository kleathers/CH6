using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LB4.Test
{
    [TestClass]
    public class Lab4
    {
        private const string ASSIGNMENTS_ASCENDING =
            "Lab 1: 90%\n" +
            "Lab 2: 95%\n" +
            "Lab 3: 92%\n" +
            "Test 1: 91%\n" +
            "Lab 4: 80%\n" +
            "Lab 5: 85%\n" +
            "Lab 6: 82%\n" +
            "Test 2: 95%\n";
        
        private const string ASSIGNMENTS_DESCENDING =
            "Test 2: 95%\n" +
            "Lab 6: 82%\n" +
            "Lab 5: 85%\n" +
            "Lab 4: 80%\n" +
            "Test 1: 91%\n" +
            "Lab 3: 92%\n" +
            "Lab 2: 95%\n" +
            "Lab 1: 90%\n";

        [TestMethod]
        public void show_oldest_first()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnOldest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_ASCENDING, form.lblAssignments.Text);
            }
        }

        [TestMethod]
        public void show_newest_first()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnNewest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_DESCENDING, form.lblAssignments.Text);
            }
        }

        [TestMethod]
        public void view_1()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "1";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 1: 90%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_2()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "2";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 2: 95%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_3()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "3";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 3: 92%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_4()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "4";
                form.btnView.PerformClick();

                Assert.AreEqual("Test 1: 91%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_5()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "5";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 4: 80%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_6()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "6";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 5: 85%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_7()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "7";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 6: 82%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void view_8()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.txtNumber.Text = "8";
                form.btnView.PerformClick();

                Assert.AreEqual("Test 2: 95%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void x_view_1b()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnOldest.PerformClick();
                form.txtNumber.Text = "1";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 1: 90%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void x_view_1c()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnNewest.PerformClick();
                form.txtNumber.Text = "1";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 1: 90%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void x_view_2b()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnOldest.PerformClick();
                form.txtNumber.Text = "2";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 2: 95%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void x_view_2c()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnNewest.PerformClick();
                form.txtNumber.Text = "2";
                form.btnView.PerformClick();

                Assert.AreEqual("Lab 2: 95%", form.lblResult.Text);
            }
        }

        [TestMethod]
        public void x_oldest_oldest()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnOldest.PerformClick();
                form.btnOldest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_ASCENDING, form.lblAssignments.Text);
            }
        }

        [TestMethod]
        public void x_newest_newest()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnNewest.PerformClick();
                form.btnNewest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_DESCENDING, form.lblAssignments.Text);
            }
        }

        [TestMethod]
        public void x_newest_oldest()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnNewest.PerformClick();
                form.btnOldest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_ASCENDING, form.lblAssignments.Text);
            }
        }

        [TestMethod]
        public void x_oldest_newest()
        {
            using (var form = new AssignmentsForm())
            {
                form.Show();
                form.btnOldest.PerformClick();
                form.btnNewest.PerformClick();

                Assert.AreEqual(ASSIGNMENTS_DESCENDING, form.lblAssignments.Text);
            }
        }
    }
}
