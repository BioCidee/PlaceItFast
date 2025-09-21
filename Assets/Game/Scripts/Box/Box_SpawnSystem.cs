using System.Collections.Generic;
using System.Linq.Expressions;
using NUnit.Framework.Constraints;
using UnityEngine;

public class Box_SpawnSystem : MonoBehaviour
{
    [Header("---- Spawn Parameters ----")]
    [SerializeField] private bool isPlayerIn = false;
    [SerializeField] private int NumberOfObjectToSpawn = 1;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] Transform spawnPoint;

    [Header("---- Object To Spawn ----")]
    [SerializeField] private List<GameObject> listObjectCanSpawn = new List<GameObject>();

    [Header("---- Object On Top ----")]
    [SerializeField] private GameObject objectOnTop;

    [Header("---- Spawn Timer Parameters ----")]
    [SerializeField] private float SpawnRate;
    private float timer;

    void Awake()
    {
        isPlayerIn = false;
    }

    void Update()
    {
        SpawnTimer();
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Is in : {other.gameObject.name}");
        if (ToolBox.IsInLayerMask(other.gameObject, playerLayer))
            isPlayerIn = true;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log($"Is out : {other.gameObject.name}");
        if (ToolBox.IsInLayerMask(other.gameObject, playerLayer))
            isPlayerIn = false;
    }

    public GameObject GiveObjectOnTop()
    {
        if (objectOnTop == null)
            Debug.LogError($"There is nos object on top of {this.name} to give !");

        return objectOnTop;
    }

    public void DeletObjectOnTop()
    {
        if(objectOnTop == null)
            Debug.LogError($"There is no object to delete on {this.name}!");

        objectOnTop = null;
    }

    private void SpawnTimer()
    {
        if (timer >= SpawnRate)
        {
            timer = 0;
            SpawnObject(NumberOfObjectToSpawn);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void SpawnObject(int _numberToSpawn)
    {
        if (objectOnTop != null)
            return;

        for (int i = 0; i < _numberToSpawn; i++)
            {
                GameObject newObject = Instantiate(listObjectCanSpawn[Random.Range(0, listObjectCanSpawn.Count)]);
                newObject.transform.position = spawnPoint.position;
                newObject.transform.rotation = spawnPoint.rotation;

                objectOnTop = newObject;
            }
    }
}
