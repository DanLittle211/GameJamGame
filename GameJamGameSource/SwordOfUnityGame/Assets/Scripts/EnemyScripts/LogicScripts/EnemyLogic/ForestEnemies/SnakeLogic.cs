using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeLogic : MonoBehaviour
{
    public float currentAttack;
    CombatManager combatManager;
    #region Attack Scripts
    public VenomStrike vStrike;
    public Strangle strangle;
    public SnakeBite snakeBite;
    #endregion

    private void Awake()
    {
        combatManager = GameObject.Find("GameManager").GetComponent<CombatManager>();
    }
    private void Update()
    {
       
    }
    public void chooseAttack()
    {
       currentAttack = Mathf.Round(Random.Range(1, 7));
        Debug.Log("Snake Chose: " + currentAttack);
    }
    public void doAttack()
    {
        Debug.Log("Snake Attacked");
        if(currentAttack == 1 || currentAttack == 2)
        {
            vStrike.doVenomStrike();
        }
        if(currentAttack == 3 || currentAttack == 4)
        {
            snakeBite.doSnakeBite();
        }
        if(currentAttack == 4 || currentAttack == 6)
        {
            strangle.doStrangle();
        }
        combatManager.EnemyWent = true;
    }
}
