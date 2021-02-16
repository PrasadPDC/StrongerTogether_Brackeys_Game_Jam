using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 100f;
    private Rigidbody rb;
    private bool isMove = false;
    public GameObject blueslime;
    private UI_System UI;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UI = FindObjectOfType<UI_System>();
    }

    // Update is called once per frame
    void Update()
    {

        isMove = false;

        if (Input.GetKeyDown(KeyCode.W))
        {
            isMove = true;
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            isMove = true;
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            isMove = true;
            rb.MovePosition(transform.position + -transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            isMove = true;
            rb.MovePosition(transform.position + -transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (isMove)
        {
            Instantiate(blueslime, transform.position, Quaternion.identity);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedSlime"))
        {
            UI.lifeCount -= 1;
        }
        if (other.gameObject.CompareTag("BlueBean"))
        {
            UI.bluebean -= 1;
            Destroy(other.gameObject);
        }
    }
}
