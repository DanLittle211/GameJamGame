using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff_Debuffs : AttackTypes
{
    public enum AType { Buff, Debuff, Both}
    public byte RoundCounter;
    public int DamageMod;
    public AType aType;
}