using UnityEngine;

public class UmbrevianWraith : MonoBehaviour
{
    public string className = "Umbrevian Wraith";
    public string[] abilities = { "Shadow Manipulation", "Spy" };

    public void UseAbility(string abilityName, GameObject target)
    {
        switch (abilityName)
        {
            case "Shadow Manipulation":
                // Implement Shadow Manipulation logic
                break;
            case "Spy":
                // Implement Spy logic
                break;
        }
    }
}