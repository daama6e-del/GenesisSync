using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFX : MonoBehaviour
{
    public float Timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGO", Timer);
    }

    void DestroyGO()
    {
        Destroy(gameObject);
    }
 
}
