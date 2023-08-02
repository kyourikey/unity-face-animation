using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceAnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private string faceTypePropertyKey = "FaceType";

    enum FaceType
    {
        Idle = 0,
        Slot1 = 1,
        Slot2 = 2,
        Slot3 = 3,
        Slot4 = 4,
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger(faceTypePropertyKey, (int)FaceType.Slot1);
            return;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger(faceTypePropertyKey, (int)FaceType.Slot2);
            return;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger(faceTypePropertyKey, (int)FaceType.Slot3);
            return;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger(faceTypePropertyKey, (int)FaceType.Slot4);
            return;
        }

        animator.SetInteger(faceTypePropertyKey, (int)FaceType.Idle);
    }
}
