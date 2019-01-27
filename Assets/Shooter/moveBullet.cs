using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveBullet : MonoBehaviour
{

    public float velocidad_bullet = 2;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * velocidad_bullet);
    }

}
