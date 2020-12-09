using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTerrain : MonoBehaviour
{
    public TerrainSpeed CurrentTerrain;

    public float SpeedMultiplier(){
        if(CurrentTerrain != null){
            return CurrentTerrain.speedMultiplier;
        }
        else{
            return 1.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Terrain"){
            CurrentTerrain = col.GetComponent<TerrainSpeed>();
        }
    }

    // Checks if the car has stopped touching a terrain
    void OnTriggerExit2D(Collider2D col){
        if(col.tag == "Terrain" && 
            CurrentTerrain != null && CurrentTerrain.gameObject == col.gameObject){
            CurrentTerrain = null;
        }
    }
}
