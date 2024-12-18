using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public float chuckLength;
    public Chunk ShowChunk()
    {
        gameObject.SetActive(true);
        return this;
    }
    public Chunk HideChunk()
    {
        gameObject.SetActive(false);
        return this;
    }
}
