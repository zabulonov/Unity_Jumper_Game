using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[3];
    private int CurSkin = 0;
    void Start()
    {
        CurSkin = PlayerPrefs.GetInt("CurSkin");
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[CurSkin];
    }
}
