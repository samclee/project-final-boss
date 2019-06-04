using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarController : MonoBehaviour
{
    public RectTransform healthbar;
    private float health = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        SetHP(health);
    }

    // Update is called once per frame
    void Update()
    {
        SetHP(health);
    }

    public void Damage(float damageTaken)
    {
        if (health > 0f)
        {
            health -= 0.1f;
        }
    }

    public void SetHP(float f)
    {
        healthbar.localScale = new Vector3(f, 1f, 1f);
    }
}