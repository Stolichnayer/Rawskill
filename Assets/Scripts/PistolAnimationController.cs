using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAnimationController : MonoBehaviour
{

    public Animator anim;
    public ParticleSystem[] muzzleFlash;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.Play("Pistol_Fire", 0);
            muzzleFlash[0].Emit(1);
            muzzleFlash[1].Emit(1);
        }
    }
}
