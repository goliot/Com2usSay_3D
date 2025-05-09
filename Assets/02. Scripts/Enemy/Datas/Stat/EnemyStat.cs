using UnityEngine;

[System.Serializable]
public class EnemyStat
{
    public EEnemyType EnemyType;
    public DamageInfo Damage;
    public float MoveSpeed = 3.3f;
    public float AttackCoolTime = 1f;
    public float MaxHealth = 100f;
    public float ExplodeRange = 1f;

    [Header("# About States")]
    public float FindDistance = 7f;
    public float AttackDistance = 2.5f;
    public float ReturnDistance = 0.1f;
    public float DamagedTime = 0.5f; // 경직 시간
    public float IdleToPatrolTime = 3f;
}