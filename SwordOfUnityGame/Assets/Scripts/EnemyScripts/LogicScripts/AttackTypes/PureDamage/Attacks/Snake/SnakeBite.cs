using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBite : AttackTypes
{
    public int Damage;
    public Snake snake;
    private void Awake()
    {
        D_Type = DamageType.Dexerity;
        A_Type = AttackType.PureDamage;
        Damage = snake.DexerityScore;
    }
    public void doSnakeBite()
    {
        Debug.Log("Snake use Snake Bite");
        pStatsMang.currentHealth -= Damage;
    }
}
