using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HybridAttacks : AttackLogic
{
    public enum AType {Buff, Debuff, Both}
    public byte RoubdCounter;
    public byte DamageMod;
    public AType aType; 
}
