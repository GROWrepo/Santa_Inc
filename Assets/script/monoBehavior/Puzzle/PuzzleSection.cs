using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSection : MonoBehaviour {

    Vector2 m_goodOffset;
    Vector2 m_offset;
    Vector2 m_scale;

    public void CreatPuzzlePiece(int size)
    {
        transform.localScale = new Vector3(1.0f * transform.localScale.x / size, 1.0f * transform.localScale.z / size, 1);
    
    }

    public void AssignImage(Vector2 scale, Vector2 offset)
    {
        m_goodOffset = offset;
        m_scale = scale;
        AssignImage(offset);
    }

    public void AssignImage(Vector2 offset)
    {
        m_offset = offset;
        GetComponent<RawImage>().uvRect = new Rect(offset.x, offset.y, m_scale.x, m_scale.y);
    }



}
