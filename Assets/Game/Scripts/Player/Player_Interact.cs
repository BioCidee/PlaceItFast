using Unity.Mathematics;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    [Header("---- Object In Hand ----")]
    [SerializeField] private GameObject objectInHand;
    [SerializeField] private Transform objParent;

    void Update()
    {
        if (GetInteractionInput())
        {
            if (!IsAlreadyAObjectInHand())
            {
                RaycastHit[] hits = Physics.BoxCastAll(transform.position, new Vector3(0.5f, 1f, 0.5f), transform.forward, quaternion.identity);

                foreach (RaycastHit obj in hits)
                {
                    Box_SpawnSystem Box = obj.collider.gameObject.GetComponent<Box_SpawnSystem>();

                    if (Box)
                    {
                        SetObjectInHand(Box.GiveObjectOnTop());
                        Box.DeletObjectOnTop();
                    }
                }
            }
        }
    }

    public GameObject DropBoxInHand()
    {
        if (!objectInHand)
            return null;

        return objectInHand;
    }

    private void SetObjectInHand(GameObject _newObject)
    {
        objectInHand = _newObject;

        _newObject.transform.SetParent(objParent);
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

    public void DeleteObjectInHand()
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
