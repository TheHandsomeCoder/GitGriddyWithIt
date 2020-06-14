using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    Grid grid;
    private void Start(){
         grid = new Grid(4,2, 10f);
    }

    private void Update() {
        if(Input.GetMouseButtonUp(0))
        {
            grid.SetValue(Utils.GetMouseWorldPosition(), new System.Random().Next(0, 100));
        }
    }
}