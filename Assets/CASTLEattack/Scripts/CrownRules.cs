using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[RequireComponent(typeof(Rigidbody))]

public class CrownRules : MonoBehaviour
{

    public GameObject SupriseFX;
    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision other) ///This will send a message to the system or trigger event.
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Score score = FindObjectOfType<Score>();
            if (score)
            {
                score.Endlevel();
                //print("Level Ended!!!!!!!!!!!!!!"); //tester 
            }
            Instantiate(SupriseFX, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity); //Keep an eye on this, make this optional-ready. Best way to show you won I guess
            Invoke("DestroyGameObject", 1f);
        }
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
