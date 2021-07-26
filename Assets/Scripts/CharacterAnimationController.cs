using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterAnimationController : MonoBehaviour
{
    public float smooth = 200f;
    public float dampTime = 1f;
    public Animator animator;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    
   void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        animator.SetFloat(Vertical, inputVertical, dampTime, Time.smoothDeltaTime * smooth);
        animator.SetFloat(Horizontal, inputHorizontal, dampTime, Time.smoothDeltaTime * smooth);
        
    }
}
