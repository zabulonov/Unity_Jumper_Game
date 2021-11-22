using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    public static Hero instance;
    float horisontal;
    public Rigidbody2D HeroRigid;
    public Platform Platform;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horisontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        HeroRigid.velocity = new Vector2(Input.acceleration.x * 10f, HeroRigid.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            PlayerPrefs.SetInt("SavedScore", Platform.s);
            PlayerPrefs.Save();
            Debug.Log("Game data saved!");
            SceneManager.LoadScene(0);
            //Debug.Log("test");
        }
    }
}
