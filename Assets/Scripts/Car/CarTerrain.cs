using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTerrain : MonoBehaviour
{
    public TerrainSpeed currentTerrain;

    public float SpeedMultiplier(){
        if(currentTerrain != null){
            return currentTerrain.speedMultiplier;
        }
        else{
            return 1.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Terrain"){
            currentTerrain = col.GetComponent<TerrainSpeed>();
        }
    }

    // Checks if the car has stopped touching a terrain
    void OnTriggerExit2D(Collider2D col){
        if(col.tag == "Terrain" && 
            currentTerrain != null && currentTerrain.gameObject == col.gameObject){
            currentTerrain = null;
        }
    }
}
