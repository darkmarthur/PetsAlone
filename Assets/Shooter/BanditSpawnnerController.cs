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
    }

    // Update is called once per frame
    void Update () {
        Invoke("newBandit", Random.Range(0, randomSeedSpawnTime));
    }

    void newBandit()
    {
        int banditType = Random.Range(0, randomSeedUnitInvoke);
        Instantiate(bandits[banditType]).transform.SetPositionAndRotation(transform.localPosition, transform.localRotation);
    }
}
