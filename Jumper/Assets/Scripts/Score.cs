using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text txt;
    public Platform Platform;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = Platform.s.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = Platform.s.ToString();
    }
}
