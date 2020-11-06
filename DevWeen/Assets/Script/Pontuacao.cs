using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tm1;
    [SerializeField] private TextMeshProUGUI tm2;
    [SerializeField] private PlayerAtributos pa1;
    [SerializeField] private PlayerAtributos pa2;
    void Update()
    {
        tm1.text = pa1.GetPoints().ToString();
        tm2.text = pa2.GetPoints().ToString();
    }
}
