using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float ForceJump;
    public int s = 0;
    public GameObject sound;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Hero.instance.HeroRigid.velocity = Vector2.up * ForceJump;
            Instantiate(sound, transform.position, Quaternion.identity);
        } 
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            s++;
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
    void Awake()
    {
        s = PlayerPrefs.GetInt("SavedScore");
    }
}
