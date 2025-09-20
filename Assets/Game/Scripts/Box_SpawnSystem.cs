using System.Collections.Generic;
using UnityEngine;

public class Box_SpawnSystem : MonoBehaviour
{
    [Header("---- Object To Spawn ----")]
    [SerializeField] private List<GameObject> objectToSpawn = new List<GameObject>();

    [Header("---- Object On Top ----")]
    [SerializeField] private GameObject objectOnTop;

    public GameObject GiveObjectOnTop()
    {
        return objectOnTop;
    }

    private void DeletObjectOnTop()
    {
        
    }
}
