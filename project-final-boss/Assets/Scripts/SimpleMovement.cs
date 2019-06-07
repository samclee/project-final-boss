using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 0.005f;
    [SerializeField] private float BoostFactor = 4.0f;
    private float ModifiedSpeed;
    private Vector3 lastDirection;
    private Vector3 MovementDirection;

    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
        //Debug.Log(movement);
        this.ModifiedSpeed = this.Speed;
        if (Input.GetButton("Jump"))
        {
            this.ModifiedSpeed *= this.BoostFactor;
            //this.trail.widthMultiplier = this.BoostFactor;
        }

        /*else
        {
            if(this.trail.widthMultiplier >= 1.0f) {
                this.trail.widthMultiplier -= Time.deltaTime * this.TrailDecay;
            }
        }*/
        this.MovementDirection = new Vector3();
        if (Input.GetAxis("Horizontal") > 0)
        {
            this.MovementDirection.x = 0.15f;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            this.MovementDirection.x = -0.15f;
        }
        
        if (Input.GetAxis("Vertical") > 0)
        {
            this.MovementDirection.z = 0.15f;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            this.MovementDirection.z = -0.15f;
        }

        // this.MovementDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        if (this.MovementDirection.x == 0 && this.MovementDirection.z == 0)
        {
            this.gameObject.transform.Translate(this.lastDirection * Time.deltaTime*this.ModifiedSpeed);
            
        }
        else
        {
            this.gameObject.transform.Translate(this.MovementDirection * Time.deltaTime * this.ModifiedSpeed);
            this.lastDirection = this.MovementDirection;
        }
    }

    public float GetCurrentSpeed()
    {
        return this.ModifiedSpeed;
    }

    public Vector3 GetMovementDirection()
    {
        return this.MovementDirection;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
