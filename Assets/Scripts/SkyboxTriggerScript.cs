using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxTriggerScript : MonoBehaviour
{
    public Material skyboxSunny;
    public Material skyboxNight;
    public Light sun;
    private Renderer rend;


    private void OnTriggerEnter(Collider coll)
    {
       if(coll.gameObject.tag == "Player" && RenderSettings.skybox == skyboxNight)
        {
            rend = GetComponent<Renderer>();
            RenderSettings.skybox = skyboxSunny;
            sun.intensity = 1;
            sun.shadowStrength = 0.7f;
        }
       else if(coll.gameObject.tag == "Player" && RenderSettings.skybox == skyboxSunny)
        {
            rend = GetComponent<Renderer>();
            RenderSettings.skybox = skyboxNight;
            sun.intensity = 0.3f;
        }
    }
}
