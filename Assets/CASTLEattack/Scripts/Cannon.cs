using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cannon : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Animator animator; //Calls the animator parameter
    public Transform fireSocket; //Tracks direction and position of new projectiles.
    public float rotationRate = 90.0f;
    public ParticleSystem fireFX; //Calls the particle system for firing the cannon.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Haha got it without seeing the video instruction! I am genius!
        {
            print("You fired the cannon.");
            Fire();
        }

        float aimInput = Input.GetAxis("Horizontal"); //Gets input
        aimInput *= rotationRate * Time.deltaTime; //Makes it frame rate independent due to the public float above turning 90.0 degrees per second. Or implements a conversion.
        transform.Rotate(Vector3.forward * aimInput, Space.World); //The function to rotate the cannon itself.
    }

    void Fire()
    {
        animator.SetTrigger("Fire"); //Triggers it, as it says...
        Instantiate(projectilePrefab, fireSocket.position, fireSocket.rotation); //This simple line is all is needed to spawn any gameObject or prefab with script! How exiting.
        fireFX.Play(); //Plays the particle system for firing the cannon.
    }
}
