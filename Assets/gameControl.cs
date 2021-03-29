using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameControl : MonoBehaviour
{
    public GameObject hedef;
   public Vector3 random;
   
   
    void Start()
    {
        StartCoroutine(created());
    }

 
   IEnumerator created()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for(int i = 0; i < 1; i++)
            {
                Vector3 pointt = new Vector3( random.x, random.y, Random.Range(-random.z,random.z));
                Instantiate(hedef, pointt, Quaternion.identity);
                yield return new WaitForSeconds(10);
            }
            yield return new WaitForSeconds(10);
        }
    }
  
   
}
