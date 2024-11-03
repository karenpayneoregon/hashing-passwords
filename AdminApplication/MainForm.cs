using System.ComponentModel;
using System.Text.Json;
using AdminApplication.Classes;
using AdminApplication.Data;
using AdminApplication.Models;
using Bogus;
// ReSharper disable VariableHidesOuterVariable

namespace AdminApplication;

public partial class MainForm : Form
{
    private BindingList<User> _usersBindingList = [];
    private BindingSource _usersBindingSource = new();
    private List<User> _usersList = [];
    public MainForm()
    {
        InitializeComponent();
        
        using var context = new Context();

        _usersBindingList = new BindingList<User>(context.User.ToList());
        _usersBindingSource.DataSource = _usersBindingList;
        UserNameTextBox.DataBindings.Add("Text", _usersBindingSource, "Name", true);
        PasswordTextBox.DataBindings.Add("Text", _usersBindingSource, "Password", true);
        BindingNavigator1.BindingSource = _usersBindingSource;

        
        BindingNavigator1.AddItemButton.Click += (sender, e) =>
        {
            _usersBindingSource.CancelEdit();
            User user = MockedUser();
            
            using var context = new Context();
            context.User.Attach(user);
            context.SaveChanges();
            _usersList.Add(user);
            _usersBindingList = new BindingList<User>(context.User.ToList());
            _usersBindingSource.DataSource = _usersBindingList;
            File.WriteAllText("UsersExposed.json", JsonSerializer.Serialize(_usersList, Options));
            Dialogs.Information(this, "Added user","","Done");
        };

        ActiveControl = label1;

    }

    public static JsonSerializerOptions Options => new() { WriteIndented = true };
    public static User MockedUser()
    {

        var faker = new Faker<User>().Rules((f, b) =>
        {
            b.Name = f.Person.UserName;
            b.Password = f.Internet.Password();
        });

        return faker.Generate(1).FirstOrDefault()!;
    }
}
