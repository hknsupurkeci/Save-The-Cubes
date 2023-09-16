using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPozs;
    [SerializeField] GameObject[] squarePrefs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SquareSpawner());
    }
    protected IEnumerator SquareSpawner()
    {
        while (true)
        {
            int selectedSquare = Random.Range(0, spawnPozs.Length);
            Instantiate(squarePrefs[selectedSquare], spawnPozs[selectedSquare].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
