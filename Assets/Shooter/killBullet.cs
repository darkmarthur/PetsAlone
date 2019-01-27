using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class killBullet : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("BanditTag"))
        {
            Destroy(col.gameObject);
            doShooting.killsCont++;
        }
        else if (col.gameObject.name == "Ground" || col.gameObject.name.Contains("roman_floor"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
