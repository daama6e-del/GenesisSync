using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectilation : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (rigidbody == null) //It sugested to prevent error if it was nulled. But it is not needed because of the RequireComponent component of Rigidbody presnet.
        {
            rigidbody = GetComponent<Rigidbody>();
        }
        Vector3 forceDirection = transform.right;

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange); //Velocity-change does not use mass of obj.
    }
    void  OnCollisionEnter(Collision other) ///This will send a message to the system or trigger event.
    {
        print("Coolides with " +other.gameObject.name);
        if (other.gameObject.CompareTag("Castle"))
        {
            Destroy(other.gameObject); //This is deleting blocks it touches.
        }
    } 
}
