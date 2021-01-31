using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenomStrike : DamageOverTIme
{
    public CombatManager combatManager;
    private void Awake()
    {
        D_Type = DamageType.Dexerity;
        A_Type = AttackType.DamageOverTime;
        RoundCounter = 3;
        DOTDamge = 2;
    }
    public void doVenomStrike()
    {
        Debug.Log("Snake used VenomStrike");
        playerStatuses.DOTCounter += RoundCounter;
        combatManager.currentDOTdamage = DOTDamge;
        playerStatuses.hasDOT = true;
    }
}
