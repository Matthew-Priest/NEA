using UnityEngine;
using UnityEngine.InputSystem;

public class placePlant : MonoBehaviour
{
    public bool plantSelected;
    public Vector3 mouseworldPosition;
    public int[] xgridborders = { -1, 1, 3, 5, 7, 9, 11, 13, 15 };
    public int[] ygridborders = { 1, -1, -3, -5, -7, -9,};
    public int maxX;
    public int minX;
    public int maxY;
    public int minY;
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
            placeAtCentre(mouseworldPosition);
            

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
    void placeAtCentre(Vector3 mouseworldPosition)
    {
        Vector3 correctPlacement;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                minX = xgridborders[i];
                maxX = xgridborders[i + 1];
                minY = ygridborders[j];
                maxY = ygridborders[j + 1];
                if (mouseworldPosition.x >= minX && mouseworldPosition.x <= maxX)
                {
                    if (mouseworldPosition.y <= minY && mouseworldPosition.y >= maxY)
                    {
                        correctPlacement = new Vector3(minX + 1, minY - 1, 0);
                        Debug.Log(correctPlacement);
                        Instantiate(plant_Manager.Instance.plantPrefabs[plant_Manager.selectedPlantIndex],correctPlacement, Quaternion.identity);
                        Debug.Log("object created");
                    }
                }
            }
        }
        
    }

}


    

