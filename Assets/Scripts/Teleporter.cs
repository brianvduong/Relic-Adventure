using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform teleportTarget;
    public CharacterController thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.enabled = false;
        thePlayer.transform.position = teleportTarget.transform.position;
        thePlayer.enabled = true;
    }

}
