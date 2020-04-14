using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlayer : MonoBehaviour
{
    public Animator animator,jumpAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Jump();
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        //Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //transform.position = transform.position + horizontal * 5f * Time.deltaTime;
        transform.Translate(Input.GetAxis("Horizontal") * 5f * Time.deltaTime, 0f, 0f);
        // Flip the Character:
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -5;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 5;
        }
        transform.localScale = characterScale;

    }

    void Jump()
    {
<<<<<<< HEAD
       
        if (Input.GetButtonDown("Jump") && grounded)
=======
        if (Input.GetButtonDown("Jump"))
>>>>>>> parent of 64c4180... Corrige Salto Jugador
        {
            jumpAnimator.SetFloat("Jump", Input.GetAxis("Jump"));
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }


    }   
}
