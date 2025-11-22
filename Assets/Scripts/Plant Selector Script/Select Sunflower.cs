using UnityEngine;

public class SelectSunflower : MonoBehaviour
{
    public int plantIndex = 2; 
    public void sunflower()
    {
        plant_Manager.selectedPlantIndex = plantIndex; //sets sunflower to the array in plant_manager to 0
        Debug.Log("Selected index: " + plant_Manager.selectedPlantIndex);
    }
}
