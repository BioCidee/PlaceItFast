using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    [Header("---- Object In Hand ----")]
    [SerializeField] private GameObject objectInHand;

    public void SetObjectInHand(GameObject _newObject)
    {
        if (objectInHand != null)
        {
            DeleteObjectInHand();
        }

        objectInHand = _newObject;
    }

    public GameObject GiveObject()
    {
        if (objectInHand == null)
            Debug.LogError("There is nos object in player hand to return");

        return objectInHand;
    }

    private void DeleteObjectInHand()
    {
        objectInHand = null;
    }
}
