using System.Collections.Generic;
using UnityEngine;

public class Box_SpawnSystem : MonoBehaviour
{
    [Header("---- Spawn Parameters ----")]
    [SerializeField] private bool isPlayerIn = false;
    [SerializeField] private LayerMask playerLayer;

    [Header("---- Object To Spawn ----")]
    [SerializeField] private List<GameObject> objectToSpawn = new List<GameObject>();

    [Header("---- Object On Top ----")]
    [SerializeField] private GameObject objectOnTop;

    void Awake()
    {
        isPlayerIn = false;
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
        return objectOnTop;
    }

    private void DeletObjectOnTop()
    {
        objectOnTop = null;
    }
}
