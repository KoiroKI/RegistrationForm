using System;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Wszystkie pola są wymagane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Rejestracja zakończona sukcesem!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            usernameTextBox.Clear();
            passwordTextBox.Clear();
            emailTextBox.Clear();
        }
    }
}
