using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlayer : MonoBehaviour
{
    public Animator animator,jumpAnimator;

    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetBool("Grounded", grounded);

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

        Jump();

    }

    void Jump()
    {
       
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jumpAnimator.SetFloat("Jump", Input.GetAxis("Jump"));
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }


    }   
}
