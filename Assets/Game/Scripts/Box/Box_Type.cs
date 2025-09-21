using UnityEngine;

public class Box_Type : MonoBehaviour
{
    [Header("---- Box Type -----")]
    [SerializeField] private bool imAmAGoodBox;


    public bool ReturnBoxType()
    {
        return imAmAGoodBox;
    }
}
