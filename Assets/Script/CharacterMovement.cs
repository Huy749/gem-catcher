using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
     static float speed = 5.0f;
    static float maxSpeed = 25;
    private Animator animator;

    public static void AddSpeed(int amount)
    {
        speed += amount;
        if (speed > maxSpeed){
            speed= maxSpeed;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //bat dau animation khep mo chan
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isMoving = moveHorizontal != 0; // khai baso bien isMoving
        animator.SetBool("isMoving", isMoving);
        if (isMoving) //neu nhan vat dang di chuyen
        {
            transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, 0f);
        }
    }
}
