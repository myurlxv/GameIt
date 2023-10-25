using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGameController : MonoBehaviour
{
    public GameObject blockPrefab;
    public int boardWidth = 5;
    public int boardHeight = 5;

    private GameObject[,] board;

    void Start()
    {
        InitializeBoard();
    }

    void InitializeBoard()
    {
        board = new GameObject[boardWidth, boardHeight];

        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                Vector3 position = new Vector3(x, y, 0);
                GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                board[x, y] = block;
            }
        }
    }

    // Add code for block swapping, matching, scoring, and game over conditions here.
}
