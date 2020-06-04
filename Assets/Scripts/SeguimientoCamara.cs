using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{


    public Transform target;

    Vector3 velocity = Vector3.zero;

    public float smoothTime = 1.5f;


    public bool YMaxEnable = false;
    public float YMaxVaule = 0;

    public bool YMinEnable = false;
    public float YMinValue = 2.89f;

    public bool XMaxEnable = false;
    public float XMaxValue = 0;


    public bool XMinEnable = false;
    public float XMinValue = -3.85f;



    void FixedUpdate()
    {
        Vector3 targetPos = target.position;

        //vertical
        if (YMinEnable && YMaxEnable)
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxVaule);
        

        else if (YMinEnable)
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);

        else if (YMaxEnable)
            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxVaule);

        //horizontal

        if (XMinEnable && XMaxEnable)
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);

        else if (XMinEnable)
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, target.position.x);

        else if (XMaxEnable)
            targetPos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);

                           

        targetPos.z = transform.position.z;


        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }

    // Start is called before the first frame update

    /* [SerializeField]
     GameObject jugadorSeguir;
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         transform.position = new Vector3(jugadorSeguir.transform.position.x,
             jugadorSeguir.transform.position.y + 1f,
             transform.position.z);
     }*/
}
