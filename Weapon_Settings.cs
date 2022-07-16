using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Settings : MonoBehaviour {

    public Transform Player;
    public float dampTime = 0;
    public Vector3 WeaponPos;
    public float X = 0;
    public float Y = 0;
    public float Z = 0;
    private Vector3 velocity = Vector3.zero;



    void Update ()
    {
        WeaponPos = new Vector3(Player.position.x + X, Player.position.y + Y, Player.position.z + Z);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, WeaponPos, ref velocity, dampTime);
    }


}