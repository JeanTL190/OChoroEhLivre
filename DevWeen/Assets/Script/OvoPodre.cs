using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvoPodre : MonoBehaviour
{
    [SerializeField] float timePodri = 3f;
    private Animator anim;
    private DisparoComIntensidade dci;
    void Awake()
    {
        dci = GetComponent<DisparoComIntensidade>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dci.GetShoot())
        {
            if(dci.GetVelAtual() > 0)
            {
                anim.SetTrigger("Jogou");
            }
            else
            {
                anim.SetTrigger("Parou");
                StartCoroutine("Podri");
            }
        }
    }

    IEnumerator Podri()
    {
        yield return new WaitForSeconds(timePodri);
        Destroy(this.gameObject);
    }
}
