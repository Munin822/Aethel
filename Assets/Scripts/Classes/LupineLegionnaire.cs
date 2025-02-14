using UnityEngine;

public class LupineLegionnaire : MonoBehaviour
{
    public string className = "Lupine Legionnaire";
    public string[] abilities = { "Primal Strength", "Spirit of Lykos" };

    public void UseAbility(string abilityName, GameObject target)
    {
        switch (abilityName)
        {
            case "Primal Strength":
                // Implement Primal Strength logic
                break;
            case "Spirit of Lykos":
                // Implement Spirit of Lykos logic
                break;
        }
    }
}