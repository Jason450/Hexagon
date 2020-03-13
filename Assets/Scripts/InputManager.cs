using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Triangle triangle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                triangle.RotateRight();
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                triangle.RotateLeft();
            }
        }

    }
}
