using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerr : MonoBehaviour
{
    float horizontal, vertical,timeFire=1,basroot=0;
    GameObject bas;
    Vector3 vect;
    bool controlFire = false;
    public GameObject kursun, nisan;
    RaycastHit hit;


    void Start()
    {
        vect = new Vector3();
        bas = GameObject.Find("Kafa").gameObject;
 
    }


    void Update()
    {
        hareketEt();
        rayCizdir();
   
        if (Input.GetMouseButton(0))
        {
            timeFire += Time.deltaTime;
            if (timeFire > 0.7f)
            {
                Instantiate(kursun, nisan.transform.position, Quaternion.identity);
                timeFire = 0;
            }
            controlFire = true;
        }

    }
    void hareketEt()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vect.Set(horizontal, 0, vertical);
        transform.Translate(vect * Time.deltaTime * 100);

        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * 150, 0);
        basroot += Input.GetAxis("Mouse Y") * Time.deltaTime * 150 * -1;
       // basroot = Mathf.Clamp(basroot, -30, 30);
      //  bas.transform.eulerAngles = new Vector3(basroot, transform.eulerAngles.y, 0);
    }
    void rayCizdir()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {
            Debug.Log("seen");
        }
        else
        {
            Debug.Log("not see");
        }
        Debug.DrawRay(ray.origin,ray.GetPoint(1000));
        Debug.DrawLine(nisan.transform.position,hit.point);
    }
    public Vector3 goToTarget() 
    {
        return (hit.point - nisan.transform.position).normalized;
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "boom")
        {
            SceneManager.LoadScene("Level1");
        }
        if (col.tag == "sucessful")
        {
            SceneManager.LoadScene("End");
        }
       
    }
    
}
