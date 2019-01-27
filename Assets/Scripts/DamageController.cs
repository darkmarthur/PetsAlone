using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class DamageController : MonoBehaviour
{
    public Text damageCounterLabel;
    public GameObject masterBandit;
    public GameObject masterShooter;
    public GameObject masterDamage;
    public int maxLife;
    private int cont = 0;

    void Start()
    {

    }

    void Update()
    {
        if (cont >= maxLife)
        {
            damageCounterLabel.text = "Pets Unsafe ｡ﾟ(TヮT)ﾟ｡";
            Destroy(masterBandit);
            Destroy(masterShooter);
            Destroy(masterDamage);
        }
        else
        {
            damageCounterLabel.text = "Damage: " + cont.ToString() + " / " + maxLife.ToString();
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("BanditTag"))
        {
            Destroy(col.gameObject);
            cont++;
        }
    }
}
