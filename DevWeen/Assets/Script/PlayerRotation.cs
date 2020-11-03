using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string inptRotaciona;
    [SerializeField] private float angularSpeed = 5f;
    private float inpt;
    // Update is called once per frame
    void Update()
    {
        inpt = Input.GetAxisRaw(inptRotaciona);
        Rotate(this.transform, angularSpeed * inpt);
    }
    private void Rotate(Transform t, float angulo)
    {
        t.Rotate(0, 0, -angulo);
    }
}
