using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionObjetosEsp : MonoBehaviour
{
    private float rangoGeneracion = 150.0f;
    public GameObject obj1;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        float posXGeneracion1 = Random.Range(-rangoGeneracion, rangoGeneracion);
        float posZGeneracion1 = Random.Range(-rangoGeneracion, rangoGeneracion);

        float posXGeneracion2 = Random.Range(-rangoGeneracion, rangoGeneracion);
        float posZGeneracion2 = Random.Range(-rangoGeneracion, rangoGeneracion);

        Vector3 posAleatorio1 = new Vector3(posXGeneracion1, 12, posZGeneracion1);

        Vector3 posAleatorio2 = new Vector3(posXGeneracion2, 12, posZGeneracion2);

        Instantiate(obj1, posAleatorio1, obj1.transform.rotation);
        Instantiate(obj2, posAleatorio2, obj2.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
