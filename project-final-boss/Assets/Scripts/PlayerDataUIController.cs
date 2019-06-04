using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDataUIController : MonoBehaviour
{
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
        setHP(45);
    }

    public void setHP(int hp)
    {
        hpText.text = hpTextPrefix + hp.ToString() + "%";
    }
}
