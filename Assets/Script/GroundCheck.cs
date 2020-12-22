using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool ground;

    private void OnTriggerEnter2D(Collider2D collision) // cuando este tocando el suelo
    {
        ground = true;
    }

    private void OnTriggerExit2D(Collider2D collision) // cuando no este tocando el suelo
    {
        ground = false;
    }
}
