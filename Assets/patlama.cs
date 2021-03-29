using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlama : MonoBehaviour
{
    public GameObject explosion;//patlama
     void OnTriggerEnter(Collider col)
    {
        if(col.tag != "boom")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
