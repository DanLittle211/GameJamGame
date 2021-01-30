using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackLogic : MonoBehaviour
{
    public enum DamageType { Strength, Dexerity, Intelegence }
    public enum AttackType { DamageOverTime, PureDamage, BuffOrDebuff, Hybrid }
    public byte attDamage;
    public PlayerStatisticsManager pStatsMang;
    public DamageType D_Type;
    public AttackType A_Type;
}
