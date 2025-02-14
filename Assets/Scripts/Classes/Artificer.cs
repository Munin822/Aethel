using UnityEngine;

public class Artificer : MonoBehaviour
{
    public string className = "Artificer";
    public string[] abilities = { "Magitech Weapons", "Gadgets" };

    public void UseAbility(string abilityName, GameObject target)
    {
        switch (abilityName)
        {
            case "Magitech Weapons":
                // Implement Magitech Weapons logic
                break;
            case "Gadgets":
                // Implement Gadgets logic
                break;
        }
    }
}