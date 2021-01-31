using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Location { Forest, Cave, Castle }
public class EnemyObjects : ScriptableObject
{
    public GameObject prefab;
    public Location place;
    public int StrengthScore;
    public int DexerityScore;
    public int IntelegenceScore;
    public int MaxHealth;
    public int CurrentHealth;
}
