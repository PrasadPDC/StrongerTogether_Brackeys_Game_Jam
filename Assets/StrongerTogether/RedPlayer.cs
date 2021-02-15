using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(transform.position + -transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position + -transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
