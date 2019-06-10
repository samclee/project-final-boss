using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAnimation : MonoBehaviour
{
    private Animator anim;
    public GameObject player;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // For some reason, chicken animation flips the chicken and I can't flip it. So forward is actually backwords
        var Angle = Vector3.SignedAngle(this.transform.forward * -1, this.transform.position - player.transform.position, Vector3.up);
        this.transform.Rotate(new Vector3(0, Angle * rotationSpeed, 0));
    }

    public void AnimateShoot() {
        anim.Play("Attack", 0);
    }
}
