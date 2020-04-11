using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckJugador : MonoBehaviour
{
    private movimientoPlayer player;

     void Start()
    {
        player = gameObject.GetComponentInParent<movimientoPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.grounded = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        player.grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.grounded = false;
    }
}
