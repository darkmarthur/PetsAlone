using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveBullet : MonoBehaviour {

    public float velocidad_bullet = 2;
    //public int type;

    /*
    public moveBullet(int bullet_type)
    {
        type = bullet_type;
    }
    */

	// Use this for initialization
	void Start () {
		//Debug.Log(type);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * velocidad_bullet);
	}

    /*
    public void setType(int type)
    {
        this.type = type;
        Debug.Log(type);
    }
    */
    
}
