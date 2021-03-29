using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursunKontrol : MonoBehaviour
{
   
    void Start()
    {
        playerr bullet = GameObject.FindGameObjectWithTag("Player").GetComponent<playerr>();
        GetComponent<Rigidbody>().AddForce(bullet.goToTarget() * 2000);
        transform.rotation = Quaternion.LookRotation(bullet.goToTarget());
        Destroy(gameObject, 2);
    }

   

}
