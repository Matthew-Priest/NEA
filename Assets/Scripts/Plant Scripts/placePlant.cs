using UnityEngine;
using UnityEngine.InputSystem;

public class placePlant : MonoBehaviour
{
    public bool plantSelected;
    public Vector3 mouseworldPosition;
    public void plantPlacer()
    {

        mouseworldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //changes mouse coords from screen coords to world coords
        mouseworldPosition.z = 0; //2D 
        Debug.Log("Mouse screen pos: " + Input.mousePosition);
        Debug.Log("Mouse world pos: " + mouseworldPosition);

        if (checkEmpty(mouseworldPosition))
       {
            if (plant_Manager.selectedPlantIndex < 0 || plant_Manager.selectedPlantIndex >= plant_Manager.Instance.plantPrefabs.Length)
            {
                Debug.LogError("Invalid plant index: " + plant_Manager.selectedPlantIndex);
                return;
            }

            Instantiate(plant_Manager.Instance.plantPrefabs[plant_Manager.selectedPlantIndex], mouseworldPosition, Quaternion.identity);
            Debug.Log("object created");

       }
    }
    public bool checkEmpty(Vector3 worldCoords)
    {
        return true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && plant_Manager.selectedPlantIndex != -1) //ensures that a plant isn't placed when clicking plant button
        {
            Debug.Log("click registered");
            plantPlacer();
            plant_Manager.selectedPlantIndex = -1; //choice resets after placing
            Debug.Log("choice reset");
        }
    }

}


    

