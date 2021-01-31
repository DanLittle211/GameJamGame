using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearRoar : Buff_Debuffs
{
    public BearLogic bearLogic;
    private void Awake()
    {
        A_Type = AttackType.BuffOrDebuff;
        aType = AType.Buff;
        D_Type = DamageType.Strength;
        RoundCounter = 3;
        DamageMod = 2;
    }
    public void doRoar()
    {
        Debug.Log("Bear used Roar");
        combatManager.BuffCounter += RoundCounter;
        bearLogic.isBuffed = true;
    }
}
