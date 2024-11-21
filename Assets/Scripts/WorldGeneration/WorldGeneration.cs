using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    //gameplay
    private float chunkSpawnZ;
    private Queue<Chunk> activeChunks = new Queue<Chunk>();
    private List<Chunk> chunkPool = new List<Chunk>();
    //cònigurable field
    [SerializeField] private int firstChunkSpawnPosition = -10;
    [SerializeField] private int chunkOnScreen = 5;
    [SerializeField] private float despawnDistance = 5.0f;

    [SerializeField] private List<GameObject> chunkPrefabs;
    [SerializeField] private Transform cameraTransform;
    #region TO DELETE $$
    private void Awake()
            {
        ResetWorld();
    }
    #endregion
    private void Start()
    {
        //check if we have an empty chunk prefab 
        if(chunkPrefabs.Count == 0)
        {
            Debug.LogError("No chunk prefabs found");
            return;
        }
        //try to assgin the camera transform
        if(!cameraTransform)
        {
            cameraTransform = Camera.main.transform;
            Debug.Log("Assign the main camera transform");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        ScanPosition();
    }
    private void ScanPosition()
    {
        float cameraZ = cameraTransform.position.z;
        Chunk lastChunk = activeChunks.Peek();
        if(cameraZ >= lastChunk.transform.position.z + lastChunk.chuckLength + despawnDistance)
        {
            SpawnNewChunk();
            DeleteLastChunk();
        }

    }
    private void SpawnNewChunk()
    {
        //get a random index for the chunk prefab to spawn
        int randomIndex = Random.Range(0, chunkPrefabs.Count);
        //does it already exist in the pool?
        Chunk chunk = chunkPool.Find(x => !x.gameObject.activeSelf && x.name == (chunkPrefabs[randomIndex].name) + "(Clone)");
        //create a chunk if wee don't have any in the pool
        if(!chunk)
        {
            GameObject go = Instantiate(chunkPrefabs[randomIndex], transform);
            chunk = go.GetComponent<Chunk>();
        }
        //place the object and show it
        chunk.transform.position = new Vector3(0,0,chunkSpawnZ);
        chunkSpawnZ += chunk.chuckLength;
        //store the value; to recue in our pool
        activeChunks.Enqueue(chunk);
        chunk.ShowChunk();
    }
    private void DeleteLastChunk()
    {
        Chunk chunk = activeChunks.Dequeue();
        chunk.HideChunk();
        chunkPool.Add(chunk);
    }
    private void ResetWorld()
    {
        //reset the chunk spawn z
        chunkSpawnZ = firstChunkSpawnPosition;
        for(int i = activeChunks.Count; i != 0; i--)
        {
            DeleteLastChunk();
        }
        for(int i = 0; i < chunkOnScreen; i++)
        {
            SpawnNewChunk();
        }
    }
}
