using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff_Debuffs : AttackLogic
{
    public enum AType { Buff, Debuff, Both}
    public byte RoundCounter;
    public byte DamageMod;
    public AType aType;
}
