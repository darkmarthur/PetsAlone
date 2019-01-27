using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBox : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float speed = 10f;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1 * Vector3.left * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.W))
            transform.Rotate(-3, 0, 0);

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(3, 0, 0);

    }
}
