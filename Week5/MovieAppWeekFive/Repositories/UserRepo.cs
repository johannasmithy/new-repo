using System.Data.SqlClient;
class UserRepo
{
    private readonly string _connectionString;
    
    //Dependency injection -> Constructor Injection
    public UserRepo(string connString)
    {
        _connectionString = connString;
    }

    public User AddUser(User u)
    {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "INSERT INTO dbo.[User] OUTPUT inserted.* VALUES (@Username, @Password, @Role)";
        
        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Username", u.Username);
        cmd.Parameters.AddWithValue("@Password", u.Password);
        cmd.Parameters.AddWithValue("@Role", u.Role);
        
        //Execute the Query
        //cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)

        using SqlDataReader reader = cmd.ExecuteReader();
       
        //Extract the Results
        if(reader.Read())
        {
            //If Read() found data, then extract it.
            User newUser = BuildUser(reader);
            
            return newUser;
        }
        else
        {
            //Else Read() found nothing. Insert failed
            return null;
        }

        
    }

    public User GetUser(int id)
    
    {
        try
        {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "SELECT * FROM dbo.[User] WHERE Id = @Id";

        //Set up SqlCommand Object
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("Id", id);

        //Execute the Query 
        using var reader = cmd.ExecuteReader();

        //Extract the Results
        if(reader.Read())
        {
            User newUser = BuildUser(reader);
            return newUser;
        }
        return null;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
           
    }
    public List<User>? GetAllUser()
    {
        List<User> users = [];
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[User]";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here 

            //Extract the Results
            while (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                User newUser = BuildUser(reader);

                //don't return! Instead add to list
                users.Add(newUser);
            }
            return users;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
        
    }
    //Helper Method
    private static User BuildUser(SqlDataReader reader)
    {
        User newUser = new();
        newUser.Id = (int)reader["Id"];
        newUser.Username = (string)reader["Username"];
        newUser.Password = (string)reader["Password"];
        newUser.Role = (string)reader["Role"];
        return newUser;
    }

    public User? UpdateUser(User updatedUser)
    {
        try
        {

          //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "UPDATE dbo.[User] SET Username = @Username, Password = @Password, Role = @Role OUTPUT inserted.* WHERE Id = @Id";
        
        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Id", updatedUser.Id);
        cmd.Parameters.AddWithValue("@Username", updatedUser.Username);
        cmd.Parameters.AddWithValue("@Password", updatedUser.Password);
        cmd.Parameters.AddWithValue("@Role", updatedUser.Role);
        
        //Execute the Query
        //cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)

        using var reader = cmd.ExecuteReader();
       
        //Extract the Results
        if(reader.Read())
        {
            //If Read() found data, then extract it.
            User newUser = BuildUser(reader);     
            return newUser;
        }
            return null;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    
        
    }
    public User? DeleteUser(User u)
    {

        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "DELETE FROM dbo.[User] OUTPUT deleted.* WHERE Id = @Id";
        
        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Id", u.Id);
        
        //Execute the Query
        using var reader = cmd.ExecuteReader();
       
        //Extract the Results
        if(reader.Read())
        {
            
            User newUser = BuildUser(reader);  
            return newUser;
        }
        else
        {
            //Else Read() found nothing. Insert failed
            return null;
        }
    }
}