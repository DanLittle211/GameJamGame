using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Cave Enemy Object", menuName = "Enemy System/Cave/Skeleton")]
public class Skeleton : EnemyObjects
{
    public void Awake()
    {
        place = Location.Cave;
        DexerityScore = 6;
        MaxHealth = 20;
        CurrentHealth = MaxHealth;
    }
}
