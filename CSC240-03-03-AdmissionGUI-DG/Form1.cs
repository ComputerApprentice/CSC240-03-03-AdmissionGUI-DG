using System;
using System.Windows.Forms;
namespace CSC240_03_03_AdmissionGUI_DG
{

    public partial class Form1 : Form

    {

        int totalAccepted = 0, totalRejected = 0;

        public Form1()

        {

            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)

        {

            // Validate grade point

            float gradePointAvg = 0.0f;

            // Valid float between 0.0 and 4.0

            if (float.TryParse(txtGradeAverage.Text, out gradePointAvg) == false || gradePointAvg < 0 || gradePointAvg > 4)

            {

                MessageBox.Show("Invalid Grade point average entered!");

                return;

            }

            // Validate test score

            int testScore = 0;

            // Valid int between 0 and 100

            if (int.TryParse(txtTestScore.Text, out testScore) == false || testScore < 0 || testScore > 100)

            {

                MessageBox.Show("Invalid test score entered!");

                return;

            }

            // Determine the qualification

            bool accepted = false;

            if ((gradePointAvg >= 3.0 && testScore >= 60)

            || (gradePointAvg < 3.0 && testScore >= 80))

            {

                accepted = true;

            }

            // Display and running total based on qualification

            if (accepted)

            {

                totalAccepted++;

                lblTotalAccepted.Text = "Total Accepted: " + totalAccepted;

                MessageBox.Show("Application Accepted");

            }

            else

            {

                totalRejected++;

                lblTotalRejected.Text = "Total Rejected: " + totalRejected;

                MessageBox.Show("Application Rejected");

            }

        }

    }

}