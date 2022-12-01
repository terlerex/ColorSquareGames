using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DestroySquare : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        if (gameObject.GetComponent<Renderer>().material.color != ColorTextInstruction.InstructionColor)
        {
            Debug.LogWarning("You can't destroy this square");
            return;
        }
        
        UpdateText();
        ScoreManager.AddScore(5);
    }
    
    void UpdateText()
    {
        ColorTextInstruction.InstructionColor = Color.black;
        GameObject.FindWithTag("InstructionText").GetComponent<TextMeshPro>().color = new Color(0f, 0f, 0f, 0f);
    }
}
