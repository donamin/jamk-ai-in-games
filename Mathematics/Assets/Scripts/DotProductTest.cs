using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductTest : MonoBehaviour
{
    public float beta = 45;
    public float range = 15;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * 25, Color.blue);

        Vector3 f = transform.forward;
        Vector3 p = enemy.transform.position - transform.position;

        float dot = f.x * p.x + f.y * p.y + f.z * p.z;
        //float dot = Vector3.Dot(p, f);
        /*if(dot > 0)
            Debug.DrawLine(transform.position, enemy.transform.position, Color.red);
        else
            Debug.DrawLine(transform.position, enemy.transform.position, Color.green);*/

        float alpha = Mathf.Acos(dot / (f.magnitude * p.magnitude)) * Mathf.Rad2Deg;
        Debug.Log(alpha);
        if(alpha < beta && p.magnitude < range)
            Debug.DrawLine(transform.position, enemy.transform.position, Color.red);
        else
            Debug.DrawLine(transform.position, enemy.transform.position, Color.green);
    }
}