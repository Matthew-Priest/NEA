using UnityEngine;

public class plant_Manager : MonoBehaviour
{
    public static plant_Manager Instance;
    public static bool isRemovingPlant = false;

    public GameObject[] plantPrefabs; // creates array to be filled with prefabs of plants


    public static int selectedPlantIndex = -1; //sets currently stored prefab as none

    private void Awake() //runs once a game object has been created in the scene
    {
        Instance = this; //tells unity that this is the only plant manager to be created. means other scripts can reference plant_manager by saying plant_manager.instance
    }
    
}
