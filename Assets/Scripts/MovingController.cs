using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimatorTest
{
    public class MovingController : MonoBehaviour
    {
        public Animator animator;
        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("isMoving", true);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
}
