using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soru3 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    private float gametime;
    [SerializeField] private float repeattime;

    private void Start()
    {
        InstantiateMethod();
    }
    private void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > repeattime)
        {
            cube2.GetComponent<Transform>().position = new Vector3(Random.Range(-3,3),Random.Range(-3,3), Random.Range(-3,3));

            gametime = 0;
        }

        transform.LookAt(cube2.transform.position);
    }

    private void InstantiateMethod()
    {
        GameObject newcube = Instantiate(cube, transform.position, transform.rotation);

        cube2 = newcube;

    }
   
}
