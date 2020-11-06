using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoComIntensidade : MonoBehaviour
{
    [SerializeField] private float maxVel = 5f;
    [SerializeField] private float acel = 0.5f;
    [SerializeField] private float desacel = 0.1f;
    private string disparo;
    private Transform transfDisp;
    private SpawnWeapon spawn;
    private float velAtual = 1f;
    private Rigidbody2D rb;
    private bool shoot = false;
    private PlayerAtributos pa;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!shoot && disparo!=null && transfDisp!=null && spawn!=null)
        {
            this.transform.position = transfDisp.position;
            if (Input.GetAxisRaw(disparo) > 0)
            {
                velAtual += (Time.deltaTime * acel);
                velAtual = Mathf.Clamp(velAtual, 0, maxVel);
                pa.GetComponent<Animator>().SetBool("ComWeapon", false);
                pa.GetComponent<Animator>().SetBool("Segurando", true);
            }
            else if (Input.GetButtonUp(disparo))
            {
                pa.GetComponent<Animator>().SetTrigger("Atirando");
                rb.velocity = pa.GetComponent<Transform>().up * velAtual;
                pa.SetWeapon(false);
                shoot = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if (shoot && disparo != null && transfDisp != null)
        {
            velAtual -= (Time.deltaTime * desacel);
            velAtual = Mathf.Clamp(velAtual, 0, maxVel);
            rb.velocity = rb.velocity.normalized * velAtual;
            if (velAtual == 0)
            {
                spawn.Spawn();
                Destroy(this.gameObject);
            }
        }
    }
    public void SetDisparo(string d)
    {
        disparo = d;
    }
    public void SetTransfDisp(Transform t)
    {
        transfDisp = t;
    }
    public void SetSpawn(SpawnWeapon s)
    {
        spawn = s;
    }
    public float GetVelAtual()
    {
        return velAtual;
    }
    public void SetPlayerAtributos(PlayerAtributos p)
    {
        pa = p;
    }
}
