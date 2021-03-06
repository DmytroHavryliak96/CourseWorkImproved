﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;
using NeuralNetwork;
using System.IO;
using CourseWork.Models;
using CourseWork.Services;
using System.Globalization;


namespace CourseWork
{
    public partial class Form1 : Form
    {
		// змінні для зчитування з бд
		//DataSet ds = new DataSet(); // множина даних для запиту №1
		// DataSet ds2 = new DataSet(); // множина даних для запиту №2
		// DataTable dt = new DataTable(); // таблиця даних для запиту №1
		// DataTable dt2 = new DataTable(); // таблиця даних для запиту №2

		InputDataModel model;

        string separator;

		string[] ParametersNames = { "c", "h", "o", "n", "s"}; // назви параметрів керогену
        Stopwatch sWatch = new Stopwatch(); // клас для вимірювання часу навчання мережі BackPropagation
        Stopwatch sWatch2 = new Stopwatch(); // клас для вимірювання часу навчання мережі LVQ
        TimeSpan tSpan; // клас для перетворення даних про час навчання

        // змінні для створення таблиць із результатами роботи мережі (BackPropagation)
        DataTable ResultTrainBackPropagation; // результати роботи BackPropagation для навчальної вибірки
        DataTable ResultTestBackPropagation; //  результати роботи BackPropagation для тестової вибірки

        // змінні для створення таблиць із результатами роботи мережі (LVQ)
        DataTable ResultTrainLVQ; // результати роботи LVQ для навчальної вибірки
        DataTable ResultTestLVQ; //  результати роботи LVQ для тестової вибірки

        // навчальна вибірка
        int TRAINING_PATTERNS; // кількість паттернів у навчальній вибірці
        int PARAMETERS; // кількість параметрів керогену 
        int NUM_OF_CLUSTERS; // кількість кластерів керогену
        //int TestAmount; // кількість випадкової вибірки для тестування мереж

        // Параметри BackPropagation
        int[] layerSizes; // кількість шарів та нейронів у шарах
        // активаційні функції для кожного шару
        TransferFunction[] TFuncs = new TransferFunction[3] {TransferFunction.None,
                                                               TransferFunction.Sigmoid,
                                                               TransferFunction.Sigmoid};
        double LEARNING_RATE1; // швидкість навчання 
        double MOMENTUM; // коефіцієнт для навчання
        double MIN_ERROR; // мінімальна похибка для навчання
        double[] output = new double[1];

        // Параметри LVQ
        double MIN_ERROR2; // мінімальна похибка для навчання (LVQ)
        double LEARNING_RATE2; // швидкість навчання
        double DECAY_RATE; // швидкість зміни швидкості нвчання

        // масиви параметрів та відповідей
        double[][] inputs;
        double[][] answers;
        double[][] bpnAnswers;

        // Випадкова тестова вибірка
        double[][] testArray;
        double[][] testArrayAnswers;

        int testPatterns;

        double bpnTrainAccuracy;
        double bpnTestAccuracy;
        double lvqTrainAccuracy;
        double lvqTestAccuracy;

        // мережа BackPropagation
        BackPropagationNetwork bpn = null;

        // мережа LVQ
        LVQ lvq = null;

        public Form1()
        {
            InitializeComponent();
         
            this.RandomResults.DataSource = ResultTestBackPropagation;
            saveFileDialog.Filter = "XML - documents |*.xml";
            saveFileDialog2.Filter = "XML - documents |*.xml";
            saveResultsFileDialog.Filter = "Csv-file|*.csv";
            saveFileDialog1.Filter = "Csv-file|*.csv";
            saveFileDialog3.Filter = "Csv-file|*.csv";
            saveFileDialog4.Filter = "Csv-file|*.csv";
            separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        // завантаження даних з csv файлу для навчання мереж
        private void DownloadFromDB_Click(object sender, EventArgs e)
        {
			OpenFileDialog openCsvFile = new OpenFileDialog();
			openCsvFile.Filter = "CSV-file|*.csv";

            CsvReader reader;

            if (openCsvFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openCsvFile.FileName;
                reader = new CsvReader(fileName, CultureInfo.CurrentUICulture.Name);
                MessageBox.Show(fileName + " завантажений");


                try
                {
                    reader.ParseAll();
                    model = reader.model;

                    TRAINING_PATTERNS = model.TrainingPatterns;
                    PARAMETERS = model.Parameters;
                    NUM_OF_CLUSTERS = model.NumOfClusters;

                    inputs = model.Inputs;
                    answers = model.Answers;
                    bpnAnswers = model.BpnAnswers;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            else return;

			/*try
            {
                //  під'єднання до бд
                //string connstring = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=1postgres;Database=Labs;";
                //NpgsqlConnection conn = new NpgsqlConnection(connstring);
                //conn.Open();
                string sql = "SELECT * FROM train ORDER BY id";
                string sql1 = "SELECT DISTINCT Type FROM train ORDER BY Type";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                da = new NpgsqlDataAdapter(sql1, conn);
                da.Fill(ds2);
                dt2 = ds2.Tables[0];
                conn.Close();


                TRAINING_PATTERNS = dt.Rows.Count;
                PARAMETERS = dt.Columns.Count - 2;
                NUM_OF_CLUSTERS = dt2.Rows.Count;

                inputs = new double[TRAINING_PATTERNS][];
                answers = new double[TRAINING_PATTERNS][];

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    inputs[i] = new double[PARAMETERS];
                    answers[i] = new double[1];
                }

                // зчитування параметрів
                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    for (int k = 1; k < dt.Columns.Count - 1; k++)
                        inputs[i][k - 1] = Convert.ToDouble(dt.Rows[i][k]);

                    answers[i][0] = Convert.ToDouble(dt.Rows[i][dt.Columns.Count - 1]);
                }

                ParametersNames = new string[PARAMETERS];

                for(int i = 1; i < dt.Columns.Count - 1; i++)
                {
                    ParametersNames[i-1] = dt.Columns[i].ColumnName;

                }

                Normalize.NormalizeParameters(inputs); // нормалізація параметрів
                MessageBox.Show("Дані для навчання мережі завантажено");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }*/

        }

        // завантаження мережі BackPropagation з файлу
        private void DownloadBackProp_Click(object sender, EventArgs e)
        {
            string filepath = ""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }

            bpn = new BackPropagationNetwork(filepath);
            if (bpn == null)
                MessageBox.Show("Error");
            if (bpn.loaded != false)
                MessageBox.Show("Мережа BackPropagation завантажена");
            else
                MessageBox.Show("Виберіть інший файл для завантаження мережі");
        }

        // завантаження мережі LVQ з файлу
        private void DownLoadLVQ_Click(object sender, EventArgs e)
        {
            string filepath = ""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }

            lvq = new LVQ(filepath);
            MessageBox.Show("Мережа LVQ завантажена");
        }

        // збереження мережі BackPropagation у файл
        private void SaveNetwork_Click(object sender, EventArgs e)
        {
            
            saveFileDialog.ShowDialog();
        }

        // виклик діалогу для збереження мережі BackPropagation у файл
        private void saveFileBackProp_FileOk(object sender, CancelEventArgs e)
        {
            string filepath = saveFileDialog.FileName;
            if (filepath == null || bpn == null)
                return;
            bpn.Save(filepath);
            MessageBox.Show("Мережа BackPropagation збережена");
        }

        // збереження мережі LVQ у файл
        private void SaveLVQ_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        // виклик діалогу для збереження мережі LVQ у файл
        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string filepath = saveFileDialog2.FileName;
            if (filepath == null || lvq == null)
                return;
            lvq.Save(filepath);
            MessageBox.Show("Мережа LVQ збережена");       
        }

        // генерування тестових даних
        private void GenerateRandom_Click(object sender, EventArgs e)
        {
            if(PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }

            OpenFileDialog openCsvFile = new OpenFileDialog();
            openCsvFile.Filter = "CSV-file|*.csv";

            CsvReader reader;

            if (openCsvFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openCsvFile.FileName;
                reader = new CsvReader(fileName, CultureInfo.CurrentUICulture.Name);
                MessageBox.Show(fileName + " завантажений");

                try
                {
                    reader.ParseAll();
                    model = reader.model;

                    /*TRAINING_PATTERNS = model.TrainingPatterns;
                    PARAMETERS = model.Parameters;
                    NUM_OF_CLUSTERS = model.NumOfClusters;*/

                    testArray = model.Inputs;
                    testArrayAnswers = model.Answers;

                    testPatterns = testArray.Length;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

               // MessageBox.Show("Тестова випадкова вибірка згенерована");
            }
            else return; 
            //TestAmount = Convert.ToInt32(this.testAmountText.Text); 
            /*bool result = Int32.TryParse(this.testAmountText.Text, out TestAmount);
            if (result == false)
            {
                MessageBox.Show("Введіть кількість векторів з випадковими даними, які потрібно згенерувати");
                return;
            }
            
            if (TestAmount <= 0)
            {
                MessageBox.Show("Недопустиме значення");
                return;
            }   
            testArray = GenerateTest.GenerateOutputICG(PARAMETERS, TestAmount); // створення тестової вибірки
            Normalize.NormalizeTest(testArray); */

            
        }

        // вихід із програми
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // створення мережі BackPropagation
        private void CreateBackProp_Click(object sender, EventArgs e)
        {
            if(PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }
            int hidden;
            bool resultHidden = Int32.TryParse(this.Hidden_Neurons.Text, out hidden);
            bool resultLearning_Rate1 = Double.TryParse(this.Learning_rate1.Text, out LEARNING_RATE1);
            bool resultMomentum = Double.TryParse(this.Momentum.Text, out MOMENTUM);
            bool resultMin_error = Double.TryParse(this.MinError1.Text, out MIN_ERROR);

            if(resultHidden == false || resultLearning_Rate1 == false || resultMomentum == false || resultMin_error == false)
            {
                MessageBox.Show("Не всі обов'язкові поля заповнені для створення мережі BackPropagation");
                return;
            }
         
            layerSizes = new int[3]{ PARAMETERS, hidden, NUM_OF_CLUSTERS }; // кількість шарів та нейронів у шарах

            bpn = new BackPropagationNetwork(layerSizes, TFuncs);
            MessageBox.Show("Мережу BackPropagation створено");
        }

        // Навчання мережі BackPropagation
        private void Train_Click(object sender, EventArgs e)
        {
            if (bpn == null)
            {
                MessageBox.Show("Спочатку створіть мережу або завантажте її з файлу");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            sWatch.Reset();
            sWatch.Start();
            
            bpn.TrainNetwork(inputs, /*Normalize.FormAnswersBackPropagation(*/bpnAnswers/*)*/, MIN_ERROR, LEARNING_RATE1, MOMENTUM);
            sWatch.Stop();
            Cursor.Current = Cursors.Arrow;

            tSpan = sWatch.Elapsed;
            this.Time1.Text = Convert.ToString(tSpan);
            MessageBox.Show("Мережа BackPropagation навчена");
        }

        // Створення мережі LVQ
        private void TrainLVQ_Click(object sender, EventArgs e)
        {
            if (PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }

            bool resultLearning_rate2 = Double.TryParse(LearningRateLVQ.Text, out LEARNING_RATE2);
            bool resultMin_error2 = Double.TryParse(MinErrorLVQ.Text, out MIN_ERROR2);
            bool resultDecay_rate = true;//Double.TryParse(DecayRateLVQ.Text, out DECAY_RATE);

            DECAY_RATE = 0.1;

            if (resultLearning_rate2 == false || resultMin_error2 == false || resultDecay_rate == false)
            {
                MessageBox.Show("Не всі обов'язкові поля заповнені для створення мережі LVQ");
                return;
            }
        
            lvq = new LVQ(inputs, Normalize.FormAnswersLVQ(answers), MIN_ERROR2, LEARNING_RATE2, DECAY_RATE, NUM_OF_CLUSTERS);
            MessageBox.Show("Мережу LVQ створено");

        }

        // Навчання мережі LVQ
        private void TrainLVQNetwork_Click(object sender, EventArgs e)
        {
            if (lvq == null)
            {
                MessageBox.Show("Спочатку створіть мережу або завантажте її з файлу");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            sWatch2.Reset();
            sWatch2.Start();

            lvq.TrainNetwork();
            sWatch2.Stop();
            Cursor.Current = Cursors.Arrow;
            tSpan = sWatch2.Elapsed;
            this.TimeLVQ.Text = Convert.ToString(tSpan);
            MessageBox.Show("Мережа LVQ навчена");
        }

        // Тестування навчальної вибірки (BackPropagation)
        private void TestTrain_Click(object sender, EventArgs e)
        {
            if (bpn == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTrainBackPropagation = new DataTable();
                this.TrainResults.DataSource = ResultTrainBackPropagation;

                // Створення колонок
                ResultTrainBackPropagation.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTrainBackPropagation.Columns.Add(ParametersNames[i]);
                }

                ResultTrainBackPropagation.Columns.Add("Кластер");

                int matches = 0;

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    DataRow row = ResultTrainBackPropagation.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = inputs[i][k].ToString("G", CultureInfo.InvariantCulture);
                    }
                    int netAnswer = bpn.getClusterUpdate(inputs[i], output);
                    row["Кластер"] = netAnswer;

                    if (netAnswer == answers[i][0])
                        matches++;

                    
                    ResultTrainBackPropagation.Rows.Add(row);
                }

                bpnTrainAccuracy = matches / (double)TRAINING_PATTERNS * 100;
                
            }

        }

        // Тестування навчальної вибірки (LVQ)
        private void TestTrainLVQ_Click(object sender, EventArgs e)
        {
            if (lvq == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTrainLVQ = new DataTable();
                this.TrainResultsLVQ.DataSource = ResultTrainLVQ;

                // Створення колонок
                ResultTrainLVQ.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTrainLVQ.Columns.Add(ParametersNames[i]);
                }

                ResultTrainLVQ.Columns.Add("Кластер");

                int matches = 0;

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    DataRow row = ResultTrainLVQ.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = inputs[i][k].ToString("G", CultureInfo.InvariantCulture);
                    }

                    int netAnswer = lvq.getCluster(inputs[i]);

                    row["Кластер"] = netAnswer;

                    if (netAnswer == answers[i][0])
                        matches++;

                    ResultTrainLVQ.Rows.Add(row);
                }

                lvqTrainAccuracy = matches / (double)TRAINING_PATTERNS * 100;

            }

        }

        // Тестування випадкової вибірки (BackPropagation)
        private void TestRandom_Click(object sender, EventArgs e)
        {
            if (bpn == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTestBackPropagation = new DataTable();
                this.RandomResults.DataSource = ResultTestBackPropagation;

                // Створення колонок
                ResultTestBackPropagation.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTestBackPropagation.Columns.Add(ParametersNames[i]);
                }

                ResultTestBackPropagation.Columns.Add("Кластер");

                int matches = 0;

                for (int i = 0; i < testPatterns; i++)
                {
                    DataRow row = ResultTestBackPropagation.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = testArray[i][k].ToString("G", CultureInfo.InvariantCulture);
                    }

                    int netAnswer = bpn.getClusterUpdate(testArray[i], output);
                    
                    row["Кластер"] = netAnswer;

                    if (netAnswer == answers[i][0])
                        matches++;

                    ResultTestBackPropagation.Rows.Add(row);
                }

                bpnTestAccuracy = matches / (double)TRAINING_PATTERNS * 100;
            }
        }

        // Тестування випадкової вибірки (LVQ)
        private void TestGeneratedLVQ_Click(object sender, EventArgs e)
        {
            if (lvq == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTestLVQ = new DataTable();
                this.GeneratedResultsLVQ.DataSource = ResultTestLVQ;

                // Створення колонок
                ResultTestLVQ.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTestLVQ.Columns.Add(ParametersNames[i]);
                }

                ResultTestLVQ.Columns.Add("Кластер");

                int matches = 0;

                for (int i = 0; i < testPatterns; i++)
                {
                    DataRow row = ResultTestLVQ.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = testArray[i][k].ToString("G", CultureInfo.InvariantCulture);
                    }

                    int netAnswer = lvq.getCluster(testArray[i]);

                    row["Кластер"] = netAnswer;

                    if (netAnswer == answers[i][0])
                        matches++;

                    ResultTestLVQ.Rows.Add(row);
                }

                lvqTestAccuracy = matches / (double)TRAINING_PATTERNS * 100;
            }
        }

        // Запис результатів для навчальної вибірки (BackPropagation)
        private void SaveTrain_Click(object sender, EventArgs e)
        {
            if (PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }
            saveResultsFileDialog.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (TrainResults, BackPropagation)
        private void saveResultsFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
                string filepath = saveResultsFileDialog.FileName;
                string text = "";
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i] + separator;
                }

                string accuracy = "accuracy=" + bpnTrainAccuracy.ToString();
                text += "network answer" + separator + "real value" + separator + accuracy;
                text += Environment.NewLine;

                foreach (DataGridViewRow row in TrainResults.Rows)
                {
                  
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        text += cell.Value.ToString() + separator;
                       
                    }
                    text += answers[row.Index][0].ToString();
                    text += Environment.NewLine;

                    
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати навчальної вибірки збережено");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для навчальної вибірки (LVQ)
        private void SaveTrainLVQ_Click(object sender, EventArgs e)
        {
            if (PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }
            saveFileDialog3.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (TrainResults, LVQ)
        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog3.FileName;
                string text = "";
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i] + separator;
                }

                string accuracy = "accuracy=" + lvqTrainAccuracy.ToString();
                text += "network answer" + separator + "real value" + separator + accuracy;
                
                text += Environment.NewLine;

                foreach (DataGridViewRow row in TrainResultsLVQ.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        text += cell.Value.ToString() + separator;

                    }
                    text += answers[row.Index][0].ToString();
                    text += Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати навчальної вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для випадкової вибірки (BackPropagation)
        private void SaveRandom_Click(object sender, EventArgs e)
        {
            if(PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }
            saveFileDialog1.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (RandomResults, BackPropagation)
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog1.FileName;
                string text = "";
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i] + separator;
                }

                string accuracy = "accuracy=" + bpnTestAccuracy.ToString();
                text += "network answer" + separator + "real value" + separator + accuracy;
                
                text += Environment.NewLine;

                foreach (DataGridViewRow row in RandomResults.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        text += cell.Value.ToString() + separator;

                    }
                    text += testArrayAnswers[row.Index][0].ToString();
                    text += Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати випадкової вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для випадкової вибірки (LVQ)
        private void SaveGeneratedLVQ_Click(object sender, EventArgs e)
        {
            if (PARAMETERS == 0)
            {
                MessageBox.Show("Спочатку завантажте дані");
                return;
            }
            saveFileDialog4.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (GeneratedResults, LVQ)
        private void saveFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog4.FileName;
                string text = "";
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i] + separator;
                }
                
                string accuracy = "accuracy=" + lvqTestAccuracy.ToString();
                text += "network answer" + separator + "real value" + separator + accuracy;

                text += Environment.NewLine;

                foreach (DataGridViewRow row in GeneratedResultsLVQ.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        text += cell.Value.ToString() + separator;

                    }
                    text += testArrayAnswers[row.Index][0].ToString();
                    text += Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати випадкової вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // завантаження мережі BackPropagation із файла
        private void pictureBox1_Click_4(object sender, EventArgs e)
        {
            string filepath=""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML - документи|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
           
            }
            else
                return;
             
            BackPropagationNetwork bpn2 = new BackPropagationNetwork(filepath);

            if (bpn2.loaded != false)
            {
                bpn = bpn2;
                MessageBox.Show("Мережа BackPropagation завантажена");
            }
            else
                MessageBox.Show("Виберіть інший файл для завантаження мережі");
            
        }

        // збереження мережі BackPropagation
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        // завантаження мережі LVQ
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string filepath = ""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }
            else
                return;

            LVQ lvq2 = new LVQ(filepath);

            if (lvq2.loaded != false)
            {
                lvq = lvq2;
                MessageBox.Show("Мережа LVQ завантажена");
            }
            else
            {
                MessageBox.Show("Виберіть інший файл для завантаження мережі");
            }
        }

        // збереження мережі LVQ
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private static double GetDouble(string value, double defaultValue)
        {
            double result;

            // Try parsing in the current culture
            if (!double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                // Then try in US english
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                // Then in neutral language
                !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BPNErrorCollection bpnError = null;
            LVQErrorCollection lvqError = null;

            if (bpn != null)
                bpnError = (BPNErrorCollection)bpn.errorService;
            if (lvq != null)
                lvqError = (LVQErrorCollection)lvq.errorService;

            ErrorGraphForm eForm = new ErrorGraphForm(lvqError, bpnError);

            eForm.ShowDialog();
        }
    }
}
