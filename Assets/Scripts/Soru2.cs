using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEditor;
using UnityEngine;

public class Soru2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    public int speed;

    private void Start()
    {
        InstantiateMethod();
    }
    private void Update()
    {
        Ilerleme();

        if (cube2.GetComponent<Transform>().position.z > 100)
        {
            cube2.GetComponent<Transform>().position = transform.position;
        }
    }

    private void InstantiateMethod()
    {
        GameObject newcube = Instantiate(cube, transform.position, transform.rotation);

        cube2 = newcube;

    }

    private void Ilerleme()
    {
        cube2.GetComponent<Transform>().position += Vector3.forward * speed * Time.deltaTime;
    }

    
}
