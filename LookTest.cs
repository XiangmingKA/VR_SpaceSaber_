using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTest : MonoBehaviour
{
    public Transform genericPoint;
    public GameObject test_Obj;

    void Start()
    {

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 3; j++)
            {
                GameObject clong;
                clong = Instantiate(test_Obj, new Vector3(i - 2, j, -Mathf.Abs(i-2)), this.transform.rotation);
                clong.transform.LookAt(new Vector3(genericPoint.position.x, clong.transform.position.y, genericPoint.position.z));
                Debug.Log(new Vector3(genericPoint.position.x, clong.transform.position.y, genericPoint.position.z));
            }
    }
}