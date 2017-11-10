using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameBoard : MonoBehaviour {

	public int m_size;
    public GameObject m_puzzlePiece;

    private PuzzleSection[,] m_puzzle;

    private void Start()
    {
        GameObject temp;
        m_puzzle = new PuzzleSection[m_size, m_size];

        for(int i = 0; i < m_size; i++)
        {
            for(int j = 0; j < m_size; j++)
            {
                temp = (GameObject)Instantiate(m_puzzlePiece, new Vector2((i * 500 / m_size), (j * 250 / m_size)), Quaternion.identity);
                temp.transform.SetParent(transform);
                m_puzzle[i,j] = temp.GetComponent<PuzzleSection>();
                m_puzzle[i,j].CreatPuzzlePiece(m_size);
            }
        }

        SetupBoard();

    }

    void SetupBoard()
    {
        Vector2 offset;
        Vector2 m_scale = new Vector2(1f/m_size, 1f/ m_size) ;
        for(int i = 0; i < m_size; i++)
        {
            for(int j = 0; j < m_size; j++)
            {
                offset = new Vector2(i * (1f / m_size), j * (1f / m_size));
                m_puzzle[i, j].AssignImage(m_scale, offset);
            }
        }


    }




}
