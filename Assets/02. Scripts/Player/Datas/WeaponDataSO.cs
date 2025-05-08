using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDataSO", menuName = "Scriptable Objects/WeaponDataSO")]
public class WeaponDataSO : ScriptableObject
{
    public List<WeaponData> WeaponDatas;

    private Dictionary<EWeaponType, WeaponData> _weaponDict;

    public void Init(GameObject owner)
    {
        _weaponDict = new Dictionary<EWeaponType, WeaponData>();
        foreach (var data in WeaponDatas)
        {
            data.Damage.From = owner;
            data.CurrentAmmo = data.MaxAmmo;
            if (!_weaponDict.ContainsKey(data.WeaponType))
                _weaponDict.Add(data.WeaponType, data);
        }
    }

    public WeaponData GetWeapon(EWeaponType type)
    {
        if(_weaponDict == null)
        {
            Init(Player.Instance.gameObject);
        }
        if (_weaponDict.TryGetValue(type, out var data))
            return data;

        Debug.LogWarning($"Weapon ID '{type}' not found!");
        return null;
    }
}
