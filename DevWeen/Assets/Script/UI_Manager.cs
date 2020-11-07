using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UI_Manager : MonoBehaviour
{
    public RectTransform ui_Gameplay, ui_Menu, ui_Pause, ui_Credit, ui_p1, ui_p2;

    private void Awake()
    {
        ui_Gameplay.DOAnchorPos(new Vector2(0, 500), 0.01f);
        ui_Menu.DOAnchorPos(new Vector2(0, 0), 0.01f);
        ui_Pause.DOAnchorPos(new Vector2(0, 500), 0.01f);
        ui_Credit.DOAnchorPos(new Vector2(0, 500), 0.01f);
        ui_p1.DOAnchorPos(new Vector2(0, 500), 0.01f);
        ui_p2.DOAnchorPos(new Vector2(0, 500), 0.01f);
    }

    public void PlayButton()
    {
        ui_Menu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Gameplay.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void PauseButton()
    {
        ui_Gameplay.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Pause.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void UnpauseButton()
    {
        ui_Pause.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Gameplay.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void MenuButton()
    {
        ui_Credit.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Pause.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Menu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CreditButton()
    {
        ui_Menu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Credit.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CreditMenuButton()
    {
        ui_Credit.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Menu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void P1Button()
    {
        ui_p1.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Menu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void P2Button()
    {
        ui_p2.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_Menu.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void W1Button()
    {
        ui_Gameplay.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_p1.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void W2Button()
    {
        ui_Gameplay.DOAnchorPos(new Vector2(0, 500), 0.25f);
        ui_p2.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
