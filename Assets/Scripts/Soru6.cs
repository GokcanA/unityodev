using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soru6 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube2;
    private float gametime;
    [SerializeField] private float repeattime;
    [SerializeField] private float lerpspeed;

    private void Start()
    {
        InstantiateMethod();
    }
    private void Update()
    {
        gametime += Time.deltaTime;

        if (gametime > repeattime)
        {
            cube2.GetComponent<Transform>().position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));

            gametime = 0;
        }

        cube2.transform.position = Vector3.Lerp(cube2.transform.position,transform.position,lerpspeed*Time.deltaTime);

    }

    private void InstantiateMethod()
    {
        GameObject newcube = Instantiate(cube, transform.position, transform.rotation);

        cube2 = newcube;

    }
}
