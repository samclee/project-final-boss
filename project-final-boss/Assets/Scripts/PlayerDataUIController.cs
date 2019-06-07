using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataUIController : MonoBehaviour
{
    private int health = 100;
    public Text hpText;
    private string hpTextPrefix = "HP: ";
    private string spdTextPrefix = "SPD: ";
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Damage(int damageTaken)
    {
        if (health > 0)
        {
            health -= damageTaken;
            setHP(health);
        }
    }

    public void setHP(int hp)
    {
        Debug.Log(health);
        hpText.text = hpTextPrefix + hp.ToString() + "%";
    }
}
