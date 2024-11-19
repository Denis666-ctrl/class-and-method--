public class MathOperations
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    private int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public int SubtractPublic(int num1, int num2)
    {
        return Subtract(num1, num2);
    }
}

public class User
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }

    public User(string userName, string email, int age, string country)
    {
        UserName = userName;
        Email = email;
        Age = age;
        Country = country;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MathOperations math = new MathOperations();
        int sum = math.Add(5, 3);
        int difference = math.SubtractPublic(5, 3);

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Разность: " + difference);

        User user = new User("Денис", "ddneprovskij02@gmail.com", 18, "Россия");
        Console.WriteLine("Пользователь: " + user.UserName + ", Email: " + user.Email + ", Возраст: " + user.Age + ", Страна: " + user.Country);
    }
}