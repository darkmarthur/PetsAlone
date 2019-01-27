using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            timerLabel.text = "Time over         PRESS 1 TO RESTART"; 
            Destroy(masterBandit);
            Destroy(masterShooter);
            Destroy(masterDamage);
            if (Input.GetKeyDown("1"))
            {
                doShooting.killsCont = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
        else
        {
            timerLabel.text = "Seconds Left: " + timeLeft.ToString("n2");
        }

    }
}
