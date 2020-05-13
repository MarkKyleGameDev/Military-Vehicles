using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour {

    public GameObject spotLight;
    bool on = true;    

    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (on == false)
            {
                spotLight.SetActive(true);
                on = true;
            }
            else
            {
                spotLight.SetActive(false);
                on = false;
            }
        }
    }
}