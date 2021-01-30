using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Castle Enemy Object", menuName = "Enemy System/Castle/Ghost")]
public class Ghost : EnemyObjects
{
    public void Awake()
    {
        place = Location.Castle;
        DexerityScore = 12;
        MaxHealth = 30;
        CurrentHealth = MaxHealth;
    }
}
