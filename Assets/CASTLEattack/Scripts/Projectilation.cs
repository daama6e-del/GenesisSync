using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectilation : MonoBehaviour

{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if (rigidbody == null) //It sugested to prevent error if it was nulled. But it is not needed because of the RequireComponent component of Rigidbody presnet.
        {
            rigidbody = GetComponent<Rigidbody>();
        }
        Vector3 forceDirection = transform.forward; //Direction of force

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange); //Velocity-change does not use mass of obj.
    }
    void OnCollisionEnter(Collision other) ///This will send a message to the system or trigger event.
    {
        print("Collides with " + other.gameObject.name);
        if (other.gameObject.CompareTag("Castle"))
        {
            //Instatiate explosion prefab projectile when contact game object 
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            // Then destroy the cannonball prefab to prevent continuous explosions
            Destroy(gameObject); 
        }
    }
}
