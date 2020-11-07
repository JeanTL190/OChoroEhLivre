using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WinConditions : MonoBehaviour
{
    [SerializeField] private float timeReset = 10f;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private PlayerAtributos [] player;
    [SerializeField] private UI_Manager um;
    [SerializeField] private Vector3 [] vetor;

    private float timeAtual;
    private bool comecou = false;


    public void TimeReset()
    {
        timeAtual = timeReset;
        comecou = true;
        player[0].GetComponent<Transform>().position = vetor[0];
        player[1].GetComponent<Transform>().position = vetor[1];
    }

    public void NotComecou()
    {
        comecou = false;
    }

    public void Comecou()
    {
        comecou = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timeAtual);
        if (comecou)
        {
            if (timeAtual > 0f)
            {
                timeAtual -= Time.deltaTime;
                timeText.text = timeAtual.ToString("F");
            }
            else
            {
                if (player[0].GetPoints() > player[1].GetPoints())
                {
                    um.W1Button();
                    comecou = false;
                }
                else if (player[0].GetPoints() < player[1].GetPoints())
                {
                    um.W2Button();
                    comecou = false;
                }
                else
                {
                    um.W3Button();
                    comecou = false;
                }
            }
        }
    }
}
