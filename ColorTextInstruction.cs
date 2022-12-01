using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Object = System.Object;
using Random = UnityEngine.Random;


public class ColorTextInstruction : MonoBehaviour
{
    public SquareObject squareParametre;
    static readonly Color[] ColorTemplate = { Color.red, Color.blue, Color.green};
    public string[] colorName = { "Rouge", "Bleu", "Vert" };
    private readonly List<Color> _colors = new List<Color>(ColorTemplate);
    public static Color InstructionColor;
    

    private void Start()
    {
        InvokeRepeating(nameof(CheckList), 0.1f, 1.5f);
    }

    public void CheckList()
    {
        //Couleur du text
        Color textColor = GetComponent<TextMeshPro>().color = squareParametre.lstColor[Random.Range(0, squareParametre.lstColor.Count)];
        //Couleur de l'instruction
        InstructionColor = squareParametre.lstColor[Random.Range(0, squareParametre.lstColor.Count)];

        while (InstructionColor == textColor)
        {
            InstructionColor = squareParametre.lstColor[Random.Range(0, squareParametre.lstColor.Count)];
        }
        
        if(InstructionColor == Color.red)
            GetComponent<TextMeshPro>().text = colorName[0];
        if(InstructionColor == Color.blue)
            GetComponent<TextMeshPro>().text = colorName[1];
        if(InstructionColor == Color.green)
            GetComponent<TextMeshPro>().text = colorName[2];
    }
}
