using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapelH : MonoBehaviour
{
    private DisparoComIntensidade dci;
    private Animator anim;
    private Collider2D col;
    void Awake()
    {
        dci = GetComponent<DisparoComIntensidade>();
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dci.GetVelAtual() == 0)
        {
            col.enabled = false;
            anim.SetTrigger("Rolar");
        }
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
