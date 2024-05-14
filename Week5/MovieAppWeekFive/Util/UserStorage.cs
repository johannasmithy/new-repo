class UserStorage
{
    public Dictionary<int, User> users = [];

    public int idCounter = 1;

    public UserStorage()
    {
        User user1 = new(idCounter, "Johanna", "pass1", "user"); idCounter++;
        User user2 = new(idCounter, "Derek", "pass2", "user"); idCounter++;
        User user3 = new(idCounter, "Jasper", "pass3", "admin"); idCounter++;

        
        users.Add(user1.Id, user1);
        users.Add(user2.Id, user2);
        users.Add(user3.Id, user3);
    }
}