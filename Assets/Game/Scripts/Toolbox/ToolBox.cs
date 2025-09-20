using UnityEngine;

public static class ToolBox 
{
    public static bool IsInLayerMask(GameObject _obj, LayerMask _mask)
    {
        return (_mask.value & (1 << _obj.layer)) != 0;
    }
}
