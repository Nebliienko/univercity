namespace MoneySimulator
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.studyGroupBox = new System.Windows.Forms.GroupBox();
            this.studyLevel8 = new System.Windows.Forms.Button();
            this.studyLevel7 = new System.Windows.Forms.Button();
            this.studyLevel6 = new System.Windows.Forms.Button();
            this.studyLevel5 = new System.Windows.Forms.Button();
            this.studyLevel2 = new System.Windows.Forms.Button();
            this.studyLevel4 = new System.Windows.Forms.Button();
            this.studyLevel1 = new System.Windows.Forms.Button();
            this.studyLevel3 = new System.Windows.Forms.Button();
            this.workGroupBox = new System.Windows.Forms.GroupBox();
            this.workLevel7 = new System.Windows.Forms.Button();
            this.workLevel6 = new System.Windows.Forms.Button();
            this.workLevel5 = new System.Windows.Forms.Button();
            this.workLevel4 = new System.Windows.Forms.Button();
            this.workLevel3 = new System.Windows.Forms.Button();
            this.workLevel2 = new System.Windows.Forms.Button();
            this.workLevel1 = new System.Windows.Forms.Button();
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.bussinessLevel3 = new System.Windows.Forms.Button();
            this.coursesLevel3 = new System.Windows.Forms.Button();
            this.bussinessLevel2 = new System.Windows.Forms.Button();
            this.coursesLevel2 = new System.Windows.Forms.Button();
            this.bussinessLevel1 = new System.Windows.Forms.Button();
            this.coursesLevel1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.realtyGroupBox = new System.Windows.Forms.GroupBox();
            this.realtyLevel6 = new System.Windows.Forms.Button();
            this.realtyLevel5 = new System.Windows.Forms.Button();
            this.realtyLevel4 = new System.Windows.Forms.Button();
            this.realtyLevel3 = new System.Windows.Forms.Button();
            this.realtyLevel2 = new System.Windows.Forms.Button();
            this.realtyLevel1 = new System.Windows.Forms.Button();
            this.realtyLevel7 = new System.Windows.Forms.Button();
            this.incomeWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.incomeTimer = new System.Windows.Forms.Timer(this.components);
            this.dateWorker = new System.ComponentModel.BackgroundWorker();
            this.educationProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.studyGroupBox.SuspendLayout();
            this.workGroupBox.SuspendLayout();
            this.coursesGroupBox.SuspendLayout();
            this.realtyGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.dateLabel);
            this.userGroupBox.Controls.Add(this.moneyLabel);
            this.userGroupBox.Controls.Add(this.nameLabel);
            this.userGroupBox.Controls.Add(this.userPicture);
            this.userGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(203, 168);
            this.userGroupBox.TabIndex = 4;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "Profile";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(125, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(61, 13);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "27.11.2014";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(122, 51);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(22, 13);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "0 $";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(122, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "User";
            // 
            // userPicture
            // 
            this.userPicture.ImageLocation = "pic.jpg";
            this.userPicture.Location = new System.Drawing.Point(6, 19);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(110, 129);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 4;
            this.userPicture.TabStop = false;
            // 
            // studyGroupBox
            // 
            this.studyGroupBox.Controls.Add(this.studyLevel8);
            this.studyGroupBox.Controls.Add(this.studyLevel7);
            this.studyGroupBox.Controls.Add(this.studyLevel6);
            this.studyGroupBox.Controls.Add(this.studyLevel5);
            this.studyGroupBox.Controls.Add(this.studyLevel2);
            this.studyGroupBox.Controls.Add(this.studyLevel4);
            this.studyGroupBox.Controls.Add(this.studyLevel1);
            this.studyGroupBox.Controls.Add(this.studyLevel3);
            this.studyGroupBox.Location = new System.Drawing.Point(15, 191);
            this.studyGroupBox.Name = "studyGroupBox";
            this.studyGroupBox.Size = new System.Drawing.Size(199, 378);
            this.studyGroupBox.TabIndex = 5;
            this.studyGroupBox.TabStop = false;
            this.studyGroupBox.Text = "Study";
            // 
            // studyLevel8
            // 
            this.studyLevel8.Enabled = false;
            this.studyLevel8.Location = new System.Drawing.Point(6, 334);
            this.studyLevel8.Name = "studyLevel8";
            this.studyLevel8.Size = new System.Drawing.Size(187, 39);
            this.studyLevel8.TabIndex = 13;
            this.studyLevel8.Text = "Doctorate (25000$)";
            this.studyLevel8.UseVisualStyleBackColor = true;
            this.studyLevel8.Click += new System.EventHandler(this.studyLevel8_Click);
            // 
            // studyLevel7
            // 
            this.studyLevel7.Enabled = false;
            this.studyLevel7.Location = new System.Drawing.Point(6, 289);
            this.studyLevel7.Name = "studyLevel7";
            this.studyLevel7.Size = new System.Drawing.Size(187, 39);
            this.studyLevel7.TabIndex = 12;
            this.studyLevel7.Text = "Postgraduate studies (10000$)";
            this.studyLevel7.UseVisualStyleBackColor = true;
            this.studyLevel7.Click += new System.EventHandler(this.studyLevel7_Click);
            // 
            // studyLevel6
            // 
            this.studyLevel6.Enabled = false;
            this.studyLevel6.Location = new System.Drawing.Point(6, 244);
            this.studyLevel6.Name = "studyLevel6";
            this.studyLevel6.Size = new System.Drawing.Size(187, 39);
            this.studyLevel6.TabIndex = 11;
            this.studyLevel6.Text = "University (5000$)";
            this.studyLevel6.UseVisualStyleBackColor = true;
            this.studyLevel6.Click += new System.EventHandler(this.studyLevel6_Click);
            // 
            // studyLevel5
            // 
            this.studyLevel5.Enabled = false;
            this.studyLevel5.Location = new System.Drawing.Point(6, 199);
            this.studyLevel5.Name = "studyLevel5";
            this.studyLevel5.Size = new System.Drawing.Size(187, 39);
            this.studyLevel5.TabIndex = 10;
            this.studyLevel5.Text = "Technical school (3000$)";
            this.studyLevel5.UseVisualStyleBackColor = true;
            this.studyLevel5.Click += new System.EventHandler(this.studyLevel5_Click);
            // 
            // studyLevel2
            // 
            this.studyLevel2.Enabled = false;
            this.studyLevel2.Location = new System.Drawing.Point(6, 64);
            this.studyLevel2.Name = "studyLevel2";
            this.studyLevel2.Size = new System.Drawing.Size(187, 39);
            this.studyLevel2.TabIndex = 7;
            this.studyLevel2.Text = "School (100$)";
            this.studyLevel2.UseVisualStyleBackColor = true;
            this.studyLevel2.Click += new System.EventHandler(this.studyLevel2_Click);
            // 
            // studyLevel4
            // 
            this.studyLevel4.Enabled = false;
            this.studyLevel4.Location = new System.Drawing.Point(6, 154);
            this.studyLevel4.Name = "studyLevel4";
            this.studyLevel4.Size = new System.Drawing.Size(187, 39);
            this.studyLevel4.TabIndex = 9;
            this.studyLevel4.Text = "High school (1000$)";
            this.studyLevel4.UseVisualStyleBackColor = true;
            this.studyLevel4.Click += new System.EventHandler(this.studyLevel4_Click);
            // 
            // studyLevel1
            // 
            this.studyLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.studyLevel1.Location = new System.Drawing.Point(6, 19);
            this.studyLevel1.Name = "studyLevel1";
            this.studyLevel1.Size = new System.Drawing.Size(187, 39);
            this.studyLevel1.TabIndex = 6;
            this.studyLevel1.Text = "Basics (0$)";
            this.studyLevel1.UseVisualStyleBackColor = false;
            this.studyLevel1.Click += new System.EventHandler(this.studyLevel1_Click);
            // 
            // studyLevel3
            // 
            this.studyLevel3.Enabled = false;
            this.studyLevel3.Location = new System.Drawing.Point(6, 109);
            this.studyLevel3.Name = "studyLevel3";
            this.studyLevel3.Size = new System.Drawing.Size(187, 39);
            this.studyLevel3.TabIndex = 8;
            this.studyLevel3.Text = "Middle school (500$)";
            this.studyLevel3.UseVisualStyleBackColor = true;
            this.studyLevel3.Click += new System.EventHandler(this.studyLevel3_Click);
            // 
            // workGroupBox
            // 
            this.workGroupBox.Controls.Add(this.workLevel7);
            this.workGroupBox.Controls.Add(this.workLevel6);
            this.workGroupBox.Controls.Add(this.workLevel5);
            this.workGroupBox.Controls.Add(this.workLevel4);
            this.workGroupBox.Controls.Add(this.workLevel3);
            this.workGroupBox.Controls.Add(this.workLevel2);
            this.workGroupBox.Controls.Add(this.workLevel1);
            this.workGroupBox.Location = new System.Drawing.Point(222, 13);
            this.workGroupBox.Name = "workGroupBox";
            this.workGroupBox.Size = new System.Drawing.Size(236, 366);
            this.workGroupBox.TabIndex = 6;
            this.workGroupBox.TabStop = false;
            this.workGroupBox.Text = "Work";
            // 
            // workLevel7
            // 
            this.workLevel7.Enabled = false;
            this.workLevel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workLevel7.Location = new System.Drawing.Point(4, 314);
            this.workLevel7.Name = "workLevel7";
            this.workLevel7.Size = new System.Drawing.Size(225, 43);
            this.workLevel7.TabIndex = 9;
            this.workLevel7.Text = "Senator [+5000$]";
            this.workLevel7.UseVisualStyleBackColor = true;
            this.workLevel7.Click += new System.EventHandler(this.workLevel7_Click);
            // 
            // workLevel6
            // 
            this.workLevel6.Enabled = false;
            this.workLevel6.Location = new System.Drawing.Point(4, 265);
            this.workLevel6.Name = "workLevel6";
            this.workLevel6.Size = new System.Drawing.Size(225, 43);
            this.workLevel6.TabIndex = 8;
            this.workLevel6.Text = "Politician [+2500$]";
            this.workLevel6.UseVisualStyleBackColor = true;
            this.workLevel6.Click += new System.EventHandler(this.workLevel6_Click);
            // 
            // workLevel5
            // 
            this.workLevel5.Enabled = false;
            this.workLevel5.Location = new System.Drawing.Point(4, 216);
            this.workLevel5.Name = "workLevel5";
            this.workLevel5.Size = new System.Drawing.Size(225, 43);
            this.workLevel5.TabIndex = 7;
            this.workLevel5.Text = "Director [+1000$]";
            this.workLevel5.UseVisualStyleBackColor = true;
            this.workLevel5.Click += new System.EventHandler(this.workLevel5_Click);
            // 
            // workLevel4
            // 
            this.workLevel4.Enabled = false;
            this.workLevel4.Location = new System.Drawing.Point(5, 167);
            this.workLevel4.Name = "workLevel4";
            this.workLevel4.Size = new System.Drawing.Size(225, 43);
            this.workLevel4.TabIndex = 6;
            this.workLevel4.Text = "Manager [+250$]";
            this.workLevel4.UseVisualStyleBackColor = true;
            this.workLevel4.Click += new System.EventHandler(this.workLevel4_Click);
            // 
            // workLevel3
            // 
            this.workLevel3.Enabled = false;
            this.workLevel3.Location = new System.Drawing.Point(5, 118);
            this.workLevel3.Name = "workLevel3";
            this.workLevel3.Size = new System.Drawing.Size(225, 43);
            this.workLevel3.TabIndex = 5;
            this.workLevel3.Text = "Vender [+100$]";
            this.workLevel3.UseVisualStyleBackColor = true;
            this.workLevel3.Click += new System.EventHandler(this.workLevel3_Click);
            // 
            // workLevel2
            // 
            this.workLevel2.Enabled = false;
            this.workLevel2.Location = new System.Drawing.Point(4, 69);
            this.workLevel2.Name = "workLevel2";
            this.workLevel2.Size = new System.Drawing.Size(225, 43);
            this.workLevel2.TabIndex = 4;
            this.workLevel2.Text = "Cashier [+50$]";
            this.workLevel2.UseVisualStyleBackColor = true;
            this.workLevel2.Click += new System.EventHandler(this.workLevel2_Click);
            // 
            // workLevel1
            // 
            this.workLevel1.Location = new System.Drawing.Point(4, 20);
            this.workLevel1.Name = "workLevel1";
            this.workLevel1.Size = new System.Drawing.Size(225, 43);
            this.workLevel1.TabIndex = 1;
            this.workLevel1.Text = "Cleaner [+10$]";
            this.workLevel1.UseVisualStyleBackColor = true;
            this.workLevel1.Click += new System.EventHandler(this.workLevel1_Click);
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.Controls.Add(this.bussinessLevel3);
            this.coursesGroupBox.Controls.Add(this.coursesLevel3);
            this.coursesGroupBox.Controls.Add(this.bussinessLevel2);
            this.coursesGroupBox.Controls.Add(this.coursesLevel2);
            this.coursesGroupBox.Controls.Add(this.bussinessLevel1);
            this.coursesGroupBox.Controls.Add(this.coursesLevel1);
            this.coursesGroupBox.Controls.Add(this.progressBar);
            this.coursesGroupBox.Location = new System.Drawing.Point(222, 385);
            this.coursesGroupBox.Name = "coursesGroupBox";
            this.coursesGroupBox.Size = new System.Drawing.Size(480, 184);
            this.coursesGroupBox.TabIndex = 7;
            this.coursesGroupBox.TabStop = false;
            this.coursesGroupBox.Text = "Courses and bussiness";
            // 
            // bussinessLevel3
            // 
            this.bussinessLevel3.Enabled = false;
            this.bussinessLevel3.Location = new System.Drawing.Point(245, 106);
            this.bussinessLevel3.Name = "bussinessLevel3";
            this.bussinessLevel3.Size = new System.Drawing.Size(228, 36);
            this.bussinessLevel3.TabIndex = 6;
            this.bussinessLevel3.Text = "Hotel (100000$) [+2500$]";
            this.bussinessLevel3.UseVisualStyleBackColor = true;
            this.bussinessLevel3.Click += new System.EventHandler(this.bussinessLevel3_Click);
            // 
            // coursesLevel3
            // 
            this.coursesLevel3.Enabled = false;
            this.coursesLevel3.Location = new System.Drawing.Point(6, 106);
            this.coursesLevel3.Name = "coursesLevel3";
            this.coursesLevel3.Size = new System.Drawing.Size(228, 36);
            this.coursesLevel3.TabIndex = 5;
            this.coursesLevel3.Text = "Charity (75000$) [income +20%]";
            this.coursesLevel3.UseVisualStyleBackColor = true;
            this.coursesLevel3.Click += new System.EventHandler(this.coursesLevel3_Click);
            // 
            // bussinessLevel2
            // 
            this.bussinessLevel2.Enabled = false;
            this.bussinessLevel2.Location = new System.Drawing.Point(245, 64);
            this.bussinessLevel2.Name = "bussinessLevel2";
            this.bussinessLevel2.Size = new System.Drawing.Size(228, 36);
            this.bussinessLevel2.TabIndex = 4;
            this.bussinessLevel2.Text = "Restraunt (50000$) [+1000$]";
            this.bussinessLevel2.UseVisualStyleBackColor = true;
            this.bussinessLevel2.Click += new System.EventHandler(this.bussinessLevel2_Click);
            // 
            // coursesLevel2
            // 
            this.coursesLevel2.Enabled = false;
            this.coursesLevel2.Location = new System.Drawing.Point(6, 64);
            this.coursesLevel2.Name = "coursesLevel2";
            this.coursesLevel2.Size = new System.Drawing.Size(228, 36);
            this.coursesLevel2.TabIndex = 3;
            this.coursesLevel2.Text = "Communications (25000$) [income x1,2]";
            this.coursesLevel2.UseVisualStyleBackColor = true;
            this.coursesLevel2.Click += new System.EventHandler(this.coursesLevel2_Click);
            // 
            // bussinessLevel1
            // 
            this.bussinessLevel1.Enabled = false;
            this.bussinessLevel1.Location = new System.Drawing.Point(245, 22);
            this.bussinessLevel1.Name = "bussinessLevel1";
            this.bussinessLevel1.Size = new System.Drawing.Size(228, 36);
            this.bussinessLevel1.TabIndex = 2;
            this.bussinessLevel1.Text = "Cafe (10000$) [+100$]";
            this.bussinessLevel1.UseVisualStyleBackColor = true;
            this.bussinessLevel1.Click += new System.EventHandler(this.bussinessLevel1_Click);
            // 
            // coursesLevel1
            // 
            this.coursesLevel1.Enabled = false;
            this.coursesLevel1.Location = new System.Drawing.Point(6, 23);
            this.coursesLevel1.Name = "coursesLevel1";
            this.coursesLevel1.Size = new System.Drawing.Size(228, 35);
            this.coursesLevel1.TabIndex = 1;
            this.coursesLevel1.Text = "Tranings (5000$) [income x1,1]";
            this.coursesLevel1.UseVisualStyleBackColor = true;
            this.coursesLevel1.Click += new System.EventHandler(this.coursesLevel1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 148);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(467, 30);
            this.progressBar.TabIndex = 0;
            // 
            // realtyGroupBox
            // 
            this.realtyGroupBox.Controls.Add(this.realtyLevel6);
            this.realtyGroupBox.Controls.Add(this.realtyLevel5);
            this.realtyGroupBox.Controls.Add(this.realtyLevel4);
            this.realtyGroupBox.Controls.Add(this.realtyLevel3);
            this.realtyGroupBox.Controls.Add(this.realtyLevel2);
            this.realtyGroupBox.Controls.Add(this.realtyLevel1);
            this.realtyGroupBox.Location = new System.Drawing.Point(464, 13);
            this.realtyGroupBox.Name = "realtyGroupBox";
            this.realtyGroupBox.Size = new System.Drawing.Size(238, 366);
            this.realtyGroupBox.TabIndex = 8;
            this.realtyGroupBox.TabStop = false;
            this.realtyGroupBox.Text = "Realty";
            // 
            // realtyLevel6
            // 
            this.realtyLevel6.Enabled = false;
            this.realtyLevel6.Location = new System.Drawing.Point(6, 265);
            this.realtyLevel6.Name = "realtyLevel6";
            this.realtyLevel6.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel6.TabIndex = 5;
            this.realtyLevel6.Text = "Helicopter (50000$)";
            this.realtyLevel6.UseVisualStyleBackColor = true;
            this.realtyLevel6.Click += new System.EventHandler(this.realtyLevel6_Click);
            // 
            // realtyLevel5
            // 
            this.realtyLevel5.Enabled = false;
            this.realtyLevel5.Location = new System.Drawing.Point(6, 216);
            this.realtyLevel5.Name = "realtyLevel5";
            this.realtyLevel5.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel5.TabIndex = 4;
            this.realtyLevel5.Text = "Automobile (15000$)";
            this.realtyLevel5.UseVisualStyleBackColor = true;
            this.realtyLevel5.Click += new System.EventHandler(this.realtyLevel5_Click);
            // 
            // realtyLevel4
            // 
            this.realtyLevel4.Enabled = false;
            this.realtyLevel4.Location = new System.Drawing.Point(7, 167);
            this.realtyLevel4.Name = "realtyLevel4";
            this.realtyLevel4.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel4.TabIndex = 3;
            this.realtyLevel4.Text = "House (10000$)";
            this.realtyLevel4.UseVisualStyleBackColor = true;
            this.realtyLevel4.Click += new System.EventHandler(this.realtyLevel4_Click);
            // 
            // realtyLevel3
            // 
            this.realtyLevel3.Enabled = false;
            this.realtyLevel3.Location = new System.Drawing.Point(7, 118);
            this.realtyLevel3.Name = "realtyLevel3";
            this.realtyLevel3.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel3.TabIndex = 2;
            this.realtyLevel3.Text = "Motorcycle (3000$)";
            this.realtyLevel3.UseVisualStyleBackColor = true;
            this.realtyLevel3.Click += new System.EventHandler(this.realtyLevel3_Click);
            // 
            // realtyLevel2
            // 
            this.realtyLevel2.Enabled = false;
            this.realtyLevel2.Location = new System.Drawing.Point(6, 69);
            this.realtyLevel2.Name = "realtyLevel2";
            this.realtyLevel2.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel2.TabIndex = 1;
            this.realtyLevel2.Text = "Bycicle (1500$)";
            this.realtyLevel2.UseVisualStyleBackColor = true;
            this.realtyLevel2.Click += new System.EventHandler(this.realtyLevel2_Click);
            // 
            // realtyLevel1
            // 
            this.realtyLevel1.Location = new System.Drawing.Point(7, 20);
            this.realtyLevel1.Name = "realtyLevel1";
            this.realtyLevel1.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel1.TabIndex = 0;
            this.realtyLevel1.Text = "Room (1000$)";
            this.realtyLevel1.UseVisualStyleBackColor = true;
            this.realtyLevel1.Click += new System.EventHandler(this.realtyLevel1_Click);
            // 
            // realtyLevel7
            // 
            this.realtyLevel7.Enabled = false;
            this.realtyLevel7.Location = new System.Drawing.Point(470, 327);
            this.realtyLevel7.Name = "realtyLevel7";
            this.realtyLevel7.Size = new System.Drawing.Size(225, 43);
            this.realtyLevel7.TabIndex = 6;
            this.realtyLevel7.Text = "Mansion (100000$)";
            this.realtyLevel7.UseVisualStyleBackColor = true;
            this.realtyLevel7.Click += new System.EventHandler(this.realtyLevel7_Click);
            // 
            // incomeWorker
            // 
            this.incomeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.income_DoWork);
            this.incomeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.incomeWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 577);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 35);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errors";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(7, 14);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 0;
            // 
            // incomeTimer
            // 
            this.incomeTimer.Tick += new System.EventHandler(this.incomeTimer_Tick);
            // 
            // dateWorker
            // 
            this.dateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dateWorker_DoWork);
            this.dateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dateWorker_RunWorkerCompleted);
            // 
            // educationProcessWorker
            // 
            this.educationProcessWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.educationProcessWorker_DoWork);
            this.educationProcessWorker.RunWorkerCompleted +=
                new System.ComponentModel.RunWorkerCompletedEventHandler(
            educationProcessWorker_RunWorkerCompleted);
            this.educationProcessWorker.ProgressChanged +=
                new System.ComponentModel.ProgressChangedEventHandler(
            educationProcessWorker_ProgressChanged);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.realtyLevel7);
            this.Controls.Add(this.realtyGroupBox);
            this.Controls.Add(this.coursesGroupBox);
            this.Controls.Add(this.workGroupBox);
            this.Controls.Add(this.studyGroupBox);
            this.Controls.Add(this.userGroupBox);
            this.Name = "ApplicationForm";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.studyGroupBox.ResumeLayout(false);
            this.workGroupBox.ResumeLayout(false);
            this.coursesGroupBox.ResumeLayout(false);
            this.realtyGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.GroupBox studyGroupBox;
        private System.Windows.Forms.GroupBox workGroupBox;
        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.GroupBox realtyGroupBox;
        private System.Windows.Forms.Button realtyLevel6;
        private System.Windows.Forms.Button realtyLevel5;
        private System.Windows.Forms.Button realtyLevel4;
        private System.Windows.Forms.Button realtyLevel3;
        private System.Windows.Forms.Button realtyLevel2;
        private System.Windows.Forms.Button realtyLevel1;
        private System.Windows.Forms.Button realtyLevel7;
        private System.Windows.Forms.Button studyLevel8;
        private System.Windows.Forms.Button studyLevel7;
        private System.Windows.Forms.Button studyLevel6;
        private System.Windows.Forms.Button studyLevel5;
        private System.Windows.Forms.Button studyLevel2;
        private System.Windows.Forms.Button studyLevel4;
        private System.Windows.Forms.Button studyLevel1;
        private System.Windows.Forms.Button studyLevel3;
        private System.Windows.Forms.Button bussinessLevel2;
        private System.Windows.Forms.Button coursesLevel2;
        private System.Windows.Forms.Button bussinessLevel1;
        private System.Windows.Forms.Button coursesLevel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bussinessLevel3;
        private System.Windows.Forms.Button coursesLevel3;
        private System.Windows.Forms.Button workLevel7;
        private System.Windows.Forms.Button workLevel6;
        private System.Windows.Forms.Button workLevel5;
        private System.Windows.Forms.Button workLevel4;
        private System.Windows.Forms.Button workLevel3;
        private System.Windows.Forms.Button workLevel2;
        private System.Windows.Forms.Button workLevel1;
        private System.ComponentModel.BackgroundWorker incomeWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Timer incomeTimer;
        private System.ComponentModel.BackgroundWorker dateWorker;
        private System.ComponentModel.BackgroundWorker educationProcessWorker;

    }
}

