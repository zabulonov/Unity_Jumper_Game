using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform HeroPos;
    
    void Update()
    {
        if (HeroPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, HeroPos.position.y, transform.position.z);
        }
    }
}
