using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelect : MonoBehaviour
{
    /*chọn nhân vật
    public GameObject[] skins;
    public int selectedCharacter;
    public Character[] characters;
    
    public Button unlockButton;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI coinsText;
     
    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject player in skins)//từ obj đầu đến list skins

            player.SetActive(false);

        skins[selectedCharacter].SetActive(true);

        foreach(Character c in characters)
        {
            if (c.price == 0)//nếu tiền = 0 thì khóa
                c.isUnlocked = true;
            else
            {
                c.isUnlocked = PlayerPrefs.GetInt(c.name, 0) == 0 ? false : true;
            }
        }
        //sau khi unlock thành công thì update lại tiền cũng như nhân vật
        UpdateUI();
    }

    
    public void UpdateUI()
    {
        coinsText.text = "Coins: " + PlayerPrefs.GetInt("NumberOfCoins", 0);
        nameText.text = characters[selectedCharacter].name;
        if (characters[selectedCharacter].isUnlocked == true)//mở khóa = true
            unlockButton.gameObject.SetActive(false);

    }
    */
}
