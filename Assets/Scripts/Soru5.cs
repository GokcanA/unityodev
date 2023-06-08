using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soru5 : MonoBehaviour
{
    public GameObject sekil1;
    public GameObject sekil2;
    public GameObject sekil3;
    public GameObject sekil4;
    private float gametime;
    [SerializeField] private float repeattime;

    private void Update()
    {
        gametime += Time.deltaTime;

        if ( gametime > repeattime)
        {
            int x = Random.Range(1, 5);

            if ( x == 1)
            {
                Olusturma1();
            }
            if (x == 2)
            {
                Olusturma2();
            }
            if (x == 3)
            {
                Olusturma3();
            }
            if (x == 4)
            {
                Olusturma4();   
            }

            gametime = 0;
        }
    }
    
    private void Olusturma1()
    {
        GameObject new1 = Instantiate(sekil1, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
    }
    private void Olusturma2()
    {
        GameObject new1 = Instantiate(sekil2, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
    }
    private void Olusturma3()
    {
        GameObject new1 = Instantiate(sekil3, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
    }
    private void Olusturma4()
    {
        GameObject new1 = Instantiate(sekil4, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
    }

}
