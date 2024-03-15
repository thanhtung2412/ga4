using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 dir;
    public GameObject kunai;
    private Collider2D col;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        Debug.Log(col == null);
    }


    void Update()
    {      
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        dir = new Vector2(horizontal, vertical);
        if (Input.GetMouseButton(0))
        {
            kunai.transform.localRotation = transform.rotation;  
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = dir * moveSpeed;
        if(rb.velocity.magnitude >= 0.1f)
        {
            Debug.Log(rb.velocity.magnitude);
            if(dir.x <= 0.1f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
            else
            {
                transform.rotation = Quaternion.identity;
            }
        }      
    }
}
