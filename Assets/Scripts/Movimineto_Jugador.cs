using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimineto_Jugador : MonoBehaviour
{
    public Animator animator;

    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

       // Jump();
    }

    /*void Jump()
    {
        Debug.Log("ENTER JUMP");
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jumpAnimator.SetFloat("Jump", Input.GetAxis("Jump"));
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }


    }*/
}
