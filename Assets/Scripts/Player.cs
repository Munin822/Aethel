using UnityEngine;

public class Player : MonoBehaviour
{
    public int strength = 10;
    public int magic = 10;
    public int dexterity = 10;

    private string characterClass;
    private string characterName;
    private string hairStyle;
    private string skinTone;
    private EquipmentSystem equipmentSystem;

    void Start()
    {
        characterClass = PlayerPrefs.GetString("CharacterClass");
        characterName = PlayerPrefs.GetString("CharacterName");
        hairStyle = PlayerPrefs.GetString("HairStyle");
        skinTone = PlayerPrefs.GetString("SkinTone");

        equipmentSystem = GetComponent<EquipmentSystem>();
    }

    public void EquipItem(string slot, Equipment item)
    {
        equipmentSystem.EquipItem(slot, item);
        UpdateSprite();
    }

    private void UpdateSprite()
    {
        // Update the character sprite based on the current equipment
    }

    public void UseAbility(string abilityName, GameObject target)
    {
        // Use ability logic
    }
}