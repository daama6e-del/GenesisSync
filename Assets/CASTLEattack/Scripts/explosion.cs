using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider OtHeR)
    {
        Rigidbody rigidbody = OtHeR.GetComponent<Rigidbody>();
        if (rigidbody)
        {
            //rigidbody.AddExplosionForce
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
