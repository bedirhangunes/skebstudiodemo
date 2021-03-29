using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyCol : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;
    public Transform  nisan;
    public Rigidbody kursunn;
    bool fireControl=false;
    RaycastHit hit;
    float atiszaman = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
    }

  
    void Update()
    {
        agent.SetDestination(target.transform.position);
        if (Input.GetMouseButton(0))
        {
            atiszaman += Time.deltaTime;
            if (atiszaman > 0.6f)
            {
                var bull = Instantiate(kursunn, GameObject.Find("nisan").transform.position, Quaternion.identity);
                bull.AddForce(transform.forward * 1800);
                atiszaman = 0;
            }
            fireControl = true;
        }
        rayDrawing();
    }
    void rayDrawing()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));

        Debug.DrawLine(target.transform.position, hit.point, Color.cyan);


    }
}
