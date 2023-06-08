using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soru4 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    

    private void Start()
    {
        InstantiateMethod();
    }

    private void InstantiateMethod()
    {
                
        for (int i = 0; i < 10; i++)
        {
            GameObject newcube = Instantiate(cube, transform.position, transform.rotation);

            cube2 = newcube;

            cube2.transform.SetParent(transform);

        }

        //Debug.Log(transform.childCount);

        for (int i = 0; i < transform.childCount; i++)
        {
            CapsuleCollider hedef = transform.GetChild(i).GetComponent<CapsuleCollider>();
            hedef.isTrigger = true;
            hedef.radius = 5;
            hedef.height = 10;
            hedef.center = new Vector3(2, 3, 4);
        }

    }

  
}
