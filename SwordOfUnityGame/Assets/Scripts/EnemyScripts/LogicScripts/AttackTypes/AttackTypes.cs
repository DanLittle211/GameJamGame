using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackTypes : MonoBehaviour
{
    public enum DamageType { Strength, Dexerity, Intelegence }
    public enum AttackType { DamageOverTime, PureDamage, BuffOrDebuff, Hybrid }
    public int attDamage;
    public PlayerCombatStatuses playerStatuses;
    public PlayerStatisticsManager pStatsMang;
    public DamageType D_Type;
    public AttackType A_Type;
}
