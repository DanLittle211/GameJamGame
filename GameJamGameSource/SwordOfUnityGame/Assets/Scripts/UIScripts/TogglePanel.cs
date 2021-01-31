using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TogglePanel : MonoBehaviour
{
    public GameObject togglePanel;
    public Toggle toggleButton;
    private void Update()
    {
        if(toggleButton.isOn == true)
        {
            togglePanel.SetActive(true);
        }
        else
        {
            togglePanel.SetActive(false);
        }
    }
    
}
