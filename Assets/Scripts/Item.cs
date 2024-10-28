using UnityEngine;

public abstract class Item : MonoBehaviour
{
    // Méthode abstraite pour activer l'effet de l'objet
    public abstract void ActivateEffect(Vehicle target);
}
public class SpeedBoost : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique l'effet de boost de vitesse au véhicule cible
    }
}

public class Shield : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique l'effet de bouclier pour protéger le véhicule
    }
}

public class Missile : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Lance un missile pour atteindre un véhicule cible
    }
}

public class OilSlick : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique un ralentissement au véhicule qui passe sur la tache d’huile
    }
}

public class EMP : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Désactive les véhicules à l'avant sauf ceux avec un bouclier
    }
}
