using WinFormsApp4.Models;
using WinFormsApp4.Services;
namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private LoginControl loginControl;
        private RegisterControl registerControl;
        private readonly MainChatControl mainChatControl;

        private AppDataBase dataBase = new();
        private AppUser? currentuser;
        private AiChat? currentChat;

        public Form1()
        {
            InitializeComponent();
            
            loginControl = new LoginControl();
            registerControl = new RegisterControl();
            mainChatControl = new MainChatControl();

            dataBase = DatabaseService.Load();

            loginControl.Dock = DockStyle.Fill;
            registerControl.Dock = DockStyle.Fill;
            mainChatControl.Dock = DockStyle.Fill;
           
            loginControl.OpenRegister += ShowRegister;
            loginControl.OnLoginRequested += LoginUsers;

            registerControl.OpenLogin += ShowLogin;
            registerControl.OnSignupRequested += RegisterUser;


           ShowRegister();

        }
        private void ShowLogin()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(loginControl);
        }
        private void ShowRegister()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(registerControl);
        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }
        private void ShowMainChat()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(mainChatControl);
        }
        private void RegisterUser(string email,string username,string password)
        {
            if (string.IsNullOrWhiteSpace(email) 
                ||   string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля !!!");
                return;
            }
            bool userExists = dataBase.Users.Any(u => u.Email == email || u.Username == username);
            if(userExists)
            {
                MessageBox.Show("Пользователь с таким email уже существует");
                return;
            }
            AppUser newUser = new()
            {
                Id = dataBase.Users.Count > 0 ? dataBase.Users.Max(u => u.Id) + 1 : 1,
                Email = email,
                Username = username,
                CreatedAt = DateTime.Now,
                Password = password,
            };
            dataBase.Users.Add(newUser);
            DatabaseService.Save(dataBase);
            MessageBox.Show("Регистрация успешна!");
            ShowLogin();
        }
        private void LoginUsers(string email, string password)
        {
            AppUser? user = dataBase.Users.FirstOrDefault(u => u.Email == email
                && u.Password == password);
            if (user == null)
            {
                MessageBox.Show("Неверный пароль или email");
                return;
            }
            currentuser = user;
            MessageBox.Show($"Добро пожаловать, {currentuser.Username}!");
            ShowMainChat();
        }
    }
}
