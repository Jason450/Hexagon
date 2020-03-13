using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Transform trans;
    public float startScale;
    public float scaleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        trans.localEulerAngles = new Vector3(0, 0, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
        trans.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;

        if (trans.localScale.x <= 0.05)
        {
            trans.localScale = Vector3.one * startScale;
            trans.localEulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        }
    }
}
