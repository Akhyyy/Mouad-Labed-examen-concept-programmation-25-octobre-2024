using UnityEngine.InputSystem.XR;

public class AIVehicle : Vehicle
{
    private AIController aiController;

    void Start()
    {
        // Initialisation du contr�leur AI
        aiController = new AIController();
    }

    public void MakeMoveDecision()
    {
        
    }
}
