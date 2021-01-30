using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Castle Enemy Object", menuName = "Enemy System/Castle/StoneGuardian")]
public class StoneGuardian : EnemyObjects
{
    public void Awake()
    {
        place = Location.Castle;
        StrengthScore = 16;
        MaxHealth = 80;
        CurrentHealth = MaxHealth;
    }
}
