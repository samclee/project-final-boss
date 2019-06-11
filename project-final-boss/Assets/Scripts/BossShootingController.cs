﻿using System;
using System.Collections;
using UnityEngine;

public class BossShootingController : MonoBehaviour
{
    // How much damage is applied to an object when it is shot.
    public int gunDamage;
    // Controls how often the player can fire their weapon
    public float fireRate = .25f;
    // How far our ray will be cast into the scene.
    public float weaponRange = 50f;
    private Vector3 playerPos;
    // How many milliseconds before boss auto fires again
    private float coolDown = 4f;
    // The position at which our laser line will begin (empty GameObject).
    public GameObject eye;
    public GameObject player;
    public GameObject playerUI;
    public Transform gunEnd;
    // Used to determine how long we want the laser to remain visible in the
    // game view once the player has fired.
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    // A reference to an AudioSource for our gunshot sound effect
    private AudioSource gunAudio;
    private LineRenderer laserLine;
    // The time at which the player will be allowed to fire again after firing.
    private float nextFire;
    public Material color;
    public AudioClip clip;
    public GameObject model;

    private void Start()
    {
        //playerPos = player.transform.position;
        laserLine = eye.GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
        laserLine.material = color;
    }

    private void Update()
    {
        //Debug.Log(coolDown);
        coolDown -= Time.deltaTime;
        if (coolDown < 0)
        {
            Shoot();
            coolDown = 1f;
        }
        //else if (Math.Abs(coolDown - 0.5f) < 0.01)
        //{
        //    playerPos = player.transform.position;
        //}
    }

    private void Shoot()
    {
        // Wait a few milliseconds, then shoot so the player is incentivized to keep moving
        nextFire = Time.time + fireRate;
        StartCoroutine(ShotEffect());
        Vector3 rayOrigin = gunEnd.transform.position;
        RaycastHit hit;

        // Declare a starting point for our ray
        laserLine.SetPosition(0, gunEnd.position);
        // Aim at player
        Vector3 direction = (player.transform.position - gunEnd.transform.position).normalized;

        // Executes if our ray hits something
        // rayOrigin is where our ray begins (in this case, center of our camera's viewpoint).
        // Our ray is being cast forward from our camera viewport, hence fpsCam.transform.forward.
        // For our hit, using the out keyword allows us to store additional information from 
        // a function, in addition to its return type.
        // weaponRange is the distance in which we want to cast our ray.
        if (Physics.Raycast(rayOrigin, direction * weaponRange, out hit, weaponRange))
        {
            // Cast the second point of our ray to be what we hit
            laserLine.SetPosition(1, hit.point);

            PlayerDataUIController playerHealth = playerUI.GetComponent<PlayerDataUIController>();
            // If there was a health script attached
            if (playerHealth != null)
            {
                // Call the damage function of that script, passing in our gunDamage variable
                playerHealth.Damage(gunDamage);
            }
        }
        else
        {
            // Cast our ray to end 50 units forward if we don't hit anything
            laserLine.SetPosition(1, direction * weaponRange);
        }
        gunAudio.PlayOneShot(clip);
        model.GetComponent<ChickenAnimation>().AnimateShoot();
    }

    private IEnumerator ShotEffect()
    {
        laserLine.enabled = true;

        //  Causes our coroutine to wait for 0.7 seconds.
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
