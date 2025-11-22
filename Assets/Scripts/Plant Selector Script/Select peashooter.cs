using UnityEngine;

public class Selectpeashooter : MonoBehaviour
{
    public int plantIndex = 0; 
    public void pea()
    {
        plant_Manager.selectedPlantIndex = plantIndex; //sets peashooter to the array in plant_manager to 0
        Debug.Log("Selected index: " + plant_Manager.selectedPlantIndex);

    }
}
