using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource source;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("something collided");
        source.Play();
        targetObject.SetActive(false);
    }

    public GameObject targetObject;

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
    }
}
