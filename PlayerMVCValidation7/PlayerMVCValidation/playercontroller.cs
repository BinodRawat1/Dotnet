public class PlayerController
{
    public string SavePlayer(string name, int age, string email)
    {
        Player player = new Player(name, age, email);

        if (player.IsValid(out string errorMessage))
        {
            // In a real application, you might save this player to a database.
            return "Player information saved successfully!";
        }
        else
        {
            return "Error:\n" + errorMessage;
        }
    }
}
