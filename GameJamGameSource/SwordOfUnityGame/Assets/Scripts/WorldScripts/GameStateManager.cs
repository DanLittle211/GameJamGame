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
    #region Which level
    public bool inForest = false;
    public bool inCaves = false;
    public bool inCastle = false;
    public bool inCastleFinal = false;
    public GameObject ForestLevel;
    public GameObject ForestCombatZone;
    public GameObject CaveLevel;
    public GameObject CaveCombatZone;
    public GameObject CastleLevel;
    public GameObject CastleCombatZone;
    public GameObject DragonCombatZone;
    #endregion
    private void Awake()
    {
        //starting out in the overworld & on the forest level
        currentWorldState = WorldState.Overworld_State;
        inForest = true;

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
        // what happens if inForest is true or false
        if (inForest)
        {
            ForestLevel.SetActive(true);
            ForestCombatZone.SetActive(true);
        }
        else if (!inForest)
        {
            ForestLevel.SetActive(false);
            ForestCombatZone.SetActive(false);
        }
        //What happens if inCave is true or false
        if (inCaves)
        {
            CaveLevel.SetActive(true);
            CaveCombatZone.SetActive(true);
        }
        else if (!inCaves)
        {
            CaveLevel.SetActive(false);
            CaveCombatZone.SetActive(false);
        }
        //what happens if inCastle is true or false
        if (inCastle)
        {
            CastleLevel.SetActive(true);
            CastleCombatZone.SetActive(true);
        }
        if (!inCastle)
        {
            CastleLevel.SetActive(false);
            CastleCombatZone.SetActive(false);
        }
    }
}