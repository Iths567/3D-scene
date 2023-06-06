using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Torch : MonoBehaviour
{
    [SerializeField] GameObject Light;
    public TextMeshProUGUI uiTorch;
    private bool LightOn;
    private bool torchPrompt;

    // Start is called before the first frame update
    void Start()
    {
        LightOn = false;
        Light.gameObject.SetActive(LightOn);
        uiTorch.gameObject.SetActive(uiTorch);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Light.gameObject.SetActive(!LightOn);
            LightOn = !LightOn;

        }
        if (!torchPrompt)
        {
            Prompts();
        }
    }

    public void Prompts()
    {
        if(Input.GetKeyDown(KeyCode.F) && !torchPrompt)
        {
            torchPrompt = true;
            uiTorch.gameObject.SetActive(!uiTorch);
        }
    }
}
