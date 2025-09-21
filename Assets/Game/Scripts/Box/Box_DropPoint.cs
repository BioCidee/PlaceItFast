using UnityEngine;

public class Box_DropPoint : MonoBehaviour
{
    public int playerPoint = 0;

    [Header("---- Drop Point Parameters ----")]
    [SerializeField] private LayerMask playerLayer;


    void OnTriggerEnter(Collider other)
    {
        if (ToolBox.IsInLayerMask(other.gameObject, playerLayer))
        {
            Debug.Log("Player enter in Drop Point"); 
            GameObject myBox = other.gameObject.GetComponentInParent<Player_Interact>().DropBoxInHand();
            Debug.Log(myBox);
            myBox.gameObject.GetComponentInParent<Player_Interact>().DeleteObjectInHand();

            if (myBox != null)
            {
                GetBox(myBox);
                Destroy(myBox);
            }
        }
    }

    public void GetBox(GameObject _obj)
    {
        Box_Type boxDrop = _obj.GetComponent<Box_Type>();
        if (boxDrop != null)
        {
            if (CheckTypeBox(boxDrop))
            {
                playerPoint++;
            }
            else
            {
                playerPoint--;
            }
        }
    }

    private bool CheckTypeBox(Box_Type _obj) // Return true if good, Return false if bad.
    {
        return _obj.ReturnBoxType();
    }
}
