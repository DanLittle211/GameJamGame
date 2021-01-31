using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject inventory_Panel;
    public Toggle invenToggle;
    bool InvenOpen;
    private void Update()
    {
        if (invenToggle.isOn)
        {
            inventory_Panel.SetActive(true);
        }
        else
        {
            inventory_Panel.SetActive(false);
        }
    }

    private void OnApplicationQuit()
    {
        //inventory.Container.Clear();
    }
}
