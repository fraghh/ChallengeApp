User user1 = new User("adam","1");
User user2 = new User("tom", "1");
User user3 = new User("rom", "1");


//user1.Login = "marek";
user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(2);

var result = user1.Result;

Console.WriteLine(result);
class User
{


    private List<int> score = new List<int>();
    


    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.Name = "-";
        
    }
    
    public string Login { get; private set; }
    public string Password { get; private set; }
    public string Name { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }



    public void AddScore(int number)
    {
        this.score.Add(number);
    }
    
    
    
    
    
    
  
    
        
    
    
    
    }


    