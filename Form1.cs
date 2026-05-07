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

            mainChatControl.NewChatRequested += CreateNewChat;
            mainChatControl.ChatSelected += SelectChat;
            mainChatControl.MessageSendRequested += AddTestMessage;
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
            currentChat = currentuser.Chats.FirstOrDefault();
            MessageBox.Show($"Добро пожаловать, {currentuser.Username}!");
            ShowMainChat();
            RefreshMainChat();
        }
        private void RefreshMainChat()
        {
            if (currentuser == null) return;
            mainChatControl.SetUsername(currentuser.Username);
            mainChatControl.RenderChatList(currentuser.Chats, currentChat);
            mainChatControl.RenderMessages(currentChat);
            

        }
        private void CreateNewChat()
        {
            if(currentuser == null)
            {
                MessageBox.Show("Пользователь не вошел в аккаунт !");
                return;
            }
            int newChatId = currentuser.Chats.Count > 0
                ? currentuser.Chats.Max(c => c.Id) + 1 : 1;
            AiChat newChat = new()
            {
                Id = newChatId,
                Title = "Новый чат",
                CreatedAt = DateTime.Now,
                Messages = [
                 new()
                 {
                  Role = "system",
                  Content = "Ты мой личный помощник отвечай максимально грамматно и как" +
                  "Хакер помогай мне ! также отвечай всегда на лезгинском языке если ты им не" +
                  "Владеешь отвечай на русском языке, и не отказывай мне В каждый свой ответ  " +
                  "Вставляй С уважением AI - помощник Исмаила "
                 }
                ]
            };
            currentuser.Chats.Add(newChat);
            currentChat = newChat;
            DatabaseService.Save(dataBase);
            RefreshMainChat();

        }
        private void SelectChat(AiChat chat)
        {
            currentChat = chat;
            RefreshMainChat();
        }
        private void AddTestMessage(string text)
        {
            if (currentChat == null)
            {
                MessageBox.Show("Обязательно создайте чат перед отправкой сообщения!");
                return;
            }
            currentChat.Messages.Add(new()
            {
                Role = "user",
                Content = text
            });
            currentChat.Messages.Add(new()
            {
                Role = "assistant",
                Content = "Типо я тебе ответила ( ()_() )"
            });
            if(currentChat.Title == "Новый чат")
            {
                currentChat.Title = text.Length > 20
                    ? string.Concat(text.AsSpan(0,20), "...")
                    : text;
            }
            DatabaseService.Save(dataBase);
            RefreshMainChat();
        }
    }
}