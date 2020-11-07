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
    private bool sp = false;
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
            this.transform.rotation = transfDisp.rotation;
            this.transform.Rotate(0, 0, -90);
            if (Input.GetAxisRaw(disparo) > 0)
            {
                velAtual += (Time.deltaTime * acel);
                velAtual = Mathf.Clamp(velAtual, 0, maxVel);
                pa.GetComponent<Animator>().SetBool("ComWeapon", false);
                pa.GetComponent<Animator>().SetBool("Segurando", true);
                pa.GetComponent<Animator>().SetBool("Atirando", false);
            }
            else if (Input.GetButtonUp(disparo))
            {
                pa.GetComponent<Animator>().SetBool("Atirando",true);
                pa.GetComponent<Animator>().SetBool("ComWeapon", false);
                pa.GetComponent<Animator>().SetBool("Segurando", false);
                pa.GetComponent<Animator>().SetBool("Bazooka",false);
                rb.velocity = pa.GetComponent<Transform>().up * velAtual;
                pa.SetWeapon(false);
                this.GetComponent<Collider2D>().enabled = true;
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
            if (velAtual == 0 && !sp)
            {
                sp = true;
                spawn.Spawn();
                //Destroy(this.gameObject);
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
    public void SetPlayerAtributos(PlayerAtributos p)
    {
        pa = p;
    }
    public void Spawnar()
    {
        spawn.Spawn();
    }
    public void SetSP(bool s)
    {
        sp = s;
    }
    public float GetVelAtual()
    {
        return velAtual;
    }
    public bool GetShoot()
    {
        return shoot;
    }
    public bool GetSP()
    {
        return sp;
    }
}
