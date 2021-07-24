using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    [SerializeField]
    GameObject fireArms;
     
    [SerializeField]
    GameObject thirdPersonAvatar;
 
    private void Start()
    {

        if (!isLocalPlayer)
        {
            foreach (Behaviour b in componentsToDisable)
            {
                b.enabled = false;
                fireArms.SetActive(false);
            }
        }
        else
        {
            GameObject.FindWithTag("SceneCamera").SetActive(false);
            thirdPersonAvatar.SetActive(false);
        }
    }


}
