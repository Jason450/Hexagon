using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public Transform trans;
    public Vector3 rotation;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        rotation = trans.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        trans.localEulerAngles = rotation;
    }

    public void RotateRight()
    {
        Debug.Log("to right");
        rotation.z += Input.GetAxis("Mouse X") * speed;
    }
    public void RotateLeft()
    {
        Debug.Log("to left");
        rotation.z -= Input.GetAxis("Mouse X") * -speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject);
    }
}
