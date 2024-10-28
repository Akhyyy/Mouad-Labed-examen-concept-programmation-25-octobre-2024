using UnityEngine.InputSystem.XR;

public class AIVehicle : Vehicle
{
    private AIController aiController;

    void Start()
    {
        // Initialisation du contrôleur AI
        aiController = new AIController();
    }

    public void MakeMoveDecision()
    {
        
    }
}
