using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 2f;
    float horizontalMove = 0f;


    // Main Player Movements
    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        // Dash trigger
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(controller.Dash());
        }
    }

    void FixedUpdate()
    {
        //  Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime);
    }
}
