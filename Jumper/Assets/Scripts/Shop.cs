using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    private int money;
    private int skin_1 = 0, skin_2 = 0;
    private int CurSkin = 0;
    public Text txt;
    void Start()
    {
        money = PlayerPrefs.GetInt("SavedScore");
        skin_1 = PlayerPrefs.GetInt("Skin_1");
        skin_2 = PlayerPrefs.GetInt("Skin_2");
        CurSkin = PlayerPrefs.GetInt("CurSkin");
        Debug.Log("Game data loaded!");
    }
    void SaveInfo()
    {
        PlayerPrefs.SetInt("SavedScore", money);
        PlayerPrefs.SetInt("Skin_1", skin_1);
        PlayerPrefs.SetInt("Skin_2", skin_2);
        PlayerPrefs.SetInt("CurSkin", CurSkin);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
        txt.text = money.ToString();
    }
    public void Buy_skin_1()
    {
        if (money < 9)
        {
            Debug.Log("Нехватка коинов, скин 1");
            return;
        }
        else
        {
            money = money - 10;
            CurSkin = 1;
            Debug.Log("Каким то раком сменить скин 1");
            SaveInfo();
        }
            
    }
    public void Buy_skin_2()
    {
        if (money < 24)
        {
            Debug.Log("Нехватка коинов, скин 2");
            return;
        }
        else
        {
            money = money - 25;
            CurSkin = 2;
            Debug.Log("Каким то раком сменить скин 2");
            SaveInfo();
        }

    }
    public void SelectDefault()
    {
        Debug.Log("Каким то раком сменить скин 0");
        CurSkin = 0;
        SaveInfo();
    }
}
