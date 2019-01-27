using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    public GameObject masterBandit;
    public GameObject masterShooter;
    public GameObject masterDamage;
    public float timeLeft;

    void Start()
    {

    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timerLabel.text = "Time over";
            Destroy(masterBandit);
            Destroy(masterShooter);
            Destroy(masterDamage);
        }
        else
        {
            timerLabel.text = "Seconds Left: " + timeLeft.ToString("n2");
        }

    }
}
