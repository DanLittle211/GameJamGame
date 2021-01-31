using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    #region Combat States
    public enum whoseTurn { PlayerTurn, EnemyTurn }
    public whoseTurn CurrentTurn;
    public enum CombatPhases { Start_Phase, Main_Phase, End_Phase }
    public CombatPhases currentPhase;
    public enum whichEnemy {Snake, Wolf, Bear, Skeleton, Draugr, Lich, Ghost, StoneGuardian, Dragon}
    public whichEnemy currentEnemy;
    #endregion
    #region Variables
    public int currentDOTdamage;
    public int BuffCounter;
    #endregion
    #region Bools
    public bool PlayerWent;
    public bool EnemyWent;
    #endregion
    #region Enemy Logic Scripts
    public SnakeLogic snakeLogic;
    public WolfLogic wolfLogic;
    public BearLogic bearLogic;
    #endregion
    #region Unviversal Script Refences
    public PlayerCombatStatuses PlayerStatuses;
    public PlayerStatisticsManager pStatsMang;
    public GameStateManager StateManager;
    #endregion
    private void Awake()
    {
        CurrentTurn = whoseTurn.EnemyTurn;
    }
    private void Update()
    {
       if(StateManager.currentWorldState == GameStateManager.WorldState.Combat_State)
        {
            //health updates
            
            //enemy's turn
            if (CurrentTurn == whoseTurn.EnemyTurn)
            {
                if (currentPhase == CombatPhases.Start_Phase)
                {
                    Debug.Log("Enemy Start Phase");
                    EnemyWent = false;
                    if(currentEnemy == whichEnemy.Snake)
                    {
                        snakeLogic.chooseAttack();
                        Debug.Log("Snake: Switched to MainPhase");
                        currentPhase = CombatPhases.Main_Phase;
                    }
                    if(currentEnemy == whichEnemy.Bear)
                    {
                        bearLogic.chooseAttack();
                        currentPhase = CombatPhases.Main_Phase;
                    }
                }
                if (currentPhase == CombatPhases.Main_Phase)
                {
                    Debug.Log("Enemy Main Phase");
                    if(currentEnemy == whichEnemy.Snake)
                    {
                        snakeLogic.doAttack();
                    }
                    if (currentEnemy == whichEnemy.Bear)
                    {
                        bearLogic.doAttack();
                    }
                    if (EnemyWent)
                    {
                        currentPhase = CombatPhases.End_Phase;
                    }
                }
                if (currentPhase == CombatPhases.End_Phase)
                {
                    Debug.Log("Enemy End Phase");
                    EnemyCounterTick();
                }
            }
            //PLayer's turn
            if (CurrentTurn == whoseTurn.PlayerTurn)
            {
                if (currentPhase == CombatPhases.Start_Phase)
                {
                    PlayerWent = false;
                    Debug.Log("Player's Start Phase");
                    currentPhase = CombatPhases.Main_Phase;
                }
                if (currentPhase == CombatPhases.Main_Phase)
                {
                    Debug.Log("Player's Main Phase");
                    //temp
                    PlayerDoesAction();//this is temporary
                    //End temp
                    if (PlayerWent)
                    {
                        currentPhase = CombatPhases.End_Phase;
                    }
                }
                if (currentPhase == CombatPhases.End_Phase)
                {
                    Debug.Log("Player's End Phase");
                    PlayerTakeDOT(currentDOTdamage);
                    PlayerCounterTick();
                }
            }
        }
    }
    public void PlayerDoesAction()
    {
        PlayerWent = true;
    }
    void EnemyCounterTick()
    {
        Debug.Log("Enemy Counters Ticked");
        BuffCounter -= 1;
        CurrentTurn = whoseTurn.PlayerTurn;
        currentPhase = CombatPhases.Start_Phase;
    }
    void PlayerCounterTick()
    {
        PlayerStatuses.BlockingCounter -= 1;
        PlayerStatuses.DOTCounter -= 1;
        PlayerStatuses.DebuffCounter -= 1;
        CurrentTurn = whoseTurn.EnemyTurn;
        currentPhase = CombatPhases.Start_Phase;
    }
   public void PlayerTakeDOT(int DOT_Damage)
    {
        pStatsMang.currentHealth -= DOT_Damage;
    }
}
