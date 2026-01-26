using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Tilemaps;

public class placePlant : MonoBehaviour
{
    public bool plantSelected;
    public Vector3 mouseworldPosition;
    public int[] xgridborders = { -1, 1, 3, 5, 7, 9, 11, 13, 15 };
    public int[] ygridborders = { 1, -1, -3, -5, -7, -9,};
    public int[] plantPrices = { 100, 50, 50, 25 };
    public int maxX;
    public int minX;
    public int maxY;
    public int minY;
    public Dictionary<Vector3, GameObject> vectorGameObjectPairs = new Dictionary<Vector3, GameObject>();
    public Vector3 centralcoords;
    public displaySun sunscript;
    void Start()
    {
        sunscript = Object.FindFirstObjectByType<displaySun>(); //code used to link something to the script
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && plant_Manager.selectedPlantIndex != -1 && plant_Manager.isRemovingPlant == false) //ensures that a plant isn't placed when clicking plant button
        {
            Debug.Log("click registered");
            plantPlacer();
            plant_Manager.selectedPlantIndex = -1; //choice resets after placing
            Debug.Log("choice reset");
        }
        else if (Input.GetMouseButtonDown(0) && plant_Manager.selectedPlantIndex == -1 && plant_Manager.isRemovingPlant == true)
        {
            Debug.Log("click registered");
            Removeplant();
            plant_Manager.selectedPlantIndex = -1; //choice resets after placing
            Debug.Log("choice reset");
        }
    }
    public Vector3 createcentralcoords(Vector3 mouseworldPosition)
    {
        Vector3 correctPlacement = Vector3.zero; //to avoid returning a null vector3 if the if statement conditions are never met
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
                        return correctPlacement;
                    }
                }
            }
        }
        return correctPlacement;

    }
    public bool checkEmpty(Vector3 worldCoords)
    {
        bool tileoccupied = vectorGameObjectPairs.ContainsKey(worldCoords);

            if (plant_Manager.isRemovingPlant)
            {
                return tileoccupied;
            }
            else if (tileoccupied)
            {
                return false;
            }
        

        if (sunscript.outputSun() < plantPrices[plant_Manager.selectedPlantIndex])
        {
            return false;
        }
        return true;
    }
    public void plantPlacer()
    {
        Vector3 centraltile = Vector3.zero;
        mouseworldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //changes mouse coords from screen coords to world coords
        mouseworldPosition.z = 0; //2D 
        Debug.Log("Mouse screen pos: " + Input.mousePosition);
        Debug.Log("Mouse world pos: " + mouseworldPosition);
        centraltile = createcentralcoords(mouseworldPosition);
        if (checkEmpty(centraltile))
       {
            if ((plant_Manager.selectedPlantIndex == -1 && plant_Manager.isRemovingPlant == false)|| plant_Manager.selectedPlantIndex >= plant_Manager.Instance.plantPrefabs.Length)
            {
                Debug.LogError("Invalid plant index: " + plant_Manager.selectedPlantIndex);
                return;
            }
            createplant(centraltile);
       }
    }

    
    void createplant(Vector3 correctPlacement)
    {
       
            GameObject newPlant = Instantiate(plant_Manager.Instance.plantPrefabs[plant_Manager.selectedPlantIndex], correctPlacement, Quaternion.identity);
            Debug.Log("object created");
            vectorGameObjectPairs.Add(correctPlacement, newPlant);

            sunscript.decrementSun(plantPrices[plant_Manager.selectedPlantIndex]);
        
  
    }

    void Removeplant()
    {
        mouseworldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //changes mouse coords from screen coords to world coords
        mouseworldPosition.z = 0; //2D
        Vector3 correctPlacement = Vector3.zero;
        correctPlacement = createcentralcoords(mouseworldPosition);
        if(vectorGameObjectPairs.TryGetValue(correctPlacement, out GameObject plant))
        {
            Destroy(plant);
            vectorGameObjectPairs.Remove(correctPlacement);
            plant_Manager.isRemovingPlant = false;
        }


    }

}


    

