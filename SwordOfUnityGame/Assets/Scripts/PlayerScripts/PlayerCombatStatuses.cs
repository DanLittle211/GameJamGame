using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatStatuses : MonoBehaviour
{
    public bool isDebuffed;
    public byte DebuffCounter;
    public bool hasDOT;
    public byte DOTCounter;
    public bool Blocking;
    public byte BlockingCounter;
    public GameStateManager StateManager;
    private void Update()
    {
        if(StateManager.currentWorldState == GameStateManager.WorldState.Overworld_State)
        {
            BlockingCounter = 0;
            DebuffCounter = 0;
            DOTCounter = 0;
        }
        if(BlockingCounter <= 0)
        {
            BlockingCounter = 0;
        }
        if(DebuffCounter <= 0)
        {
            DebuffCounter = 0;
        }
        if(DOTCounter <= 0)
        {
            DOTCounter = 0;
        }
    }
}
