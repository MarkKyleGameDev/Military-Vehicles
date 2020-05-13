using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject TPCam;
    public GameObject FPCam;
    public GameObject SideCam;
    public GameObject PanCam;
    public GameObject JetFP;
    public GameObject JetTP;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.Alpha1)) //Third Person Tank
        {
            TPCam.SetActive(true);
            PanCam.SetActive(false);
            SideCam.SetActive(false);
            FPCam.SetActive(false);
            JetFP.SetActive(false);
            JetTP.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) //First Person Tank
        {
            FPCam.SetActive(true);
            TPCam.SetActive(false);
            PanCam.SetActive(false);
            SideCam.SetActive(false);
            JetFP.SetActive(false);
            JetTP.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) //Side Cam Tank
        {
            SideCam.SetActive(true);
            TPCam.SetActive(false);
            PanCam.SetActive(false);
            FPCam.SetActive(false);
            JetFP.SetActive(false);
            JetTP.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) //Pan Cam
        {
            PanCam.SetActive(true);
            FPCam.SetActive(false);
            SideCam.SetActive(false);
            TPCam.SetActive(false);
            JetFP.SetActive(false);
            JetTP.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9)) //First Person Jet
        {
            JetFP.SetActive(true);
            JetTP.SetActive(false);
            PanCam.SetActive(false);
            FPCam.SetActive(false);
            SideCam.SetActive(false);
            TPCam.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0)) //Third Person Jet
        {
            JetTP.SetActive(true);
            JetFP.SetActive(false);
            PanCam.SetActive(false);
            FPCam.SetActive(false);
            SideCam.SetActive(false);
            TPCam.SetActive(false);
        }
    }
}
