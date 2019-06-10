using System;
using System.Collections;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    //TODO: Make some fields serialized for reuse with player and boss.
    // How much damage is applied to an object when it is shot.
    public float gunDamage;
    // Controls how often the player can fire their weapon
    public float fireRate = .25f;
    // How far our ray will be cast into the scene.
    public float weaponRange = 50f;
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

    // Plays sound
    private AudioSource[] Sources;

    private void Start()
    {
        laserLine = GetComponentsInChildren<LineRenderer>()[0];
        fpsCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //gunAudio = GetComponent<AudioSource>();
        Cursor.visible = false;

        Sources = GetComponents<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Sources[0].Play();

        nextFire = Time.time + fireRate;
        StartCoroutine(ShotEffect());
        Vector3 rayOrigin = gunEnd.transform.position;
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

            // Reference to a health script attached to the collider we hit
            BossHealthBarController bossHealth = hit.collider.GetComponent<BossHealthBarController>();

            // If there was a health script attached
            if (bossHealth != null)
            {
                // Call the damage function of that script, passing in our gunDamage variable
                bossHealth.Damage(gunDamage);
                Sources[1].Play();
            }
        }
        else
        {
            // Cast our ray to end 50 units forward if we don't hit anything
            laserLine.SetPosition(1, fpsCam.transform.forward * weaponRange);
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
