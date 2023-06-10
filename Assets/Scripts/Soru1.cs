using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Soru1 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    //private float gametime;
    //[SerializeField] public float repeattime;
    public float speed;

    private void Start()
    {
        InstantiateMethod();
    }
    private void Update()
    {

        RotationMethod();
    }

    private void InstantiateMethod()
    {
        GameObject newcube = Instantiate(cube,transform.position,transform.rotation);
        
        cube2 = newcube;

    }

    private void RotationMethod()
    {
        //cube2.GetComponent<Transform>().eulerAngles += new Vector3(10, 0, 0);

        cube2.transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
