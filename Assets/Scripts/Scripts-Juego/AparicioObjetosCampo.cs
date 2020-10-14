using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicioObjetosCampo : MonoBehaviour
{
    private float rangoGeneracion = 40.0f;
    public GameObject prefabBusqueda;
    // Start is called before the first frame update
    void Start()
    {
        float posXGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);
        float posZGeneracion = Random.Range(-rangoGeneracion, rangoGeneracion);

        Vector3 posAleatorio = new Vector3(posXGeneracion, 0, posZGeneracion);

        Instantiate(prefabBusqueda, posAleatorio, prefabBusqueda.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
