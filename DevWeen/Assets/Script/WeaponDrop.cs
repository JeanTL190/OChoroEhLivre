using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{
    [SerializeField] private DisparoComIntensidade getArma;
    [SerializeField] private string namePosiArma;
    [SerializeField] private LayerMask platformLayerMask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(((1 << collision.gameObject.layer) & platformLayerMask)!= 0)
        {
            PlayerAtributos aux = collision.GetComponent<PlayerAtributos>();
            getArma.SetDisparo(aux.GetDisparo());
            getArma.SetTransfDisp(aux.GetTransfDisp());
            Instantiate(getArma);
        }
    }
}
