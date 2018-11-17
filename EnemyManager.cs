using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    Transform genericPoint;
    public GameObject[] EType = new GameObject[4];
    Enemy[,] Team = new Enemy[5,3];
    int[,] TeamState = new int[5,3];
    int[,] Type = new int[5, 3]; 

    void ManagerStart(){

        for (int i = 0; i <= 5; i++)
            for (int j = 0; j <= 3; j++) 
            {
                GameObject clong;
                clong = Instantiate(EType[Type[i,j]],new Vector3(i-2,j, -Mathf.Abs(i - 2)), this.transform.rotation);
                clong.transform.LookAt(new Vector3(genericPoint.position.x, clong.transform.position.y, genericPoint.position.z));
                //GameObject clong;
                //clong = Instantiate(test_Obj, new Vector3(i - 2, j, -Mathf.Abs(i - 2)), this.transform.rotation);
                //clong.transform.LookAt(new Vector3(genericPoint.position.x, clong.transform.position.y, genericPoint.position.z));
                TeamState[i,j]=0;
                //Team[i, j].Idle();
            }
    }

    void ManagerUpdate()
    {
        for (int i = 0; i <= 5; i++)
            for (int j = 0; j <= 3; j++)
            {
                switch (TeamState[i, j]){
                    case 0: Team[i, j].Idle(); break;
                    case 1: Team[i, j].Shoot(); break;
                    case 2: Team[i, j].HitAndAway(); break;
                }
            }
    }
        

}
