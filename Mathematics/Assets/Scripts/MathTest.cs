using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float norm = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2) + Mathf.Pow(transform.position.z, 2));
        //float norm = Vector3.Magnitude(transform.position);
        //float norm = transform.position.magnitude;
        Debug.Log(norm);

        if (norm < 10)
            Debug.DrawLine(Vector3.zero, transform.position, Color.red);
        else
            Debug.DrawLine(Vector3.zero, transform.position, Color.green);


        float sqr_norm = Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2) + Mathf.Pow(transform.position.z, 2);
        //float sqr_norm = Vector3.SqrMagnitude(transform.position);
        //float sqr_norm = transform.position.sqrMagnitude;

        if (sqr_norm < 100)
            Debug.DrawLine(Vector3.zero, transform.position, Color.red);
        else
            Debug.DrawLine(Vector3.zero, transform.position, Color.green);

        Vector3 pos_unit;
        if (sqr_norm > 0)
            pos_unit = transform.position / norm;
        else
            pos_unit = Vector3.zero;
        //Vector3 pos_unit = transform.position.normalized;
        Debug.DrawLine(Vector3.zero, pos_unit, Color.blue);
    }
}