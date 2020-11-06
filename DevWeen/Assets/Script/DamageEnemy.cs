using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.layer) & platformLayerMask) != 0)
        {
            PlayerAtributos aux = collision.GetComponent<PlayerAtributos>();
            DisparoComIntensidade dci = this.GetComponent<DisparoComIntensidade>();
            aux.TakeHit();
            if(dci.GetVelAtual()>0)
                dci.Spawnar();
            dci.SetSP(true);
            Destroy(this.gameObject);
        }
    }
}
