using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJet : MonoBehaviour {
 
    public GameObject jet;
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        jet.transform.Rotate(Vector3.up *(Time.deltaTime * speed));
    }
}
