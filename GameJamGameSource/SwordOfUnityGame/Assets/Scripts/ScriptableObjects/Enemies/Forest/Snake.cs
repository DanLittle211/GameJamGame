using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Forest Enemy Object", menuName = "Enemy System/Forest/Snake")]
public class Snake : EnemyObjects
{
    public void Awake()
    {
        place = Location.Forest;
        DexerityScore = 2;
        MaxHealth = 10;
        CurrentHealth = MaxHealth;
    }
}
