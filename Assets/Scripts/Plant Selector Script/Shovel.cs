using UnityEngine;

public class Shovel : MonoBehaviour
{
    public int plantIndex = -1; //initally used -1 but this could further impact code as intially when game compiled,
                                   //index is set to -1 so if removing it when index = -1 would cause clicking any plant to be removed
    public void shovel()
    {
        plant_Manager.selectedPlantIndex = plantIndex;//sets sunflower to the array in plant_manager to 0
        plant_Manager.isRemovingPlant = true;
        Debug.Log("Selected index: " + plant_Manager.selectedPlantIndex);
        Debug.Log("Removing plant enabled");
    }
}
