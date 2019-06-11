using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHealthBarController : MonoBehaviour
{
    public RectTransform healthbar;
    private float health = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Damage(float damageTaken)
    {
        health -= damageTaken;
        setHP(health);
        if (health < 0f)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    public void setHP(float f)
    {
        healthbar.localScale = new Vector3(f, 1f, 1f);
    }
}