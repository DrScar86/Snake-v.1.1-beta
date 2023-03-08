using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Movement>().enabled = false;
        other.GetComponent<Animator>().SetTrigger("Death");
    }

}
