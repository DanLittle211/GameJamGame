using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strangle : AttackTypes
{
    public int Damage;
    public Snake snake;
    public void Awake()
    {
        D_Type = DamageType.Dexerity;
        A_Type = AttackType.PureDamage;
        Damage = snake.DexerityScore;
    }
    public void doStrangle()
    {
        Debug.Log("Snake used Stangle");
        pStatsMang.currentHealth -= Damage;
    }
}
