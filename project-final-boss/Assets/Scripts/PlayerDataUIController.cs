using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        health -= damageTaken;
        setHP(health);

        if (health < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void setHP(int hp)
    {
        hpText.text = hpTextPrefix + hp.ToString() + "%";
    }
}
