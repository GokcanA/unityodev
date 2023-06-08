using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Soru1 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    private float gametime;
    [SerializeField] public float repeattime;

    private void Start()
    {
        InstantiateMethod();
    }
    private void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > repeattime)
        {
            RotationMethod();

            gametime = 0;
        }

    }

    private void InstantiateMethod()
    {
        GameObject newcube = Instantiate(cube,transform.position,transform.rotation);
        
        cube2 = newcube;

    }

    private void RotationMethod()
    {
        cube2.GetComponent<Transform>().eulerAngles += new Vector3(10, 0, 0);
    }
}
