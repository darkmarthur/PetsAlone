using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using UnityEngine;

public class DamageController : MonoBehaviour
{
    public Text damageCounterLabel;
    public GameObject masterBandit;
    public GameObject masterShooter;
    public GameObject masterDamage;
    public int maxLife;
    private int cont = 0;
    private bool stillCounting = true;

    void Start()
    {

    }

    void Update()
    {
        if (cont >= maxLife)
        {
            stillCounting = false;
            damageCounterLabel.text = "Pets Unsafe ｡ﾟ(TヮT)ﾟ｡        PRESS 1 TO RESTART";
            Destroy(masterBandit);
            Destroy(masterShooter);
            //Destroy(masterDamage);
            if (Input.GetKeyDown("1"))
            {
                doShooting.killsCont = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            damageCounterLabel.text = "Damage: " + cont.ToString() + " / " + maxLife.ToString();
        }
    }

    public void OnCollisionEnter(Collision col)
    { 
        if (col.gameObject.CompareTag("BanditTag") && stillCounting)
        {
            Destroy(col.gameObject);
            cont++;
        }
    }
}
