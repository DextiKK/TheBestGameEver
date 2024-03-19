using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform valueRectTransform;

    public GameObject gameplayUI;
    public GameObject gameOverScreen;

    public PlayerController playerController;

    private float _maxValue;
    private void Start()
    {
        _maxValue = value;
        DrawHealthBar();
    }

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerIsDead();
        }
        DrawHealthBar();
        
    }

    private void PlayerIsDead()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
        playerController.enabled = false;
        GetComponent<FireWallCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }

    private void DrawHealthBar()
    {
        valueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
