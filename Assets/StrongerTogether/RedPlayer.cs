using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public GameObject redslime;
    private bool isMove = false;
    private UI_System UI;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        UI = FindObjectOfType<UI_System>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isMove = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            isMove = true;
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isMove = true;
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMove = true;
            rb.MovePosition(transform.position + -transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isMove = true;
            rb.MovePosition(transform.position + -transform.forward * moveSpeed * Time.fixedDeltaTime);
        }
        if (isMove)
        {
            Instantiate(redslime, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueSlime"))
        {
            UI.lifeCount -= 1;
        }
        if (other.gameObject.CompareTag("RedBean"))
        {
            UI.redbean -= 1;
            Destroy(other.gameObject);

        }
    }
}
