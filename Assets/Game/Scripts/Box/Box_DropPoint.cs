using UnityEngine;

public class Box_DropPoint : MonoBehaviour
{
    public int playerPoint = 0;

    public void GetBox(GameObject _obj)
    {
        Box_Type boxDrop = _obj.GetComponent<Box_Type>();
        if (boxDrop != null)
        {
            if (CheckTypeBox(boxDrop))
            {
                
            }
            else
            {

            }
        }
    }

    private bool CheckTypeBox(Box_Type _obj) // Return true if good, Return false if bad.
    {
        return _obj.ReturnBoxType();
    }
}
