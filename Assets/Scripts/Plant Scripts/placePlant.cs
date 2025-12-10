using UnityEngine;
using UnityEngine.InputSystem;

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
    public Vector3[] fulltiles = new Vector3[40]; //assigned
    public int freespacepointer = 0;
    public Vector3 centralcoords;
    public displaySun sunscript;
    void Start()
    {
        sunscript = Object.FindFirstObjectByType<displaySun>(); //code used to link something to the script
    }
    public void plantPlacer()
    {
        
        mouseworldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //changes mouse coords from screen coords to world coords
        mouseworldPosition.z = 0; //2D 
        Debug.Log("Mouse screen pos: " + Input.mousePosition);
        Debug.Log("Mouse world pos: " + mouseworldPosition);

        if (checkEmpty(createcentralcoords(mouseworldPosition)))
       {
            if (plant_Manager.selectedPlantIndex < 0 || plant_Manager.selectedPlantIndex >= plant_Manager.Instance.plantPrefabs.Length)
            {
                Debug.LogError("Invalid plant index: " + plant_Manager.selectedPlantIndex);
                return;
            }
            placeplant(createcentralcoords(mouseworldPosition));
       }
    }
    public bool checkEmpty(Vector3 worldCoords)
    {
        for (int i = 0; i < fulltiles.Length; i++)
        {
            if (fulltiles[i] == worldCoords)
            {
                return false;
            }
        }
        switch (plant_Manager.selectedPlantIndex)
        {
            case 0:
                if (sunscript.outputSun() < 100)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            case 1:
                if (sunscript.outputSun() < 50)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            case 2:
                if (sunscript.outputSun() < 50)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            case 3:
                if (sunscript.outputSun() < 25)
                {
                    return false;
                }
                else
                {
                    return true;
                }                
        }
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
    void placeplant(Vector3 correctPlacement)
    {

         Instantiate(plant_Manager.Instance.plantPrefabs[plant_Manager.selectedPlantIndex],correctPlacement, Quaternion.identity);
         Debug.Log("object created");
         fulltiles[freespacepointer] = correctPlacement;
        if (freespacepointer < 39)
        {
            freespacepointer += 1;
        }
        sunscript.decrementSun(plantPrices[plant_Manager.selectedPlantIndex]);  
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

}


    

