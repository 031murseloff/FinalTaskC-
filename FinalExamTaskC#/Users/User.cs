namespace FinalExamTaskC_.Users;

public class User
{
    public User(int id, string name, string surname, string email, string phone)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public override string ToString() => $"Name: {Name}\nSurname: {Surname}\nEmail: {Email}\nPhone: {Phone}";
   




}
