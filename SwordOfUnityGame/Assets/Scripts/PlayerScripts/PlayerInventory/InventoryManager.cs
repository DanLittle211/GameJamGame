using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject inventory_Panel;
    bool InvenOpen;
    private GameStateManager State_Mang;
    private void Awake()
    {
        State_Mang = GetComponent<GameStateManager>();
    }
    private void Update()
    {
        if(State_Mang.currentWorldState != GameStateManager.WorldState.Combat_State)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                InvenOpen = !InvenOpen;   
            }
            if (InvenOpen)
            {
                inventory_Panel.SetActive(true);
                State_Mang.currentWorldState = GameStateManager.WorldState.GamePause;
            }
            else if (!InvenOpen)
            {
                inventory_Panel.SetActive(false);
                State_Mang.currentWorldState = GameStateManager.WorldState.Overworld_State;
            }
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
