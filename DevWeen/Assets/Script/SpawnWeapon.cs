using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] private WeaponDrop[] weapons;
    private int weaponNumb = -1;
    private int quantArmas;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    public void Spawn()
    {
        quantArmas = weapons.Length;
        weaponNumb = Random.Range(0, quantArmas - 1);
        weapons[weaponNumb].transform.position = transform.position;
        WeaponDrop wd = Instantiate(weapons[weaponNumb]);
        wd.SetSpawnWeapon(this);
    }
}
