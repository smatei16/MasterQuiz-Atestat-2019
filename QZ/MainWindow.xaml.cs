using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Common;
using System.Configuration;

namespace QZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int correct;
        int wrong;
        int CompletedQuizes = QZ.Properties.Settings.Default.CompletedQuizes;
        int CorrectQuizes = QZ.Properties.Settings.Default.CorrectQuizes;
        int WrongQuiezes;
        int AddedQuestionNumber = QZ.Properties.Settings.Default.AddedQuestionNumber;
        bool light = true;
        int i = 0;
        Countdown cd = new Countdown();
        Random rnd = new Random();
        int currentq;
        List<QuestionModel> onequestion = new List<QuestionModel>();
        
        public MainWindow()
        {
            InitializeComponent();
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
            numberOfSolvedQuizes.Text = CompletedQuizes.ToString();
            if (CompletedQuizes == 0) Procent.Text = "-%";
            else
            {
                int aux = CorrectQuizes*100 / CompletedQuizes;
                Procent.Text = aux.ToString() + "%";
            }
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Visible;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
        }

        private void QuizEditorButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Visible;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Visible;
            QuestionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            QZ.Properties.Settings.Default.CompletedQuizes = CompletedQuizes;
            QZ.Properties.Settings.Default.CorrectQuizes = CorrectQuizes;
            QZ.Properties.Settings.Default.AddedQuestionNumber = AddedQuestionNumber;
            QZ.Properties.Settings.Default.Save();
            this.Close();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void ReturnToDashboardButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Visible;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
        }
        private void LoadGeneralKnowledgeQuestionList()
        {
            //onequestion = SqliteDataAccess.LoadGeneralKnowledgeQuestions();
        }
        private void addGeneralKnowledgeQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveGeneralKnowledgeQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addFilmQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveFilmQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addMusicQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveMusicQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addVideoGamesQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveVideoGamesQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addScienceComputersQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveScienceComputersQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addScienceMathematicsQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveScienceMathematicsQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addSportsQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveSportsQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addHistoryQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SaveHistoryQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void addPoliticsQuestion()
        {
            QuestionModel q = new QuestionModel();
            q.Question = qBox.Text;
            q.RightAnswer = AnswerBox1.Text;
            q.WrongAnswer1 = AnswerBox2.Text;
            q.WrongAnswer2 = AnswerBox3.Text;
            q.WrongAnswer3 = AnswerBox4.Text;
            SqliteDataAccess.SavePoliticsQuestion(q);
            AddedQuestionNumber++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
        }
        private void showquestion(int i, List<QuestionModel> qlist)
        {
            CurrentQuestionText.Text = qlist[i].Question;
            if (currentq == 1)
            {
                Answer1Text.Text = qlist[i].RightAnswer;
                Answer2Text.Text = qlist[i].WrongAnswer1;
                Answer3Text.Text = qlist[i].WrongAnswer2;
                Answer4Text.Text = qlist[i].WrongAnswer3;
            }
            else if (currentq == 2)
            {
                Answer1Text.Text = qlist[i].WrongAnswer1;
                Answer2Text.Text = qlist[i].RightAnswer;
                Answer3Text.Text = qlist[i].WrongAnswer2;
                Answer4Text.Text = qlist[i].WrongAnswer3;
            }
            else if (currentq == 3)
            {
                Answer1Text.Text = qlist[i].WrongAnswer1;
                Answer2Text.Text = qlist[i].WrongAnswer2;
                Answer3Text.Text = qlist[i].RightAnswer;
                Answer4Text.Text = qlist[i].WrongAnswer3;
            }
            else if (currentq == 4)
            {
                Answer1Text.Text = qlist[i].WrongAnswer1;
                Answer2Text.Text = qlist[i].WrongAnswer2;
                Answer3Text.Text = qlist[i].WrongAnswer3;
                Answer4Text.Text = qlist[i].RightAnswer;
            }
            
        }
        private void Complete()
        {
            cd.StopTimer();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Visible;
            CompletedQuizes++;
            if (correct >= 5) CorrectQuizes++;
            else WrongQuiezes++;
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
            numberOfSolvedQuizes.Text = CompletedQuizes.ToString();
            if (CompletedQuizes == 0) Procent.Text = "-%";
            else
                {
                int aux = CorrectQuizes *100 / CompletedQuizes;
                Procent.Text = aux.ToString() + "%";
                }
            if (correct >= 5) CongratsText.Text = "Congratulations! You passed this quiz with " + correct + " correct answers!";
            else CongratsText.Text = "Unfortunately, you failed this quiz (You had " +correct+ "). But don't give up!";
        }
        private void GeneralKnowledgeButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadGeneralKnowledgeQuestions();
            AnyCategoryQuiz();
        }
        private void AddGeneralKnowledgeButton_Click(object sender, RoutedEventArgs e)
        {
            addGeneralKnowledgeQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void FilmButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadFilmQuestions();
            AnyCategoryQuiz();
        }
        private void AddFilmButton_Click(object sender, RoutedEventArgs e)
        {
            addFilmQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void MusicButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadMusicQuestions();
            AnyCategoryQuiz();
        }
        private void AddMusicButton_Click(object sender, RoutedEventArgs e)
        {
            addMusicQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void VideoGamesButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadVideoGamesQuestions();
            AnyCategoryQuiz();
        }
        private void AddVideoGamesButton_Click(object sender, RoutedEventArgs e)
        {
            addVideoGamesQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void ScienceComputersButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadScienceComputersQuestions();
            AnyCategoryQuiz();
        }
        private void AddScienceComputersButton_Click(object sender, RoutedEventArgs e)
        {
            addScienceComputersQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void ScienceMathematicsButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadScienceMathematicsQuestions();
            AnyCategoryQuiz();
        }
        private void AddScienceMathematicsButton_Click(object sender, RoutedEventArgs e)
        {
            addScienceMathematicsQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void SportsButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadSportsQuestions();
            AnyCategoryQuiz();
        }
        private void AddSportsButton_Click(object sender, RoutedEventArgs e)
        {
            addSportsQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadHistoryQuestions();
            AnyCategoryQuiz();
        }
        private void AddHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            addHistoryQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void PoliticsButton_Click(object sender, RoutedEventArgs e)
        {
            onequestion = SqliteDataAccess.LoadPoliticsQuestions();
            AnyCategoryQuiz();
        }
        private void AddPoliticsButton_Click(object sender, RoutedEventArgs e)
        {
            addPoliticsQuestion();
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Visible;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Hidden;
            qBox.Text = "Enter a new question";
            AnswerBox1.Text = "Enter correct answer";
            AnswerBox2.Text = "Enter wrong answer";
            AnswerBox3.Text = "Enter wrong answer";
            AnswerBox4.Text = "Enter wrong answer";
        }
        private void Answer1Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentq == 1) correct++;
            else wrong++;
            if (i + 1 <= 9)
            {
                QuestionNumberText.Text = i + 2 + "/10";
                currentq = rnd.Next(1, 4);
                showquestion(++i, onequestion);
            }
            else Complete();

        }
        private void Answer2Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentq == 2) correct++;
            else wrong++;
            if (i + 1 <= 9)
            {
                QuestionNumberText.Text = i + 2 + "/10";
                currentq = rnd.Next(1, 4);
                showquestion(++i, onequestion);
            }
            else Complete();
        }
        private void Answer3Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentq == 3) correct++;
            else wrong++;
            if (i + 1 <= 9)
            {
                QuestionNumberText.Text = i + 2 + "/10";
                currentq = rnd.Next(1,4);
                showquestion(++i, onequestion);
            }
            else Complete();
        }
        private void Answer4Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentq == 4) correct++;
            else wrong++;
            if (i + 1 <= 9)
            {
                QuestionNumberText.Text = i + 2 + "/10";
                currentq = rnd.Next(1, 4);
                showquestion(++i, onequestion);
            }
            else Complete();
        }
        private void AnyCategoryQuiz()
        {
            correct = 0;
            wrong = 0;
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Visible;
            EditCategory.Visibility = Visibility.Hidden;
            i = 0;
            currentq = rnd.Next(1, 4);
            QuestionNumberText.Text = "1/10";
            showquestion(i, onequestion);
            bool start = false;
            if (start == false)
            {
                start = true;
                
                cd.startFromTen(600, TimeSpan.FromSeconds(1), curr =>
                {
                    if (curr % 60 > 9 && curr / 60 > 9) TimerText.Text = (curr / 60).ToString() + ":" + (curr % 60).ToString();
                    else if (curr % 60 > 9 && curr / 60 <= 9) TimerText.Text = "0" + (curr / 60).ToString() + ":" + (curr % 60).ToString();
                    else if (curr % 60 <= 9 && curr / 60 > 9) TimerText.Text = (curr / 60).ToString() + ":" + "0" + (curr % 60).ToString();
                    else if (curr % 60 <= 9 && curr / 60 <= 9) TimerText.Text = "0" + (curr / 60).ToString() + ":" + "0" + (curr % 60).ToString();
                });
            }
        }

        private void ResetProgressButton_Click(object sender, RoutedEventArgs e)
        {
            CompletedQuizes = 0;
            CorrectQuizes = 0;
            WrongQuiezes = 0;
            AddedQuestionNumber = 0;
            QZ.Properties.Settings.Default.CompletedQuizes = CompletedQuizes;
            QZ.Properties.Settings.Default.CorrectQuizes = CorrectQuizes;
            QZ.Properties.Settings.Default.AddedQuestionNumber = AddedQuestionNumber;
            QZ.Properties.Settings.Default.Save();
            AddedQuestionsText.Text = AddedQuestionNumber.ToString();
            numberOfSolvedQuizes.Text = CompletedQuizes.ToString();
            if (CompletedQuizes == 0) Procent.Text = "-%";
            else
            {
                int aux = CorrectQuizes * 100 / CompletedQuizes;
                Procent.Text = aux.ToString() + "%";
            }

        }

        private void SwitchToNight()
        {
            NightModeButtonText.Text = "Light Mode";
            light = false;
            //ButtonGrid
            MinimizeImage.Source = new BitmapImage(new Uri("Images/MinimizeNM.png", UriKind.Relative));
            CloseImage.Source = new BitmapImage(new Uri("Images/CloseNM.png", UriKind.Relative));
            DashboardImage.Source = new BitmapImage(new Uri("Images/DashboardsNM.png", UriKind.Relative));
            QuizEditorImage.Source = new BitmapImage(new Uri("Images/EditNM.png", UriKind.Relative));
            SettingsImage.Source = new BitmapImage(new Uri("Images/SettingsNM.png", UriKind.Relative));
            BarGrid.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            MQGrid.Background = new SolidColorBrush(Color.FromRgb(20, 25, 50));
            MQText.Foreground = new SolidColorBrush(Color.FromRgb(20, 50, 100));
            ButtonGrid.Background = new SolidColorBrush(Color.FromRgb(38, 38, 38));
            DashboardButton.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            QuizEditorButton.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            SettingsButton.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            CloseButton.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            MinimizeButton.Background = new SolidColorBrush(Color.FromRgb(20, 20, 30));
            DashboardButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            QuizEditorButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            SettingsButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //Dashboard
            QuizSuccessText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            DashboardGrid.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            SuccessfulQuizesRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            ResolvedQuizesRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            NewQuestionsAddedRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            AddedQuestionsText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            NewQuestionAddedTextText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            numberOfSolvedQuizes.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            numberOfSolvedQuizesText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            StartButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            Procent.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            StartButton.Background = new SolidColorBrush(Color.FromRgb(38, 38, 38));
            StartButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //QuizEditor
            QuizEditorGrid.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            qBox.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            qBoxRectangle.Fill = new SolidColorBrush(Color.FromRgb(26 ,26 ,26));
            Answer1Rectangle.Fill= new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer2Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer3Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer4Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            AnswerBox1.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            AnswerBox2.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            AnswerBox3.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            AnswerBox4.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            InsertQuestionButton.Background = new SolidColorBrush(Color.FromRgb(38, 38, 38));
            InsertQuestionButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //Settings
            SettingsGrid.Background = new SolidColorBrush(Color.FromRgb(51,51,51));
            ResetProgressButton.Background = new SolidColorBrush(Color.FromRgb(38,38,38));
            ResetProgressButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            NightModeButton.Background = new SolidColorBrush(Color.FromRgb(38, 38, 38));
            NightModeButtonText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //QuestionGrid
            TimerImage.Source = new BitmapImage(new Uri("Images/timerNM.png", UriKind.Relative));
            QuestionGrid.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            QuestionNumberRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            QuestionNumberText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            TimeLeftRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            TimerText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            CurrentQuestionRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            CurrentQuestionText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            Answer11Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer1Text.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            Answer22Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer2Text.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            Answer33Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer3Text.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            Answer44Rectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            Answer4Text.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //CategorySelection
            CategorySelectionGrid.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            PleaseSelectRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            PleaseSelectText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //CongratsGrid
            CongratsGrid.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            CongratsRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            CongratsText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            ReturnToDashboardButton.Background = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            ReturnToDashboardText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
            //EditCategory
            EditCategory.Background = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            PleaseSelectEditRectangle.Fill = new SolidColorBrush(Color.FromRgb(26, 26, 26));
            PleaseSelectEditText.Foreground = new SolidColorBrush(Color.FromRgb(140, 140, 140));
        }
        private void SwitchToLight()
        {
            NightModeButtonText.Text = "Night Mode";
            light = true;
            //ButtonGrid
            MinimizeImage.Source = new BitmapImage(new Uri("Images/Minimize.png", UriKind.Relative));
            CloseImage.Source = new BitmapImage(new Uri("Images/Close.png", UriKind.Relative));
            DashboardImage.Source = new BitmapImage(new Uri("Images/Dashboards.png", UriKind.Relative));
            QuizEditorImage.Source = new BitmapImage(new Uri("Images/Edit.png", UriKind.Relative));
            SettingsImage.Source = new BitmapImage(new Uri("Images/Settings.png", UriKind.Relative));
            BarGrid.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            MQGrid.Background = new SolidColorBrush(Color.FromRgb(88, 242, 181));
            MQText.Foreground = new SolidColorBrush(Color.FromRgb(40, 144, 59));
            DashboardButton.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            QuizEditorButton.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            SettingsButton.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            CloseButton.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            MinimizeButton.Background = new SolidColorBrush(Color.FromRgb(15, 184, 117));
            DashboardButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            QuizEditorButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            SettingsButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            LinearGradientBrush br = new LinearGradientBrush();
            br.StartPoint = new Point(0.5,0);
            br.EndPoint = new Point(0.5,1);
            GradientStop gr = new GradientStop();
            gr.Color = Color.FromRgb(230,230,230);
            gr.Offset = 0.0;
            br.GradientStops.Add(gr);
            GradientStop gr2 = new GradientStop();
            gr2.Color = Color.FromRgb(211, 211, 211);
            gr2.Offset = 1.0;
            br.GradientStops.Add(gr2);
            ButtonGrid.Background = br;
            //Dashboard
            QuizSuccessText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            DashboardGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            SuccessfulQuizesRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            ResolvedQuizesRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            NewQuestionsAddedRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            AddedQuestionsText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            NewQuestionAddedTextText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            numberOfSolvedQuizes.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            numberOfSolvedQuizesText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            StartButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Procent.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            StartButton.Background = new SolidColorBrush(Color.FromRgb(64, 224, 208));
            StartButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //QuizEditor
            QuizEditorGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            qBox.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            qBoxRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer1Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer2Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer3Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer4Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            AnswerBox1.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            AnswerBox2.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            AnswerBox3.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            AnswerBox4.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            InsertQuestionButton.Background = new SolidColorBrush(Color.FromRgb(64, 224, 208));
            InsertQuestionButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //Settings
            SettingsGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            ResetProgressButton.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            ResetProgressButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            NightModeButton.Background = new SolidColorBrush(Color.FromRgb(173, 216, 230));
            NightModeButtonText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //QuestionGrid
            TimerImage.Source = new BitmapImage(new Uri("Images/timer.png", UriKind.Relative));
            QuestionGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            QuestionNumberRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            QuestionNumberText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            TimeLeftRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            TimerText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            CurrentQuestionRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            CurrentQuestionText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Answer11Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer1Text.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Answer22Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer2Text.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Answer33Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer3Text.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Answer44Rectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Answer4Text.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //CategorySelection
            CategorySelectionGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            PleaseSelectRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            PleaseSelectText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //CongratsGrid
            CongratsGrid.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            CongratsRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            CongratsText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            ReturnToDashboardButton.Background = new SolidColorBrush(Color.FromRgb(64, 224, 208));
            ReturnToDashboardText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            //EditCategory
            EditCategory.Background = new SolidColorBrush(Color.FromRgb(207, 207, 207));
            PleaseSelectEditRectangle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            PleaseSelectEditText.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void NightModeButton_Click(object sender, RoutedEventArgs e)
        {
            if (light)
                SwitchToNight();
            else SwitchToLight();
        }

        private void DashboardButton_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DashboardButton.Background = new SolidColorBrush(Color.FromRgb(20, 30, 50));
            
        }

        private void InsertQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            DashboardGrid.Visibility = Visibility.Hidden;
            QuizEditorGrid.Visibility = Visibility.Hidden;
            SettingsGrid.Visibility = Visibility.Hidden;
            QuestionGrid.Visibility = Visibility.Hidden;
            CategorySelectionGrid.Visibility = Visibility.Hidden;
            CongratsGrid.Visibility = Visibility.Hidden;
            EditCategory.Visibility = Visibility.Visible;
        }
    }
}
