using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour
{
    public InputField nameInput;
    public Dropdown classDropdown;
    public Dropdown hairDropdown;
    public Dropdown skinDropdown;

    private string selectedClass;
    private string characterName;
    private string hairStyle;
    private string skinTone;

    void Start()
    {
        classDropdown.onValueChanged.AddListener(delegate { OnClassSelected(); });
        hairDropdown.onValueChanged.AddListener(delegate { OnHairSelected(); });
        skinDropdown.onValueChanged.AddListener(delegate { OnSkinSelected(); });
    }

    public void OnClassSelected()
    {
        selectedClass = classDropdown.options[classDropdown.value].text;
    }

    public void OnHairSelected()
    {
        hairStyle = hairDropdown.options[hairDropdown.value].text;
    }

    public void OnSkinSelected()
    {
        skinTone = skinDropdown.options[skinDropdown.value].text;
    }

    public void CreateCharacter()
    {
        characterName = nameInput.text;
        PlayerPrefs.SetString("CharacterName", characterName);
        PlayerPrefs.SetString("CharacterClass", selectedClass);
        PlayerPrefs.SetString("HairStyle", hairStyle);
        PlayerPrefs.SetString("SkinTone", skinTone);
        SceneManager.LoadScene("GameWorld");
    }
}