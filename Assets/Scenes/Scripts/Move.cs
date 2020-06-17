using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float Jumpforce;
    private bool IsGrounded;
    // Update is called once per frame
    Vector3 target;
    void start()
    {
        target = transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //Jump
        if(Input.GetKey(KeyCode.Space) && (IsGrounded))
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            transform.position += Vector3.up * speed * Time.deltaTime;

        }
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //Debug.DrawLine(transform.position, target, Color.green);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ColliesionEnter");
        IsGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("ColliesionExit");
        IsGrounded = false;
    }

}
