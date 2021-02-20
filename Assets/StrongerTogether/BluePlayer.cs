using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 100f;
    public CharacterController controller;
    private UI_System UI;
    [SerializeField]private float turnSmoothtime = 0.1f;
    float turnVelocity;
    public Transform Camera;
    public float TimeForNextLevel;
    private 
    void Start()
    {
        UI = FindObjectOfType<UI_System>();        
    }

    void Update()
    {


        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, y).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float rotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
            float rot = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref turnVelocity, turnSmoothtime);
            transform.rotation = (Quaternion.Euler(new Vector3(0, rot, 0)));

            Vector3 MoveDir = Quaternion.Euler(0, rotation, 0) * Vector3.forward;
            controller.Move(MoveDir.normalized * moveSpeed * Time.deltaTime);
        }
      
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
       
        if (hit.gameObject.CompareTag("Portal"))
        {
            StartCoroutine(nextLevel());

        }
    }

    IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(TimeForNextLevel);
        UI.LevelComplete = true;
    }
}
