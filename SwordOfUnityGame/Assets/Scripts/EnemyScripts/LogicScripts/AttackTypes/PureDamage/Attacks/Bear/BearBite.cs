using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBite : AttackTypes
{
    public int Damage;
    public Bear bear;
    public BearLogic bearLogic;
    private void Awake()
    {
        A_Type = AttackType.PureDamage;
        D_Type = DamageType.Strength;
        Damage = bear.StrengthScore;
    }
    public void doBearBite()
    {
        Debug.Log("Bear used Bite");
        pStatsMang.currentHealth -= Damage;
    }
}
