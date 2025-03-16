using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Million_Dollar_Project
{
    public partial class Form1 : Form
    {
        struct stQuestion
        {
            public string Question;
            public string OptionA;
            public string OptionB;
            public string OptionC;
            public string OptionD;
            public string CorrectOption;

            public stQuestion(string q,string A,string B,string C,string D,string Correct)
            {
                Question=q;
                OptionA=A;
                OptionB=B;
                OptionC=C;
                OptionD=D;
                CorrectOption=Correct;
            }
        }

        int NumberOfQuestion = 0;

        int Counter = 0;

        bool isButtonAClicked = false;
        
        bool isButtonBClicked = false;
        bool isButtonCClicked = false;
        bool isButtonDClicked = false;

        bool isButtonFiftyClicked = false;
        int NumberOfFiftyForQuestion = -1;
        bool isButtonCallClicked = false;
        int NumberOfCallForQuestion = -1;
        bool isButtonAudienceClicked = false;
        int NumberOfAudienceForQuestion = -1;

        char AnswerOfUser = '\0';

        bool isReset = false;

        string PathOfEasyFile = @"C:\Users\aymane\source\repos\programming advices\14 - C# - Level 1\Easy.txt";
        string PathOfMediumFile = "C:\\Users\\aymane\\source\\repos\\programming advices\\14 - C# - Level 1\\Medium.txt";
        string PathOfHardFile = "C:\\Users\\aymane\\source\\repos\\programming advices\\14 - C# - Level 1\\Hard.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form frmLogin=new frmLoginOrSignup();
            //frmLogin.ShowDialog();
            cmbxDifficulty.Focus();
        }

        private void loginSignupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fromloginorsin = new frmLoginOrSignup();
            fromloginorsin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private stQuestion ConvertLineQuestionToRecord(string Question)
        {
            List<string> QuestionData = new List<string>(Question.Split(new string[] { "/**/" }, StringSplitOptions.None));
            stQuestion stQuestionRecord = new stQuestion(QuestionData[0], QuestionData[1], QuestionData[2], QuestionData[3], QuestionData[4], QuestionData[5]);
            return stQuestionRecord;
        }

        private List<stQuestion> LoadQuestionsDataFromFile(string FilePath)
        {
            List<stQuestion> Questions = new List<stQuestion>();
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string Line;
                    while ((Line = reader.ReadLine()) != null)
                    {
                        Questions.Add(ConvertLineQuestionToRecord(Line));
                    }
                }
            }
            return Questions;

        }
        private Button ButtonByNumber(int Number)
        {
            switch(Number)
            {
                case 1:
                    return btnOptionA;
                case 2:
                    return btnOptionB;
                case 3:
                    return btnOptionC;
                default:
                    return btnOptionD;
                    
            }
        }
        
        private ProgressBar ProgressBarByNumber(int Number)
        {
            switch(Number)
            {
                case 1:
                    return pgbOptionA;
                case 2:    
                    return pgbOptionB;
                case 3:    
                    return pgbOptionC;
                default:   
                    return pgbOptionD;
                    
            }
        }

        private Label LabelByNumber(int Number)
        {
            switch(Number)
            {
                case 1:
                    return lblPercentegeOfOptionA;
                case 2:
                    return lblPercentegeOfOptionB;
                case 3:
                    return lblPercentegeOfOptionC;
                default:
                    return lblPercentegeOfOptionD;
            }
        }

        private void FiftyFifty(stQuestion question)
        {
            Random rand = new Random();
            for (int i=0;i<2;i++)
            {
                int RandomNumber = rand.Next(1, 5);
                while (65+RandomNumber-1 == Convert.ToInt32(question.CorrectOption[0])|| !ButtonByNumber(RandomNumber).Visible)
                {
                    RandomNumber = rand.Next(1, 5);
                }
                switch(RandomNumber)
                {
                    case 1:
                        btnOptionA.Visible = false;
                        break;
                    case 2:
                        btnOptionB.Visible = false;
                        break;
                    case 3:
                        btnOptionC.Visible = false;
                        break;
                    default:
                        btnOptionD.Visible = false;
                        break;
                }
                MessageBox.Show(i.ToString());
            }
        }

        private void CallAFriend()
        {
            Random rand = new Random();
            int RandomAnswer=rand.Next(1, 5);
            while (!ButtonByNumber(RandomAnswer).Visible) 
            {
                RandomAnswer = rand.Next(1, 5);
            }
            switch(RandomAnswer)
            {
                case 1:
                    MessageBox.Show("Hi my Friend,i think the option A is the correct answer! ", "Call From Friend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    MessageBox.Show("Hi my Friend,i think the option B is the correct answer! ", "Call From Friend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show("Hi my Friend,i think the option C is the correct answer! ", "Call From Friend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default :
                    MessageBox.Show("Hi my Friend,i think the option D is the correct answer! ", "Call From Friend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void AudienceInsights()
        {
            Random rand = new Random();
            int NumberVote = rand.Next(0, 101);
            int Total = 0;
            for (int i = 1; i < 5; i++)
            {
                if (ButtonByNumber(i).Visible)
                {
                    ProgressBarByNumber(i).Visible = true;
                    ProgressBarByNumber(i).Value = NumberVote;
                    LabelByNumber(i).Text = NumberVote.ToString();

                    Total += NumberVote;
                    NumberVote = rand.Next(0, 101 - Total);
                }
            }
        }

        private bool isUserAnswerHasCorrect(stQuestion question)
        {
            if (AnswerOfUser == question.CorrectOption[0])
            {
                return true;
            }
            return false;
        }

        private void VisibleOptions()
        {
            btnOptionA.Visible = true;
            btnOptionB.Visible = true;
            btnOptionC.Visible = true;
            btnOptionD.Visible = true;
        }

        private void EnabledOptions()
        {
            btnOptionA.Enabled = true;
            btnOptionB.Enabled = true;
            btnOptionC.Enabled = true;
            btnOptionD.Enabled = true;
        }
        
        private void DisabledOptions()
        {
            btnOptionA.Enabled = false;
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
            btnOptionD.Enabled = false;
        }

        private void HideProgressBar()
        {
            pgbOptionA.Visible = false;
            pgbOptionB.Visible = false;
            pgbOptionC.Visible = false;
            pgbOptionD.Visible = false;
        }

        private void EmptyLabelPercentage()
        {
            lblPercentegeOfOptionA.Text = "";
            lblPercentegeOfOptionB.Text = "";
            lblPercentegeOfOptionC.Text = "";
            lblPercentegeOfOptionD.Text = "";
        }

        private void TransparentBackColorOfOptions()
        {
            btnOptionA.BackColor=Color.Transparent;
            btnOptionB.BackColor=Color.Transparent;
            btnOptionC.BackColor=Color.Transparent;
            btnOptionD.BackColor=Color.Transparent;
        }

        private void EnabledHelpTools()
        {
            btnFifty.Enabled = true;
            isButtonFiftyClicked = false;
            NumberOfFiftyForQuestion = -1;
            btnCallAFreind.Enabled = true;
            isButtonCallClicked = false;
            NumberOfCallForQuestion = -1;
            btnAudience.Enabled = true;
            isButtonAudienceClicked = false;
            NumberOfAudienceForQuestion = -1;
        }

        private async  void btnStart_Click(object sender, EventArgs e)
        {
            List<stQuestion> ListQuestions = new List<stQuestion>(LoadQuestionsDataFromFile(PathOfEasyFile));
            
            if (cmbxDifficulty.SelectedIndex == -1)
            {
                return;
            }
            isReset = false;
            btnStart.Enabled = false;
            lblTimer.Visible = false;
            MessageBox.Show("Are you ready to answer to question " , "Question " , MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (cmbxDifficulty.SelectedIndex)
            {
                case 0:
                    ListQuestions = LoadQuestionsDataFromFile(PathOfEasyFile);
                    break;
                case 1:
                    ListQuestions = LoadQuestionsDataFromFile(PathOfMediumFile);
                    break;
                case 2:
                    ListQuestions = LoadQuestionsDataFromFile(PathOfHardFile);
                    break;
            }


            EnabledHelpTools();
            for (NumberOfQuestion= 0;NumberOfQuestion < 10;NumberOfQuestion++)
            {
                VisibleOptions();

                EnabledOptions();

                HideProgressBar();

                EmptyLabelPercentage();

                TransparentBackColorOfOptions();

                AnswerOfUser = '\0';
                
                tbxQuestion.Text =(NumberOfQuestion+1).ToString()+"-"+ ListQuestions[NumberOfQuestion].Question;
                btnOptionA.Text ="A - "+ ListQuestions[NumberOfQuestion].OptionA;
                btnOptionB.Text ="B - "+ ListQuestions[NumberOfQuestion].OptionB;
                btnOptionC.Text ="C - "+ ListQuestions[NumberOfQuestion].OptionC;
                btnOptionD.Text ="D - "+ ListQuestions[NumberOfQuestion].OptionD;

                if (!isButtonFiftyClicked)
                {
                    btnFifty.Enabled = true;
                }
                if(!isButtonCallClicked)
                {
                    btnCallAFreind.Enabled = true;
                }
                if (!isButtonAudienceClicked)
                {
                    btnAudience.Enabled = true;
                }
                Counter = 0;
                lblTimer.Visible = true;
                while (Counter < 30 && !isReset)
                {
                    Counter++;
                    lblTimer.Text = Counter.ToString();

                    await Task.Delay(500);
                }
                if (isButtonFiftyClicked && NumberOfFiftyForQuestion == NumberOfQuestion)
                {
                    FiftyFifty(ListQuestions[NumberOfQuestion]);
                    Counter = 0;
                    lblTimer.Visible = true;
                    while (Counter < 10)
                    {
                        Counter++;
                        lblTimer.Text = Counter.ToString();

                        await Task.Delay(500);
                    }
                }
                if (isButtonCallClicked && NumberOfCallForQuestion == NumberOfQuestion)
                {
                    CallAFriend();
                    Counter = 0;
                    lblTimer.Visible = true;
                    while (Counter < 10)
                    {
                        Counter++;
                        lblTimer.Text = Counter.ToString();

                        await Task.Delay(500);
                    }
                }
                if (isButtonAudienceClicked && NumberOfAudienceForQuestion == NumberOfQuestion)
                {
                    AudienceInsights();
                    Counter = 0;
                    lblTimer.Visible = true;
                    while (Counter < 10)
                    {
                        Counter++;
                        lblTimer.Text = Counter.ToString();

                        await Task.Delay(500);
                    }
                }
                if(isReset)
                {
                    
                    return;
                }
                ColorTheCorrectAnswer(ListQuestions[NumberOfQuestion]);
                if (isUserAnswerHasCorrect(ListQuestions[NumberOfQuestion]))
                {
                    MessageBox.Show("Your Answer is Correct", "Congratulations");
                    LabelOfLevels(NumberOfQuestion).BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your Answer is False reset to play Again!", "Wrong Answer");
                    return;
                }

                
                
                
            }
            MessageBox.Show("You win  one million dollar!","Congratulations",MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }


        private void btnFifty_Click(object sender, EventArgs e)
        {
            isButtonFiftyClicked = true;
            NumberOfFiftyForQuestion = NumberOfQuestion;
            btnFifty.Enabled=false;
        }

        private void btnCallAFreind_Click(object sender, EventArgs e)
        {
            isButtonCallClicked = true;
            NumberOfCallForQuestion = NumberOfQuestion;
            btnCallAFreind.Enabled=false;
        }

        private void btnAudience_Click(object sender, EventArgs e)
        {
            isButtonAudienceClicked = true;
            NumberOfAudienceForQuestion = NumberOfQuestion;
            btnAudience.Enabled=false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnOption_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor=Color.Aquamarine;
            switch(btn.Text[0])
            {
                case 'A':
                    AnswerOfUser = 'A';
                    
                    break;
                case 'B':
                    AnswerOfUser = 'B';
                    break;
                case 'C':
                    AnswerOfUser = 'C';
                    break;
                default:
                    AnswerOfUser = 'D';
                    break;
            }
            DisabledOptions();
        }

        private async void ColorTheCorrectAnswer(stQuestion question)
        {
            switch (question.CorrectOption[0])
            {
                case 'A':
                    btnOptionA.BackColor = Color.GreenYellow;

                    break;
                case 'B':
                    btnOptionB.BackColor = Color.GreenYellow;
                    break;
                case 'C':
                    btnOptionC.BackColor = Color.GreenYellow;
                    break;
                default:
                    btnOptionD.BackColor = Color.GreenYellow;
                    break;
            }
            await Task.Delay(2000);

        }

        private Label LabelOfLevels(int Number)
        {
            switch(Number)
            {
                case 0:
                    return lblLevel1;
                case 1:
                    return lblLevel2;
                case 2:
                    return lblLevel3;
                case 3:
                    return lblLevel4;
                case 4:
                    return lblLevel5;
                case 5:
                    return lblLevel6;
                case 6:
                    return lblLevel7;
                case 7:
                    return lblLevel8;
                case 8:
                    return lblLevel9;
                default:
                    return lblLevel10;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbxDifficulty.SelectedIndex = -1;
            btnStart.Enabled=true;
            tbxQuestion.Text = "";
            btnOptionA.Text = "";
            btnOptionB.Text = "";
            btnOptionC.Text = "";
            btnOptionD.Text = "";
            
            for(int j=0; j<10; j++)
            {
                LabelOfLevels(j).BackColor = Color.Transparent;
            }

            isReset = true;
            lblTimer.Visible = false;
            TransparentBackColorOfOptions();


        }
    }
}
