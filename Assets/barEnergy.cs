using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barEnergy : MonoBehaviour
{
    public Image img;
   
    public float fil;
  

    void Start()
    {
        fil = 1f;
     
    }

  
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            fil -= Time.deltaTime * 0.01f;
            img.fillAmount = fil;
        }
       
       
    }
  
}
