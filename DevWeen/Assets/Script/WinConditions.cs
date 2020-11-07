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
    private bool lost = false;
    private float timeAtual;
    void Start()
    {
        timeAtual = timeReset;
    }

    // Update is called once per frame
    void Update()
    {
        if (!lost)
        {
            if (timeAtual > 0f)
            {
                timeAtual -= Time.deltaTime;
                timeText.text = timeAtual.ToString("F");
            }
            else
            {
                if (player[1].GetPoints() > player[2].GetPoints())
                {
                    um.W1Button();
                }
                else
                {
                    um.W2Button();
                }
            }
        }
    }
}
