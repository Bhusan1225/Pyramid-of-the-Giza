using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flishLight : MonoBehaviour
{
    private Light flashLightBulb;
    // Start is called before the first frame update
    void Start()
    {
        flashLightBulb = GetComponentInChildren<Light>(); 
    }

    // Update is called once per frame
    public void ToggleFlashLight()
    {
        flashLightBulb.enabled = !flashLightBulb.enabled;
    }
}
