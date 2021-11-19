using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void NextLvl(int _scenenumber)
    {
        SceneManager.LoadScene(_scenenumber);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
