using UnityEngine;

public class Box_Trash : MonoBehaviour
{
    public int playerPoint = 0;

    [Header("---- Drop Point Parameters ----")]
    [SerializeField] private LayerMask playerLayer;


    void OnTriggerEnter(Collider other)
    {
        if (ToolBox.IsInLayerMask(other.gameObject, playerLayer))
        {
            GameObject myBox = other.gameObject.GetComponentInParent<Player_Interact>().DropBoxInHand();
            myBox.gameObject.GetComponentInParent<Player_Interact>().DeleteObjectInHand();

            if (myBox != null)
            {
                Destroy(myBox);
            }
        }
    }
}
