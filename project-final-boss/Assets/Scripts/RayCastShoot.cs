using System;
using System.Collections;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    //TODO: Make some fields serialized for reuse with player and boss.
    // How much damage is applied to an object when it is shot.
    public int gunDamage;

    // Controls how often the player can fire their weapon
    public float fireRate = .25f;

    // How far our ray will be cast into the scene.
    public float weaponRange = 50f;

    public float hitForce = 100f;


    // The position at which our laser line will begin (empty GameObject).
    public Transform gunEnd;

    // A reference to our first person camera.
    private Camera fpsCam;

    // Used to determine how long we want the laser to remain visible in the
    // game view once the player has fired.
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);

    // A reference to an AudioSource for our gunshot sound effect
    private AudioSource gunAudio;

    private LineRenderer laserLine;

    // The time at which the player will be allowed to fire again after firing.
    private float nextFire;

    public RaycastShoot()
    {
    }

    private void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        //gunAudio = GetComponent<AudioSource>();

        // Store a reference to our camera, which is a child of our player GameObject
        fpsCam = GetComponentsInChildren<Camera>()[0];

        // Store where our shot is coming out of
        gunEnd = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)

        {
            nextFire = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            // Executes if our ray hits something
            // rayOrigin is where our ray begins (in this case, center of our camera's viewpoint).
            // Our ray is being cast forward from our camera viewport, hence fpsCam.transform.forward.
            // For our hit, using the out keyword allows us to store additional information from 
            // a function, in addition to its return type.
            // weaponRange is the distance in which we want to cast our ray.
            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
            {
                // Cast the second point of our ray to be what we hit
                laserLine.SetPosition(1, hit.point);
            }
            else
            {
                // Cast our ray to end 50 units forward if we don't hit anything
                laserLine.SetPosition(1, fpsCam.transform.forward * weaponRange);
            }
        }
    }

    private IEnumerator ShotEffect()
    {
        // TODO: play gunshot audio

        laserLine.enabled = true;

        //  Causes our coroutine to wait for 0.7 seconds.
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
