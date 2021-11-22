using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCoins : MonoBehaviour
{
    int score;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("SavedScore");
        txt.text = score.ToString();
        Debug.Log("Game data loaded!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

