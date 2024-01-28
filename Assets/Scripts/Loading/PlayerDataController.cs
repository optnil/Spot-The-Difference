
//contains functions to create, retrieve and update playerprefs

using UnityEngine;

public class PlayerDataController : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";
    private const string LevelKey = "Level";
    //private const string UsernameKey = "Username";

    // Create data
    public static void CreatePlayerData( int initialLevel, int initialHighScore)
    {
       // PlayerPrefs.SetString(UsernameKey, username);
        PlayerPrefs.SetInt(LevelKey, initialLevel);
        PlayerPrefs.SetInt(HighScoreKey, initialHighScore);
        PlayerPrefs.SetInt("MusicOn", 1);
        PlayerPrefs.SetInt("SFXOn", 1);
        PlayerPrefs.Save();
    }

    // Update data
    //public static void UpdateUsername(string newUsername)
   // {
     //   PlayerPrefs.SetString(UsernameKey, newUsername);
      //  PlayerPrefs.Save();
    //}

    public static void UpdateLevel(int newLevel)
    {
        PlayerPrefs.SetInt(LevelKey, newLevel);
        PlayerPrefs.Save();
    }

    public static void UpdateHighScore(int newHighScore)
    {
        PlayerPrefs.SetInt(HighScoreKey, newHighScore);
        PlayerPrefs.Save();
    }

    // Retrieve data
    //public static string GetUsername()
    //{
    //    return PlayerPrefs.GetString(UsernameKey, "DefaultUsername");
   // }

    public static int GetLevel()
    {
        return PlayerPrefs.GetInt(LevelKey, 1);
    }

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, 0);
    }

    // Delete data
    public static void DeletePlayerData()
    {
        //PlayerPrefs.DeleteKey(UsernameKey);
        PlayerPrefs.DeleteKey(LevelKey);
        PlayerPrefs.DeleteKey(HighScoreKey);
        PlayerPrefs.Save();
    }

    // Check if data exists
    public static bool DoesPlayerDataExist()
    {
        return  PlayerPrefs.HasKey(LevelKey) && PlayerPrefs.HasKey(HighScoreKey);
    }
}
