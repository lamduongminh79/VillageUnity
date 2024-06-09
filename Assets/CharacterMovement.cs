using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;

    void Start()
    {
        // Lấy tham chiếu đến Animator và Rigidbody của nhân vật
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Kiểm tra nếu nhân vật đang di chuyển (tốc độ lớn hơn một ngưỡng nhất định)
        if (rigidbody.velocity.magnitude > 0.1f)
        {
            // Kích hoạt animation di chuyển
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // Vô hiệu hóa animation di chuyển
            animator.SetBool("IsMoving", false);
        }
    }
}
