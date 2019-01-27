using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBandit : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocidad_bullet;
    void Start()
    {
        //Debug.Log(type);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad_bullet);
    }

}
