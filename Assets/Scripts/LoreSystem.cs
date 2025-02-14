using System.Collections.Generic;
using UnityEngine;

public class LoreSystem : MonoBehaviour
{
    private List<Lore> loreList = new List<Lore>();

    public void AddLore(string title, string content, bool isHidden = false, bool easterEgg = false)
    {
        loreList.add(new Lore(title, content, isHidden, easterEgg));
    }

    public void DiscoverLore(string title)
    {
        foreach (Lore lore in loreList)
        {
            if (lore.title == title)
            {
                lore.discovered = true;
                break;
            }
        }
    }

    public List<Lore> GetDiscoveredLore()
    {
        return loreList.FindAll(l => l.discovered);
    }

    public List<Lore> GetHiddenLore()
    {
        return loreList.FindAll(l => l.isHidden && !l.discovered);
    }

    public List<Lore> GetEasterEggs()
    {
        return loreList.FindAll(l => l.easterEgg);
    }

    private class Lore
    {
        public string title;
        public string content;
        public bool isHidden;
        public bool discovered;
        public bool easterEgg;

        public Lore(string title, string content, bool isHidden, bool easterEgg)
        {
            this.title = title;
            this.content = content;
            this.isHidden = isHidden;
            this.discovered = false;
            this.easterEgg = easterEgg;
        }
    }
}