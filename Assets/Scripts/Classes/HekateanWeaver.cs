using UnityEngine;

public class HekateanWeaver : MonoBehaviour
{
    public string className = "Hekatean Weaver";
    public string[] abilities = { "Weave Magic", "Thread Manipulation" };

    public void UseAbility(string abilityName, GameObject target)
    {
        switch (abilityName)
        {
            case "Weave Magic":
                // Implement Weave Magic logic
                break;
            case "Thread Manipulation":
                // Implement Thread Manipulation logic
                break;
        }
    }
}