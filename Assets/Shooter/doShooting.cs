using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class doShooting : MonoBehaviour
{
    public Text killsCounterLabel;
    public float waitBeforeShot;
    public GameObject[] projectiles;
    public static int killsCont = 0;


    void Start()
    {

    }

    void Update()
    {
        killsCounterLabel.text = "Kiils: " + killsCont.ToString();
        if (Input.GetKeyDown("j"))
        {
            Instantiate(projectiles[0]).transform.SetPositionAndRotation(transform.localPosition + new Vector3(0, 0, -2), transform.localRotation);
        }
        else if (Input.GetKeyDown("k"))
        {
            Instantiate(projectiles[1]).transform.SetPositionAndRotation(transform.localPosition + new Vector3(0, 0, -2), transform.localRotation);
        }
        else if (Input.GetKeyDown("l"))
        {
            Instantiate(projectiles[2]).transform.SetPositionAndRotation(transform.localPosition + new Vector3(0, 0, -2), transform.localRotation);
        }
    }

    IEnumerator waitShot()
    {
        yield return new WaitForSeconds(waitBeforeShot);
    }
}
