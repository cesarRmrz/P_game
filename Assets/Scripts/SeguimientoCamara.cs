using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject jugadorSeguir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(jugadorSeguir.transform.position.x,
            jugadorSeguir.transform.position.y - 1f,
            transform.position.z);
    }
}
