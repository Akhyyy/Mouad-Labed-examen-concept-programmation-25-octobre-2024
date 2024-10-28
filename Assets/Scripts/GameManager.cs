using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Attributs principaux
    public int totalLaps;
    public int playerPosition;

    // Singleton pour assurer une seule instance
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    void Start()
    {
       
        InitializeRace();
    }

    public void InitializeRace()
    {
        
    }

    public void EndRace()
    {
        
    }

    public void UpdatePlayerPosition()
    {
        
    }
}

