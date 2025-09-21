using UnityEngine;

public class Box_Type : MonoBehaviour
{
    [Header("---- Box Type -----")]
    [SerializeField] private bool iAmAGoodBox;


    public bool ReturnBoxType()
    {
        return iAmAGoodBox;
    }
}
