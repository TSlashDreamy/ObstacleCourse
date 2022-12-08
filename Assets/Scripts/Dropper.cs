using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer objRenderer;
    Rigidbody objRb;
    [SerializeField] float timeToElapse = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        objRb = GetComponent<Rigidbody>();

        objRenderer.enabled = false;
        objRb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToElapse)
        {
            Debug.Log(timeToElapse + " seconds elapsed");
            objRenderer.enabled = true;
            objRb.useGravity = true;
        }
    }
}
