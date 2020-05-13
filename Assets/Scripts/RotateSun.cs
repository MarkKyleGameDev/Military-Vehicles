using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour {

    public GameObject sun;
    public float speed;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(Vector3.left * (Time.deltaTime * speed));
    }
}
