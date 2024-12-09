using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Material material;
    private void Update()
    {
        transform.position = Vector3.forward * player.position.z;
        material.SetVector("snowOffset", new Vector2(0, -player.position.z));
    }
}
