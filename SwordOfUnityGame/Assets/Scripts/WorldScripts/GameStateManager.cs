using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    #region World GameStates
    public enum WorldState {Overworld_State, GamePause, Combat_State};
    public WorldState currentWorldState;
    #endregion
    #region UI Canvases
    public GameObject OverworldCanvas;
    public GameObject CombatCanvas;
    #endregion
    private void Awake()
    {
        //starting out in the overworld 
        currentWorldState = WorldState.Overworld_State;
    }
    // Update is called once per frame
    void Update()
    {
        //Setting Overworld Canvas Active, Combat Canvas Inactive
        if(currentWorldState == WorldState.Overworld_State)
        {
            OverworldCanvas.SetActive(true);
            CombatCanvas.SetActive(false);
        }
        //Setting Combat Canvas Active, Overworld Canvas Inactive
        else if(currentWorldState == WorldState.Combat_State)
        {
            OverworldCanvas.SetActive(false);
            CombatCanvas.SetActive(true);
        }
        //Setting Pause Canvas Active
        if(currentWorldState == WorldState.GamePause)
        {
            OverworldCanvas.SetActive(true);
            CombatCanvas.SetActive(false);
        }
    }
}