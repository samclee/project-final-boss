using System;
using System.Collections;
using UnityEngine;

public enum ShotOrigin { Player, Boss }

public class RaycastShoot : MonoBehaviour
{
    public ShotOrigin shotOrigin;
    //TODO: Make some fields serialized for reuse with player and boss.
    // How much damage is applied to an object when it is shot.
    public float gunDamage;

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

    private void Start()
    {
        laserLine = GetComponentsInChildren<LineRenderer>()[0];
        //gunAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (shotOrigin == ShotOrigin.Boss && Input.GetKeyDown("space") && Time.time > nextFire)
        {
            // Boss
            Shoot();
        }
        else if (shotOrigin == ShotOrigin.Player && Input.GetButtonDown("Fire1"))
        {
            // Player
            Shoot();
        }
    }

    private void Shoot()
    {
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
        if (Physics.Raycast(rayOrigin, gunEnd.transform.forward, out hit, weaponRange))
        {
            // Cast the second point of our ray to be what we hit
            laserLine.SetPosition(1, hit.point);

            if (shotOrigin == ShotOrigin.Player)
            {
                BossHealthBarController bossHealth = hit.collider.GetComponent<BossHealthBarController>();
                // Reference to a health script attached to the collider we hit

                // If there was a health script attached
                if (bossHealth != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    bossHealth.Damage(gunDamage);
                }
            }
            else if (shotOrigin == ShotOrigin.Boss)
            {
                PlayerDataUIController playerHealth = hit.collider.GetComponent<PlayerDataUIController>();
                // If there was a health script attached
                if (playerHealth != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    playerHealth.Damage(gunDamage);
                }
            }
        }
        else
        {
            Debug.Log("no hit");
            // Cast our ray to end 50 units forward if we don't hit anything
            laserLine.SetPosition(1, gunEnd.transform.forward * weaponRange);
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
