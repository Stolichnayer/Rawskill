using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;
        
    private void Start()
    {

        if (!isLocalPlayer)
        {
            foreach (Behaviour b in componentsToDisable)
            {
                b.enabled = false;
            }
        }
        else
        {
            GameObject.FindWithTag("SceneCamera").SetActive(false);
        }
    }


}
