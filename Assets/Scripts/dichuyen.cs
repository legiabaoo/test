using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public Animator animator;
    public bool isRight = true;
    private Rigidbody2D rb;
    public bool bay;
    public GameObject panel, button, text;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isMoving", false);
        if (Input.GetKey(KeyCode.D))
        {
            isRight = true;
            animator.SetBool("isMoving", true);
            transform.Translate(Time.deltaTime * 4, 0, 0);
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? 1 : - 1;
            transform.localScale = scale;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            isRight = false;
            animator.SetBool("isMoving", true);
            transform.Translate(-Time.deltaTime * 4, 0, 0);
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? -1 : 1;
            transform.localScale = scale;
            
        }
        if (bay)
        {
            if (Input.GetKey(KeyCode.W))
            {
                if (isRight)
                {
                    //transform.Translate(Time.deltaTime * 2, Time.deltaTime * 6, 0);
                    rb.AddForce(new Vector2(0, 350));
                    Vector2 scale = transform.localScale;
                    scale.x *= scale.x > 0 ? 1 : -1;
                    transform.localScale = scale;
                }
                else
                {
                    //transform.Translate(-Time.deltaTime * 2, Time.deltaTime * 6, 0);
                    rb.AddForce(new Vector2(0, 350));
                    Vector2 scale = transform.localScale;
                    scale.x *= scale.x > 0 ? -1 : 1;
                    transform.localScale = scale;

                }
                bay = false;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "nen_dat")
        {
            bay = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "nam_tren")
        {
            var name = collision.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
        }
        if(collision.gameObject.tag == "nam_trai")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            text.SetActive(true);
            button.SetActive(true);
        }
    }
}
