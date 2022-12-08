using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintUselessInformation();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintUselessInformation()
    {
        Debug.Log("Rules are simple:");
        Debug.Log("Just don't hit the walls or any objects");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xValue, 0, zValue);
    }

}
