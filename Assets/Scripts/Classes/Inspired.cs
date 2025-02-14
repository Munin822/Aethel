using UnityEngine;

public class Inspired : MonoBehaviour
{
    public string className = "Inspired";
    public string[] abilities = { "Blood Magic", "Sacrifice Health" };

    public void UseAbility(string abilityName, GameObject target)
    {
        switch (abilityName)
        {
            case "Blood Magic":
                // Implement Blood Magic logic
                break;
            case "Sacrifice Health":
                // Implement Sacrifice Health logic
                break;
        }
    }
}