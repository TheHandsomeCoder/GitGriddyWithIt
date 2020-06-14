using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils {

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        return worldPosition;
    }

}