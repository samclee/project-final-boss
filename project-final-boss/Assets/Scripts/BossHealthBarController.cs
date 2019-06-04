using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarController : MonoBehaviour
{
    public RectTransform healthbar;
    // Start is called before the first frame update
    void Start()
    {
        setHP(0.40f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setHP(float f)
    {


        healthbar.localScale = new Vector3(f, 1f, 1f);
    }
}
