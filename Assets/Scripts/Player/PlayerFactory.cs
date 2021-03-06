﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory
{
    public static PlayerController CreatePlayer(PlayerInfo info,bool fireable)
    {
        PlayerController player = Camera.Instantiate(PrefabManager.Instance._hero).GetComponent<PlayerController>();
        CreateWeapon(player, info._weaponType);
        player._fireable = fireable;
        return player;
    }

    private static void CreateWeapon(PlayerController player,Weapon.WeaponType type)
    {
        player._weapon = Camera.Instantiate(PrefabManager.Instance._weapons[(int)type], player.transform.Find("hand").position, Quaternion.identity).GetComponent<Weapon>();
        player._weapon.transform.parent = player.transform;
    }
}