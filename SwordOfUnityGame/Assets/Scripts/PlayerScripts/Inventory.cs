using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Variables
    public bool InventoryEnabled;
    public GameObject inventory;
    #endregion
    #region Sctipt References
    public GameStateManager State_Mang;
    #endregion

    private void Update()
    {
        if(State_Mang.currentWorldState != GameStateManager.WorldState.Combat_State)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                InventoryEnabled = !InventoryEnabled;
                
            }
            
            if (InventoryEnabled)
            {
                inventory.SetActive(true);
                State_Mang.currentWorldState = GameStateManager.WorldState.GamePause;
            }
            else
            {
                inventory.SetActive(false);
                State_Mang.currentWorldState = GameStateManager.WorldState.Overworld_State;
            }
        }
       
    }
}
