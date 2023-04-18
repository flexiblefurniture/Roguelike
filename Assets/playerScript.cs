using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    private float xmove;
    private float ymove;
    private float mouseRotate;
    private Vector3 mousePos;
    private Vector3 currentEulerAngles;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
   {
        currentEulerAngles = new Vector3(0f, 0f);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        mouseRotate = (float)57.296 * Mathf.Atan2(mousePos.y, mousePos.x) + 90;
        transform.eulerAngles = currentEulerAngles + new Vector3(0f, 0f, mouseRotate);
    }
    void FixedUpdate()
    {
        ymove = 0;
        xmove = 0;
        if(Input.GetKey(KeyCode.W))
        {
            ymove += 2.0f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            ymove += -2.0f;
           
        }
        if(Input.GetKey(KeyCode.A))
        {
            xmove += -2.0f;
        }
        if(Input.GetKey(KeyCode.D))
        {
            xmove += 2.0f;
        }
        rb.velocity = new Vector2(xmove, ymove) * speed * Time.deltaTime;
    }
}
