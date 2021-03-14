using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public GameObject redslime;
    public CharacterController controller;
    [SerializeField] private float turnSmoothtime = 0.1f;
    float turnVelocity;
   
    void Update()
    {


        float x = Input.GetAxis("Arrowright");
        float y = Input.GetAxis("Arrowup");

        Vector3 direction = new Vector3(x, 0, y).normalized;

        if (direction.magnitude >= 0.1)
        {
            float rot = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //float rot = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, rot, ref turnVelocity, turnSmoothtime);
            transform.rotation = (Quaternion.Euler(new Vector3(0, angle, 0)));
            //Vector3 MoveDir = Quaternion.Euler(0, rot, 0) * Vector3.forward;

            controller.Move(direction * moveSpeed * Time.deltaTime);
        }
          
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Key"))
        {
            Destroy(hit.gameObject);
        }
    }
}
