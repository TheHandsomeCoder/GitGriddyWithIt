using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    Grid grid;
    Grid grid1;
    Grid grid2;
    private void Start(){
        grid = new Grid(4,2, 10f, new Vector3(20,0));
        grid1 = new Grid(4, 2, 10f, new Vector3(-20, 0));
        grid2 = new Grid(4, 2, 10f, new Vector3(0, 20));
    }

    private void Update() {
        if(Input.GetMouseButtonUp(0))
        {
            grid.SetValue(Utils.GetMouseWorldPosition(), new System.Random().Next(0, 100));
            grid1.SetValue(Utils.GetMouseWorldPosition(), new System.Random().Next(0, 100));
            grid2.SetValue(Utils.GetMouseWorldPosition(), new System.Random().Next(0, 100));
        }
    }
}