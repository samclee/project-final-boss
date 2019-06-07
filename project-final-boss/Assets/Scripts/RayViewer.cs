using UnityEngine;
using System.Collections;

public enum ShotOrigin { Player, Boss }

public class RayViewer : MonoBehaviour
{
    public ShotOrigin shotOrigin;

    public float weaponRange = 50f;                       // Distance in Unity units over which the Debug.DrawRay will be drawn

    private Camera fpsCam;                                // Holds a reference to the first person camera

    public GameObject origin;

    public GameObject player;

    void Start()
    {
        // Get and store a reference to our Camera by searching this GameObject and its parents
        //fpsCam = GetComponentsInChildren<Camera>()[0];
    }


    void Update()
    {
        // Create a vector at the center of our camera's viewport
        //Vector3 lineOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        Vector3 lineOrigin = origin.transform.position;
        if (shotOrigin == ShotOrigin.Boss)
        {
            // Aim at player
            Vector3 direction = (player.transform.position - origin.transform.position);
            Debug.DrawRay(lineOrigin, direction * weaponRange, Color.blue);
        }
        else
        {
            // Draw a line in the Scene View  from the point lineOrigin in the direction of fpsCam.transform.forward * weaponRange, using the color green
            Debug.DrawRay(lineOrigin, origin.transform.forward * weaponRange, Color.green);
        }
    }
}