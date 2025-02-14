using System.Collections.Generic;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    private Dictionary<string, Equipment> equipmentList = new Dictionary<string, Equipment>();

    public void EquipItem(string slot, Equipment item)
    {
        if (equipmentList.ContainsKey(slot))
        {
            equipmentList[slot] = item;
        }
        else
        {
            equipmentList.Add(slot, item);
        }
    }

    public List<Equipment> GetEquipmentBySlot(string slot)
    {
        return new List<Equipment>(equipmentList.Values);
    }

    public void UpgradeEquipment(string name)
    {
        foreach (KeyValuePair<string, Equipment> entry in equipmentList)
        {
            if (entry.Value.name == name)
            {
                entry.Value.upgradeLevel += 1;
                foreach (string key in entry.Value.stats.Keys)
                {
                    entry.Value.stats[key] += entry.Value.upgradeLevel * 2;
                }
                break;
            }
        }
    }
}

public class Equipment
{
    public string name;
    public string slot;
    public Dictionary<string, int> stats;
    public string[] classRestrictions;
    public int upgradeLevel;

    public Equipment(string name, string slot, Dictionary<string, int> stats, string[] classRestrictions, int upgradeLevel)
    {
        this.name = name;
        this.slot = slot;
        this.stats = stats;
        this.classRestrictions = classRestrictions;
        this.upgradeLevel = upgradeLevel;
    }
}