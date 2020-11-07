using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtributos : MonoBehaviour
{
    [SerializeField] private string disparo;
    [SerializeField] private PlayerAtributos enemy;
    [SerializeField] private Transform transfDisp;
    private int points=0;
    private bool weapon = false;

    public int GetPoints()
    {
        return points;
    }
    public string GetDisparo()
    {
        return disparo;
    }
    public Transform GetTransfDisp()
    {
        return transfDisp;
    }
    public void MorePoint()
    {
        points += 1;
    }
    public void TakeHit()
    {
        enemy.MorePoint();
    }
    public void SetWeapon(bool w)
    {
        weapon = w;
    }
    public bool GetWeapon()
    {
        return weapon;
    }
    public void ResetPoints()
    {
        points = 0;
    }
}
