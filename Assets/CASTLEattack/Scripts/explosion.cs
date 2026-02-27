using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float force, radius, modifier;
    public GameObject explosionFX;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyExplosion", 0.1f); //pff thats why i had teh explosion script also on the cannon ball itself

    }

    void OnTriggerEnter(Collider OtHeR)
    {
        Rigidbody rigidbody = OtHeR.GetComponent<Rigidbody>();
        if (rigidbody)
        {
            rigidbody.AddExplosionForce(force, transform.position, radius, modifier, ForceMode.VelocityChange);
        }
        Instantiate(explosionFX, transform.position, Quaternion.identity);
    }

    void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
