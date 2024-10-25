using UnityEngine;

public abstract class Item : MonoBehaviour
{
    // M�thode abstraite pour activer l'effet de l'objet
    public abstract void ActivateEffect(Vehicle target);
}
public class SpeedBoost : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique l'effet de boost de vitesse au v�hicule cible
    }
}

public class Shield : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique l'effet de bouclier pour prot�ger le v�hicule
    }
}

public class Missile : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Lance un missile pour atteindre un v�hicule cible
    }
}

public class OilSlick : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // Applique un ralentissement au v�hicule qui passe sur la tache d�huile
    }
}

public class EMP : Item
{
    public override void ActivateEffect(Vehicle target)
    {
        // D�sactive les v�hicules � l'avant sauf ceux avec un bouclier
    }
}
