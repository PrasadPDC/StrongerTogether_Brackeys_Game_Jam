using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 100f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(transform.position + -transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.MovePosition(transform.position + -transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
