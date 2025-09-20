using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    [Header("---- Object In Hand ----")]
    [SerializeField] private GameObject objectInHand;


    void Update()
    {
        if (GetInteractionInput())
        {
            if (IsAlreadyAObjectInHand())
            {
                
            }
        }
    }


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

    private bool GetInteractionInput()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            return true;
        }

        return false;
    }

    private void DeleteObjectInHand()
    {
        objectInHand = null;
    }

    private bool IsAlreadyAObjectInHand()
    {
        if (objectInHand != null)
        {
            return true;
        }

        return false;
    }
}
