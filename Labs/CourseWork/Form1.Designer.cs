﻿namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.TextBox();
            this.Train = new System.Windows.Forms.Button();
            this.SaveRandom = new System.Windows.Forms.Button();
            this.SaveTrain = new System.Windows.Forms.Button();
            this.TrainResults = new System.Windows.Forms.DataGridView();
            this.RandomResults = new System.Windows.Forms.DataGridView();
            this.TestRandom = new System.Windows.Forms.Button();
            this.TestTrain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinError1 = new System.Windows.Forms.TextBox();
            this.Momentum = new System.Windows.Forms.TextBox();
            this.Learning_rate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hidden_Neurons = new System.Windows.Forms.TextBox();
            this.CreateBackProp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TrainLVQNetwork = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SaveGeneratedLVQ = new System.Windows.Forms.Button();
            this.SaveTrainLVQ = new System.Windows.Forms.Button();
            this.TrainResultsLVQ = new System.Windows.Forms.DataGridView();
            this.GeneratedResultsLVQ = new System.Windows.Forms.DataGridView();
            this.TestGeneratedLVQ = new System.Windows.Forms.Button();
            this.TestTrainLVQ = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DecayRateLVQ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MinErrorLVQ = new System.Windows.Forms.TextBox();
            this.LearningRateLVQ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeLVQ = new System.Windows.Forms.TextBox();
            this.TrainLVQ = new System.Windows.Forms.Button();
            this.SaveLVQ = new System.Windows.Forms.Button();
            this.DownLoadLVQ = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.testAmountText = new System.Windows.Forms.TextBox();
            this.DownloadFromDB = new System.Windows.Forms.Button();
            this.GenerateRandom = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveResultsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog4 = new System.Windows.Forms.SaveFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Graph = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResultsLVQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedResultsLVQ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 146);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Time1);
            this.tabPage1.Controls.Add(this.Train);
            this.tabPage1.Controls.Add(this.SaveRandom);
            this.tabPage1.Controls.Add(this.SaveTrain);
            this.tabPage1.Controls.Add(this.TrainResults);
            this.tabPage1.Controls.Add(this.RandomResults);
            this.tabPage1.Controls.Add(this.TestRandom);
            this.tabPage1.Controls.Add(this.TestTrain);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MinError1);
            this.tabPage1.Controls.Add(this.Momentum);
            this.tabPage1.Controls.Add(this.Learning_rate1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Hidden_Neurons);
            this.tabPage1.Controls.Add(this.CreateBackProp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1268, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Мережа BackPropagation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(912, 77);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(2, 243);
            this.label19.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(356, 77);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2, 243);
            this.label18.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(27, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(690, 35);
            this.label17.TabIndex = 29;
            this.label17.Text = "Завантажте з файла або створіть мережу:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(226, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 74);
            this.label2.TabIndex = 28;
            this.label2.Text = "Зберегти мережу";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 66);
            this.label1.TabIndex = 27;
            this.label1.Text = "Завантажити мережу";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork.Properties.Resources.save_icon;
            this.pictureBox2.Location = new System.Drawing.Point(231, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 106);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(60, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 108);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(988, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Час навчання мережі";
            // 
            // Time1
            // 
            this.Time1.Location = new System.Drawing.Point(993, 192);
            this.Time1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            this.Time1.Size = new System.Drawing.Size(163, 26);
            this.Time1.TabIndex = 23;
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(944, 260);
            this.Train.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(264, 60);
            this.Train.TabIndex = 22;
            this.Train.Text = "Навчити мережу";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // SaveRandom
            // 
            this.SaveRandom.Location = new System.Drawing.Point(958, 685);
            this.SaveRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveRandom.Name = "SaveRandom";
            this.SaveRandom.Size = new System.Drawing.Size(264, 57);
            this.SaveRandom.TabIndex = 20;
            this.SaveRandom.Text = "Зберегти результати для тестової вибірки";
            this.SaveRandom.UseVisualStyleBackColor = true;
            this.SaveRandom.Click += new System.EventHandler(this.SaveRandom_Click);
            // 
            // SaveTrain
            // 
            this.SaveTrain.Location = new System.Drawing.Point(345, 685);
            this.SaveTrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveTrain.Name = "SaveTrain";
            this.SaveTrain.Size = new System.Drawing.Size(264, 57);
            this.SaveTrain.TabIndex = 19;
            this.SaveTrain.Text = "Зберегти результати для навч. вибірки";
            this.SaveTrain.UseVisualStyleBackColor = true;
            this.SaveTrain.Click += new System.EventHandler(this.SaveTrain_Click);
            // 
            // TrainResults
            // 
            this.TrainResults.AllowUserToAddRows = false;
            this.TrainResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainResults.Location = new System.Drawing.Point(42, 420);
            this.TrainResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainResults.Name = "TrainResults";
            this.TrainResults.RowHeadersWidth = 62;
            this.TrainResults.Size = new System.Drawing.Size(567, 242);
            this.TrainResults.TabIndex = 18;
            // 
            // RandomResults
            // 
            this.RandomResults.AllowUserToAddRows = false;
            this.RandomResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandomResults.Location = new System.Drawing.Point(656, 420);
            this.RandomResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RandomResults.Name = "RandomResults";
            this.RandomResults.RowHeadersWidth = 62;
            this.RandomResults.Size = new System.Drawing.Size(567, 242);
            this.RandomResults.TabIndex = 15;
            // 
            // TestRandom
            // 
            this.TestRandom.Location = new System.Drawing.Point(651, 685);
            this.TestRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestRandom.Name = "TestRandom";
            this.TestRandom.Size = new System.Drawing.Size(264, 57);
            this.TestRandom.TabIndex = 14;
            this.TestRandom.Text = "Перевірка тестової вибірки";
            this.TestRandom.UseVisualStyleBackColor = true;
            this.TestRandom.Click += new System.EventHandler(this.TestRandom_Click);
            // 
            // TestTrain
            // 
            this.TestTrain.Location = new System.Drawing.Point(38, 685);
            this.TestTrain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestTrain.Name = "TestTrain";
            this.TestTrain.Size = new System.Drawing.Size(264, 57);
            this.TestTrain.TabIndex = 13;
            this.TestTrain.Text = "Протестувати навчальну вибірку";
            this.TestTrain.UseVisualStyleBackColor = true;
            this.TestTrain.Click += new System.EventHandler(this.TestTrain_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1180, 2);
            this.label7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(388, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Мінімальна похибка";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(388, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Коефіцієнт Momentum";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(388, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Швидкість навчання мережі";
            // 
            // MinError1
            // 
            this.MinError1.Location = new System.Drawing.Point(720, 157);
            this.MinError1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinError1.Name = "MinError1";
            this.MinError1.Size = new System.Drawing.Size(148, 26);
            this.MinError1.TabIndex = 8;
            // 
            // Momentum
            // 
            this.Momentum.Location = new System.Drawing.Point(720, 117);
            this.Momentum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Momentum.Name = "Momentum";
            this.Momentum.Size = new System.Drawing.Size(148, 26);
            this.Momentum.TabIndex = 7;
            // 
            // Learning_rate1
            // 
            this.Learning_rate1.Location = new System.Drawing.Point(720, 197);
            this.Learning_rate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Learning_rate1.Name = "Learning_rate1";
            this.Learning_rate1.Size = new System.Drawing.Size(148, 26);
            this.Learning_rate1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(388, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кількість нейронів у прихованому шарі";
            // 
            // Hidden_Neurons
            // 
            this.Hidden_Neurons.Location = new System.Drawing.Point(720, 77);
            this.Hidden_Neurons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hidden_Neurons.Name = "Hidden_Neurons";
            this.Hidden_Neurons.Size = new System.Drawing.Size(148, 26);
            this.Hidden_Neurons.TabIndex = 2;
            // 
            // CreateBackProp
            // 
            this.CreateBackProp.Location = new System.Drawing.Point(388, 260);
            this.CreateBackProp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateBackProp.Name = "CreateBackProp";
            this.CreateBackProp.Size = new System.Drawing.Size(264, 60);
            this.CreateBackProp.TabIndex = 1;
            this.CreateBackProp.Text = "Створити мережу";
            this.CreateBackProp.UseVisualStyleBackColor = true;
            this.CreateBackProp.Click += new System.EventHandler(this.CreateBackProp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TrainLVQNetwork);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.SaveGeneratedLVQ);
            this.tabPage2.Controls.Add(this.SaveTrainLVQ);
            this.tabPage2.Controls.Add(this.TrainResultsLVQ);
            this.tabPage2.Controls.Add(this.GeneratedResultsLVQ);
            this.tabPage2.Controls.Add(this.TestGeneratedLVQ);
            this.tabPage2.Controls.Add(this.TestTrainLVQ);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.DecayRateLVQ);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.MinErrorLVQ);
            this.tabPage2.Controls.Add(this.LearningRateLVQ);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TimeLVQ);
            this.tabPage2.Controls.Add(this.TrainLVQ);
            this.tabPage2.Controls.Add(this.SaveLVQ);
            this.tabPage2.Controls.Add(this.DownLoadLVQ);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1268, 782);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мережа Learning Vector Quantization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TrainLVQNetwork
            // 
            this.TrainLVQNetwork.Location = new System.Drawing.Point(944, 260);
            this.TrainLVQNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainLVQNetwork.Name = "TrainLVQNetwork";
            this.TrainLVQNetwork.Size = new System.Drawing.Size(264, 60);
            this.TrainLVQNetwork.TabIndex = 50;
            this.TrainLVQNetwork.Text = "Навчити мережу";
            this.TrainLVQNetwork.UseVisualStyleBackColor = true;
            this.TrainLVQNetwork.Click += new System.EventHandler(this.TrainLVQNetwork_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(912, 77);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(2, 243);
            this.label22.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(27, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(690, 35);
            this.label21.TabIndex = 48;
            this.label21.Text = "Завантажте з файла або створіть мережу:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(226, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 74);
            this.label11.TabIndex = 47;
            this.label11.Text = "Зберегти мережу";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(60, 225);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 66);
            this.label20.TabIndex = 46;
            this.label20.Text = "Завантажити мережу";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CourseWork.Properties.Resources.save_icon;
            this.pictureBox3.Location = new System.Drawing.Point(231, 114);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 106);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CourseWork.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(60, 114);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 106);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // SaveGeneratedLVQ
            // 
            this.SaveGeneratedLVQ.Location = new System.Drawing.Point(958, 685);
            this.SaveGeneratedLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveGeneratedLVQ.Name = "SaveGeneratedLVQ";
            this.SaveGeneratedLVQ.Size = new System.Drawing.Size(264, 57);
            this.SaveGeneratedLVQ.TabIndex = 41;
            this.SaveGeneratedLVQ.Text = "Зберегти результати для тестової вибірки";
            this.SaveGeneratedLVQ.UseVisualStyleBackColor = true;
            this.SaveGeneratedLVQ.Click += new System.EventHandler(this.SaveGeneratedLVQ_Click);
            // 
            // SaveTrainLVQ
            // 
            this.SaveTrainLVQ.Location = new System.Drawing.Point(345, 685);
            this.SaveTrainLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveTrainLVQ.Name = "SaveTrainLVQ";
            this.SaveTrainLVQ.Size = new System.Drawing.Size(264, 57);
            this.SaveTrainLVQ.TabIndex = 40;
            this.SaveTrainLVQ.Text = "Зберегти результати для навч. вибірки";
            this.SaveTrainLVQ.UseVisualStyleBackColor = true;
            this.SaveTrainLVQ.Click += new System.EventHandler(this.SaveTrainLVQ_Click);
            // 
            // TrainResultsLVQ
            // 
            this.TrainResultsLVQ.AllowUserToAddRows = false;
            this.TrainResultsLVQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainResultsLVQ.Location = new System.Drawing.Point(42, 420);
            this.TrainResultsLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainResultsLVQ.Name = "TrainResultsLVQ";
            this.TrainResultsLVQ.RowHeadersWidth = 62;
            this.TrainResultsLVQ.Size = new System.Drawing.Size(567, 242);
            this.TrainResultsLVQ.TabIndex = 39;
            // 
            // GeneratedResultsLVQ
            // 
            this.GeneratedResultsLVQ.AllowUserToAddRows = false;
            this.GeneratedResultsLVQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneratedResultsLVQ.Location = new System.Drawing.Point(656, 420);
            this.GeneratedResultsLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneratedResultsLVQ.Name = "GeneratedResultsLVQ";
            this.GeneratedResultsLVQ.RowHeadersWidth = 62;
            this.GeneratedResultsLVQ.Size = new System.Drawing.Size(567, 242);
            this.GeneratedResultsLVQ.TabIndex = 38;
            // 
            // TestGeneratedLVQ
            // 
            this.TestGeneratedLVQ.Location = new System.Drawing.Point(651, 685);
            this.TestGeneratedLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestGeneratedLVQ.Name = "TestGeneratedLVQ";
            this.TestGeneratedLVQ.Size = new System.Drawing.Size(264, 57);
            this.TestGeneratedLVQ.TabIndex = 37;
            this.TestGeneratedLVQ.Text = "Перевірка тестової вибірки";
            this.TestGeneratedLVQ.UseVisualStyleBackColor = true;
            this.TestGeneratedLVQ.Click += new System.EventHandler(this.TestGeneratedLVQ_Click);
            // 
            // TestTrainLVQ
            // 
            this.TestTrainLVQ.Location = new System.Drawing.Point(38, 685);
            this.TestTrainLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestTrainLVQ.Name = "TestTrainLVQ";
            this.TestTrainLVQ.Size = new System.Drawing.Size(264, 57);
            this.TestTrainLVQ.TabIndex = 36;
            this.TestTrainLVQ.Text = "Протестувати навчальну вибірку";
            this.TestTrainLVQ.UseVisualStyleBackColor = true;
            this.TestTrainLVQ.Click += new System.EventHandler(this.TestTrainLVQ_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(388, 77);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(308, 31);
            this.label16.TabIndex = 35;
            this.label16.Text = "Швидкість зменшення швидкості навчання";
            this.label16.Visible = false;
            // 
            // DecayRateLVQ
            // 
            this.DecayRateLVQ.Location = new System.Drawing.Point(720, 77);
            this.DecayRateLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DecayRateLVQ.Name = "DecayRateLVQ";
            this.DecayRateLVQ.Size = new System.Drawing.Size(148, 26);
            this.DecayRateLVQ.TabIndex = 34;
            this.DecayRateLVQ.Visible = false;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(388, 117);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(308, 31);
            this.label14.TabIndex = 33;
            this.label14.Text = "Мінімальна похибка";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(388, 157);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 31);
            this.label15.TabIndex = 32;
            this.label15.Text = "Швидкість навчання мережі";
            // 
            // MinErrorLVQ
            // 
            this.MinErrorLVQ.Location = new System.Drawing.Point(720, 117);
            this.MinErrorLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinErrorLVQ.Name = "MinErrorLVQ";
            this.MinErrorLVQ.Size = new System.Drawing.Size(148, 26);
            this.MinErrorLVQ.TabIndex = 31;
            // 
            // LearningRateLVQ
            // 
            this.LearningRateLVQ.Location = new System.Drawing.Point(720, 157);
            this.LearningRateLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LearningRateLVQ.Name = "LearningRateLVQ";
            this.LearningRateLVQ.Size = new System.Drawing.Size(148, 26);
            this.LearningRateLVQ.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(356, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 243);
            this.label12.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(42, 351);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1180, 2);
            this.label13.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(988, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Час навчання мережі";
            // 
            // TimeLVQ
            // 
            this.TimeLVQ.Location = new System.Drawing.Point(993, 192);
            this.TimeLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeLVQ.Name = "TimeLVQ";
            this.TimeLVQ.ReadOnly = true;
            this.TimeLVQ.Size = new System.Drawing.Size(163, 26);
            this.TimeLVQ.TabIndex = 25;
            // 
            // TrainLVQ
            // 
            this.TrainLVQ.Location = new System.Drawing.Point(388, 260);
            this.TrainLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrainLVQ.Name = "TrainLVQ";
            this.TrainLVQ.Size = new System.Drawing.Size(264, 60);
            this.TrainLVQ.TabIndex = 24;
            this.TrainLVQ.Text = "Створити мережу";
            this.TrainLVQ.UseVisualStyleBackColor = true;
            this.TrainLVQ.Click += new System.EventHandler(this.TrainLVQ_Click);
            // 
            // SaveLVQ
            // 
            this.SaveLVQ.Location = new System.Drawing.Point(678, 468);
            this.SaveLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveLVQ.Name = "SaveLVQ";
            this.SaveLVQ.Size = new System.Drawing.Size(264, 49);
            this.SaveLVQ.TabIndex = 23;
            this.SaveLVQ.Text = "Зберегти мережу у файл";
            this.SaveLVQ.UseVisualStyleBackColor = true;
            this.SaveLVQ.Visible = false;
            this.SaveLVQ.Click += new System.EventHandler(this.SaveLVQ_Click);
            // 
            // DownLoadLVQ
            // 
            this.DownLoadLVQ.Location = new System.Drawing.Point(678, 445);
            this.DownLoadLVQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownLoadLVQ.Name = "DownLoadLVQ";
            this.DownLoadLVQ.Size = new System.Drawing.Size(264, 49);
            this.DownLoadLVQ.TabIndex = 0;
            this.DownLoadLVQ.Text = "Завантажити мережу з файла";
            this.DownLoadLVQ.UseVisualStyleBackColor = true;
            this.DownLoadLVQ.Visible = false;
            this.DownLoadLVQ.Click += new System.EventHandler(this.DownLoadLVQ_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(645, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Введіть кількість випадкових даних";
            this.label8.Visible = false;
            // 
            // testAmountText
            // 
            this.testAmountText.Location = new System.Drawing.Point(650, 60);
            this.testAmountText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testAmountText.Name = "testAmountText";
            this.testAmountText.Size = new System.Drawing.Size(277, 26);
            this.testAmountText.TabIndex = 16;
            this.testAmountText.Visible = false;
            // 
            // DownloadFromDB
            // 
            this.DownloadFromDB.Location = new System.Drawing.Point(84, 29);
            this.DownloadFromDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DownloadFromDB.Name = "DownloadFromDB";
            this.DownloadFromDB.Size = new System.Drawing.Size(261, 60);
            this.DownloadFromDB.TabIndex = 1;
            this.DownloadFromDB.Text = "Завантажити дані ";
            this.DownloadFromDB.UseVisualStyleBackColor = true;
            this.DownloadFromDB.Click += new System.EventHandler(this.DownloadFromDB_Click);
            // 
            // GenerateRandom
            // 
            this.GenerateRandom.Location = new System.Drawing.Point(666, 29);
            this.GenerateRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateRandom.Name = "GenerateRandom";
            this.GenerateRandom.Size = new System.Drawing.Size(261, 62);
            this.GenerateRandom.TabIndex = 4;
            this.GenerateRandom.Text = "Завантажити тест";
            this.GenerateRandom.UseVisualStyleBackColor = true;
            this.GenerateRandom.Click += new System.EventHandler(this.GenerateRandom_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileBackProp_FileOk);
            // 
            // saveResultsFileDialog
            // 
            this.saveResultsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveResultsFileDialog_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog3_FileOk);
            // 
            // saveFileDialog4
            // 
            this.saveFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog4_FileOk);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(966, 29);
            this.Graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(261, 62);
            this.Graph.TabIndex = 18;
            this.Graph.Text = "Переглянути графіки";
            this.Graph.UseVisualStyleBackColor = true;
            this.Graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 980);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.GenerateRandom);
            this.Controls.Add(this.DownloadFromDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.testAmountText);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Проект Гавриляка Дмитра";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResultsLVQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedResultsLVQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Hidden_Neurons;
        private System.Windows.Forms.Button CreateBackProp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DownLoadLVQ;
        private System.Windows.Forms.Button DownloadFromDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinError1;
        private System.Windows.Forms.TextBox Momentum;
        private System.Windows.Forms.TextBox Learning_rate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveRandom;
        private System.Windows.Forms.Button SaveTrain;
        private System.Windows.Forms.DataGridView TrainResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox testAmountText;
        private System.Windows.Forms.DataGridView RandomResults;
        private System.Windows.Forms.Button TestRandom;
        private System.Windows.Forms.Button TestTrain;
        private System.Windows.Forms.Button GenerateRandom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Time1;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveResultsFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button TrainLVQ;
        private System.Windows.Forms.Button SaveLVQ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MinErrorLVQ;
        private System.Windows.Forms.TextBox LearningRateLVQ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TimeLVQ;
        private System.Windows.Forms.Button TestGeneratedLVQ;
        private System.Windows.Forms.Button TestTrainLVQ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DecayRateLVQ;
        private System.Windows.Forms.DataGridView TrainResultsLVQ;
        private System.Windows.Forms.DataGridView GeneratedResultsLVQ;
        private System.Windows.Forms.Button SaveGeneratedLVQ;
        private System.Windows.Forms.Button SaveTrainLVQ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog4;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button TrainLVQNetwork;
        private System.Windows.Forms.Button Graph;
    }
}

