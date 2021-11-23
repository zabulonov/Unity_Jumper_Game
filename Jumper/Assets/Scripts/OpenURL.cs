using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void Open_URL(string _url)
    {
        Application.OpenURL(_url);
    }
}
