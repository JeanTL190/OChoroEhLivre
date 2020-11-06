using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{
    [SerializeField] private DisparoComIntensidade getArma;
    [SerializeField] private LayerMask platformLayerMask;
    private SpawnWeapon spawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(((1 << collision.gameObject.layer) & platformLayerMask)!= 0)
        {
            PlayerAtributos aux = collision.GetComponent<PlayerAtributos>();
            if (!aux.GetWeapon())
            {
                aux.SetWeapon(true);
                DisparoComIntensidade aux2 = Instantiate(getArma);
                aux2.SetDisparo(aux.GetDisparo());
                aux2.SetTransfDisp(aux.GetTransfDisp());
                aux2.SetSpawn(spawn);
                aux2.SetPlayerAtributos(aux);
                Destroy(this.gameObject);
            }
        }
    }
    public void SetSpawnWeapon(SpawnWeapon sw)
    {
        spawn = sw;
    }
}
