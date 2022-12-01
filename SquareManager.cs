using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;


public class SquareManager : MonoBehaviour
{
    public List<GameObject> squareToSpawn;
    public SquareObject squareParametre;
    public static List<Color> colors = new List<Color>();
    private int _instanceNumber = 1;
    
    private void Start()
    {
        SpawnSquare();
    }

    private void SpawnSquare()
    {
        //Shuffle the color list
        var rnd = new Random();
        var randomized = squareParametre.lstColor.OrderBy(item => rnd.Next());
        colors = randomized.ToList();

        int currentIndex = 0;

        for (int i = 0; i < squareParametre.numberOfPrefabsToCreate; i++)
        {
            GameObject square = Instantiate(squareToSpawn[i], squareParametre.lstPosition[currentIndex], Quaternion.identity);
            square.GetComponent<MeshRenderer>().material.color = colors[currentIndex];
            square.name = squareParametre.prefabName + i;

            //Set color and position of the next square with list index
            //Increment the index
            currentIndex = (currentIndex + 1) % squareParametre.lstPosition.Count;

            _instanceNumber++;
        }
    }
}
