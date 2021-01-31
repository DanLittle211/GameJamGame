using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearLogic : MonoBehaviour
{
    public float currentAttack;
    public bool isBuffed;
    CombatManager combatManager;
    #region Attack Scripts
    public Maim maim;
    public BearRoar roar;
    public BearBite bite;
    #endregion
    private void Awake()
    {
        combatManager = GameObject.Find("GameManager").GetComponent<CombatManager>();
    }
    void Update()
    {
        if (isBuffed)
        {
            maim.Damage = (maim.bear.StrengthScore + roar.DamageMod);
            bite.Damage = (bite.bear.StrengthScore + roar.DamageMod);
        }
        else
        {
            maim.Damage = maim.bear.StrengthScore;
            bite.Damage = bite.bear.StrengthScore;
        }
    }
    public void chooseAttack()
    {
        currentAttack = Mathf.Round(Random.Range(1, 7));
    }
    public void doAttack()
    {
        if (currentAttack == 1 || currentAttack == 2)
        {
            maim.doMaim();
        }
        if (currentAttack == 3 || currentAttack == 4)
        {
            roar.doRoar();
        }
        if (currentAttack == 4 || currentAttack == 6)
        {
            bite.doBearBite();   
        }
        combatManager.EnemyWent = true;
    }
}


