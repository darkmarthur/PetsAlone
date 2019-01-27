using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditSpawnnerController : MonoBehaviour {

    public int randomSeedSpawnTime;
    public int randomSeedUnitInvoke;
    public GameObject[] bandits;

    // Use this for initialization
    void Start ()
    {
        //Instantiate(bandits[0]).transform.SetPositionAndRotation(transform.localPosition, transform.localRotation);
        //newBandit();
        //InvokeRepeating("newBandit", 2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update () {
        Invoke("newBandit", Random.Range(0, randomSeedSpawnTime));
    }

    void newBandit()
    {
        int banditType = Random.Range(0, randomSeedUnitInvoke);
        //Debug.Log(banditType);
        //Debug.Log(randomSeedUnitInvoke);
        //Instantiate(bandits[banditType], Vector3(Random.Range(-4.5, 4.5), 0.3, 5), transform.rotation);

        Instantiate(bandits[banditType]).transform.SetPositionAndRotation(transform.localPosition, transform.localRotation);
    }
}
