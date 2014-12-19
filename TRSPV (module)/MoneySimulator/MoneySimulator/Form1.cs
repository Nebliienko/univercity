using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MoneySimulator
{
    public partial class ApplicationForm : Form
    {
        private const string LOW_STUDY_LVL = "You need better education";
        private const string LOW_REALTY_LVL = "You need better realty";
        private const string LOW_WORK_LVL = "You need better work";
        private const string LOW_MONEY_LVL = "You have no enough money";
        private const string EDUCATION_IS_IN_PROCESS = "Education is in progess right now";

        public User UserProfile { get; set; }
        private int educationProcess = 0;

        public ApplicationForm()
        {
            InitializeComponent();
            UserProfile = new User();
            NameDialogBox box = new NameDialogBox(this);
            box.ShowDialog(this);

            dateLabel.Text = UserProfile.Date.ToShortDateString();

            incomeTimer.Interval = 1000;
            incomeTimer.Start();
        }

        ///////////
        // STUDY //
        ///////////

        private void studyLevel1_Click(object sender, EventArgs e)
        {
            workLevel1.Enabled = true;
            realtyLevel1.Enabled = true;
            invokeButtonClick(studyLevel1);
            studyLevel2.Enabled = true;
            UserProfile.StudyLevel = 1;
        }

        private void studyLevel2_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(100))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(studyLevel2);
            studyLevel3.Enabled = true;
            UserProfile.StudyLevel = 2;
            withdrowMoney(100);
        }

        private void studyLevel3_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(500))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(studyLevel3);
            studyLevel4.Enabled = true;
            UserProfile.StudyLevel = 3;
            withdrowMoney(500);
        }

        private void studyLevel4_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(1000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            if (UserProfile.RealtyLevel < 1)
            {
                printError("You need room to live somewhere");
                return;
            }
            invokeButtonClick(studyLevel4);
            studyLevel5.Enabled = true;
            UserProfile.StudyLevel = 4;
            withdrowMoney(1000);
        }

        private void studyLevel5_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(3000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            if (UserProfile.RealtyLevel < 2)
            {
                printError("You need bycicle to reach the placement");
                return;
            }
            invokeButtonClick(studyLevel5);
            studyLevel6.Enabled = true;
            UserProfile.StudyLevel = 5;
            withdrowMoney(3000);
        }

        private void studyLevel6_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(5000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            if (UserProfile.RealtyLevel < 3)
            {
                printError("You need motorcycle to reach the placement");
                return;
            }
            invokeButtonClick(studyLevel6);
            studyLevel7.Enabled = true;
            UserProfile.StudyLevel = 6;
            withdrowMoney(5000);
        }

        private void studyLevel7_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(10000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            if (UserProfile.RealtyLevel < 4)
            {
                printError("You need house to get a technical education");
                return;
            }
            if (UserProfile.RealtyLevel < 5)
            {
                printError("It`s too far. You need a car to reach it.");
                return;
            }
            invokeButtonClick(studyLevel7);
            studyLevel8.Enabled = true;
            UserProfile.StudyLevel = 7;
            withdrowMoney(10000);
        }

        private void studyLevel8_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(25000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(studyLevel8);
            UserProfile.StudyLevel = 8;
            withdrowMoney(25000);
        }

        ///////////
        // WORK  //
        ///////////

        private void workLevel1_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 1)
            {
                printError(LOW_STUDY_LVL);
                return;
            }
            invokeButtonClick(workLevel1);
            workLevel2.Enabled = true;
            UserProfile.Income += 10;
            UserProfile.WorkLevel = 1;
        }

        private void workLevel2_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 2)
            {
                printError("At least end the school to get better job");
                return;
            }
            invokeButtonClick(workLevel2);
            workLevel3.Enabled = true;
            UserProfile.Income += 40;
            UserProfile.WorkLevel = 2;
        }

        private void workLevel3_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 4)
            {
                printError(LOW_STUDY_LVL);
                return;
            }
            if (UserProfile.RealtyLevel < 1)
            {
                if (UserProfile.RealtyLevel < 2)
                {
                    printError("You need at least bycicle to reach this job!");
                    return;
                }
                printError("You need a room to work on this job!");
                return;
            }
            invokeButtonClick(workLevel3);
            workLevel4.Enabled = true;
            coursesLevel1.Enabled = true;
            UserProfile.Income += 50;
            UserProfile.WorkLevel = 3;
        }

        private void workLevel4_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 5)
            {
                printError("You need special education to work here");
                return;
            }
            if (UserProfile.RealtyLevel < 3)
            {
                printError("Buy motocycle to reach the placement");
                return;
            }
            invokeButtonClick(workLevel4);
            workLevel5.Enabled = true;
            UserProfile.Income += 150;
            UserProfile.WorkLevel = 4;
        }

        private void workLevel5_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 6)
            {
                printError("Finish univercity please...");
                return;
            }
            if (UserProfile.RealtyLevel < 4)
            {
                printError("It`s time to get a house, dont you think?");
                return;
            }
            invokeButtonClick(workLevel5);
            workLevel6.Enabled = true;
            coursesLevel2.Enabled = true;
            UserProfile.Income += 750;
            UserProfile.WorkLevel = 5;
        }

        private void workLevel6_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 7)
            {
                printError("You wanna be politian or what? Upgrade your education at last!");
                return;
            }
            if (UserProfile.RealtyLevel < 5)
            {
                printError("How do you wanna be politician with no automobile?");
                return;
            }
            invokeButtonClick(workLevel6);
            workLevel7.Enabled = true;
            coursesLevel3.Enabled = true;
            UserProfile.Income += 1500;
            UserProfile.WorkLevel = 6;
        }

        private void workLevel7_Click(object sender, EventArgs e)
        {
            if (UserProfile.StudyLevel < 8)
            {
                printError("Stop kidding me!");
                return;
            }
            if (UserProfile.RealtyLevel < 7)
            {
                printError("I dont believe you can be senator without your own mansion");
                return;
            }
            invokeButtonClick(workLevel7);
            UserProfile.Income += 2500;
            UserProfile.WorkLevel = 7;
        }


        ////////////
        // REALTY //
        ////////////

        private void realtyLevel1_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(1000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel1);
            realtyLevel2.Enabled = true;
            UserProfile.RealtyLevel = 1;
            withdrowMoney(1000);
        }
        private void realtyLevel2_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(1500))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel2);
            realtyLevel3.Enabled = true;
            UserProfile.RealtyLevel = 2;
            withdrowMoney(1500);
        }
        private void realtyLevel3_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(3000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel3);
            realtyLevel4.Enabled = true;
            UserProfile.RealtyLevel = 3;
            withdrowMoney(3000);
        }
        private void realtyLevel4_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(10000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel4);
            realtyLevel5.Enabled = true;
            UserProfile.RealtyLevel = 4;
            withdrowMoney(10000);
        }
        private void realtyLevel5_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(15000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel5);
            realtyLevel6.Enabled = true;
            UserProfile.RealtyLevel = 5;
            withdrowMoney(15000);
        }
        private void realtyLevel6_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(50000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel6);
            realtyLevel7.Enabled = true;
            UserProfile.RealtyLevel = 6;
            withdrowMoney(50000);
        }
        private void realtyLevel7_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(100000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(realtyLevel7);
            UserProfile.RealtyLevel = 7;
            withdrowMoney(100000);
        }

        /////////////
        // COURSES //
        /////////////

        private void coursesLevel1_Click(object sender, EventArgs e)
        {
            if (educationProcessWorker.IsBusy)
            {
                printError(EDUCATION_IS_IN_PROCESS);
                return;
            }
            if (!enoughMoney(5000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            withdrowMoney(5000);
            invokeButtonClick(coursesLevel1);
            UserProfile.CoursesLevel = 1;
            bussinessLevel1.Enabled = true;
            educationProcessWorker.RunWorkerAsync(10);
        }

        private void coursesLevel2_Click(object sender, EventArgs e)
        {
            if (educationProcessWorker.IsBusy)
            {
                printError(EDUCATION_IS_IN_PROCESS);
                return;
            }
            if (!enoughMoney(25000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(coursesLevel2);
            UserProfile.CoursesLevel = 2;
            bussinessLevel2.Enabled = true;
            withdrowMoney(25000);
            educationProcessWorker.RunWorkerAsync(5);
        }

        private void coursesLevel3_Click(object sender, EventArgs e)
        {
            if (educationProcessWorker.IsBusy)
            {
                printError(EDUCATION_IS_IN_PROCESS);
                return;
            }
            if (!enoughMoney(75000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(coursesLevel3);
            UserProfile.CoursesLevel = 3;
            bussinessLevel3.Enabled = true;
            withdrowMoney(75000);
            educationProcessWorker.RunWorkerAsync(2);
        }

        private void bussinessLevel1_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(10000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(bussinessLevel1);
            UserProfile.BussinessLevel = 1;
            UserProfile.Income += 100;
            withdrowMoney(10000);
        }
        private void bussinessLevel2_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(50000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(bussinessLevel2);
            UserProfile.BussinessLevel = 2;
            UserProfile.Income += 1000;
            withdrowMoney(50000);
        }
        private void bussinessLevel3_Click(object sender, EventArgs e)
        {
            if (!enoughMoney(100000))
            {
                printError(LOW_MONEY_LVL);
                return;
            }
            invokeButtonClick(bussinessLevel3);
            UserProfile.BussinessLevel = 3;
            UserProfile.Income += 2500;
            withdrowMoney(100000);
        }



        ///////////
        // TIMER //
        ///////////


        private void income_DoWork(object sender, DoWorkEventArgs e)
        {
            UserProfile.Money += (int)(UserProfile.Income * UserProfile.IncomeMultiplier);
        }

        private void incomeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            printMoney();
            if (UserProfile.Money > 500000)
            {
                incomeTimer.Stop();
                MessageBox.Show("You won!");
                this.Close();
            }
            if (UserProfile.Date > new DateTime(2015, 1, 1))
            {
                incomeTimer.Stop();
                MessageBox.Show("You lost!");
                this.Close();
            }
        }

        private void dateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UserProfile.Date = UserProfile.Date.AddDays(1);
        }

        private void dateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            printDate();
        }

        private void educationProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            while (educationProcess != 100)
            {
                educationProcess += (int)e.Argument;
                worker.ReportProgress(educationProcess);
                Thread.Sleep(1000);
            }
        }

        private void educationProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void educationProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            educationProcess = 0;
            progressBar.Value = 0;
            UserProfile.IncomeMultiplier += 0.1;
        }

        private void incomeTimer_Tick(object sender, EventArgs e)
        {
            incomeWorker.RunWorkerAsync();
            dateWorker.RunWorkerAsync();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "Your main goal is to earn 500000 $ in a year. Good luck!";
        }
        ///////////
        // UTILS //
        ///////////

        public void changeName()
        {
            nameLabel.Text = UserProfile.Name;
        }

        private void withdrowMoney(int p)
        {
            UserProfile.Money -= p;
            printMoney();
        }

        private void invokeButtonClick(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.White;
            clearError();
        }

        private bool enoughMoney(int sum)
        {
            if (sum > UserProfile.Money)
                return false;
            return true;
        }

        private void printMoney()
        {
            moneyLabel.Text = UserProfile.Money.ToString() + " $";
        }

        private void printDate()
        {
            dateLabel.Text = UserProfile.Date.ToShortDateString();
        }

        private void printError(string text)
        {
            errorLabel.Text = text;
        }

        private void clearError()
        {
            errorLabel.Text = null;
        }
    }

}
