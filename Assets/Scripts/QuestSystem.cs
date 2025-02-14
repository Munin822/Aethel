using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    private List<Quest> quests = new List<Quest>();

    public void AddQuest(string title, string description)
    {
        quests.Add(new Quest(title, description));
    }

    public void CompleteQuest(string title)
    {
        foreach (Quest quest in quests)
        {
            if (quest.title == title)
            {
                quest.isCompleted = true;
                break;
            }
        }
    }

    public List<Quest> GetActiveQuests()
    {
        return quests.FindAll(q => !q.isCompleted);
    }

    private class Quest
    {
        public string title;
        public string description;
        public bool isCompleted;

        public Quest(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.isCompleted = false;
        }
    }
}