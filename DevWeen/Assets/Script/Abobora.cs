using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abobora : MonoBehaviour
{
    private DisparoComIntensidade dci;
    private Animator anim;
    void Awake()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        dci = GetComponent<DisparoComIntensidade>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (dci.GetShoot())
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (dci.GetVelAtual() == 0)
        {
            anim.SetTrigger("Explode");
        }
    }
    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
