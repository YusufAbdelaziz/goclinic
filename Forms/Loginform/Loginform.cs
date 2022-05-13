﻿using goclinic.Repos;


namespace goclinic.Forms
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void OpenSignupButtonClick(object sender, EventArgs e)
        {
            Form signup = new Signupform();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void SigninButtonClick(object sender, EventArgs e)
        {
            bool loginResults = UserRepository.LoginQueryAndMakeUser(username: usernameTextBox.Texts, password: passwordTextBox.Texts);
                if (loginResults)
                {
                    MessageBox.Show("تم الدخول بنجاح");
                    Form resultsAndPatients = new ResultsAndPatient();
                    this.Hide();
                    resultsAndPatients.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم خطأ او كلمة السر");
                }

        }

    }
}

