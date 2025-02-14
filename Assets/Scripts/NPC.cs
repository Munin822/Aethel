using UnityEngine;

public class NPC : MonoBehaviour
{
    public string faction;
    public string[] dialogue;

    public void Interact()
    {
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        foreach (string line in dialogue)
        {
            Debug.Log(line);
        }
    }
}