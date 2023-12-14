using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityChecker : MonoBehaviour
{
    public GameObject Customer;
    public GameObject MainCamera;
    public GameObject WinPanel;
    public GameObject ProximityPanel;
    public GameObject Pot;
    public GameObject Meat;
    public GameObject Apple;
    public GameObject Cheese;
    public GameObject Tomato;
    public GameObject Pumpkin;
    public GameObject Sausage;
    public float proximityThreshold = 1f;
    private bool hasAllMeatStew = false;
    private bool hasAllVeggieSoup = false;

    private bool mealCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        ProximityPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Debug.Log("Meat is not close enough. Disabling Meat.");

        // Make food invisible if close enough
        if (Vector3.Distance(Customer.transform.position, Meat.transform.position) < proximityThreshold)
        {
            Meat.SetActive(false);
            // Debug.Log("close enough. Disabling Meat.");
        }
        if (Vector3.Distance(Customer.transform.position, Apple.transform.position) < proximityThreshold)
        {
            Apple.SetActive(false);
        }
        if (Vector3.Distance(Customer.transform.position, Cheese.transform.position) < proximityThreshold)
        {
            Cheese.SetActive(false);
        }
        if (Vector3.Distance(Customer.transform.position, Tomato.transform.position) < proximityThreshold)
        {
            Tomato.SetActive(false);
        }
        if (Vector3.Distance(Customer.transform.position, Pumpkin.transform.position) < proximityThreshold)
        {
            Pumpkin.SetActive(false);
        }
        if (Vector3.Distance(Customer.transform.position, Sausage.transform.position) < proximityThreshold)
        {
            Sausage.SetActive(false);
        }
        // Check if all ingredients for recipe have been collected

        // Meat Stew
        if ((!Meat.activeInHierarchy) && (!Cheese.activeInHierarchy) && (!Tomato.activeInHierarchy) && (!Sausage.activeInHierarchy))
        {
            hasAllMeatStew = true;
        }

        // Veggie Soup
        if ((!Cheese.activeInHierarchy) && (!Tomato.activeInHierarchy) && (!Pumpkin.activeInHierarchy) && (!Apple.activeInHierarchy))
        {
            hasAllVeggieSoup = true;
        }

        // Checks if Completed
        if (((hasAllMeatStew) || (hasAllVeggieSoup)) && (Vector3.Distance(MainCamera.transform.position, Pot.transform.position) < proximityThreshold))
        {
            mealCompleted = true;
            Pot.SetActive(false);
        }

        // Checks distance between customer and completed meal
        if ((mealCompleted) && ((Vector3.Distance(MainCamera.transform.position, Customer.transform.position) < proximityThreshold)))
        {
            WinPanel.SetActive(true);
        }
        if ((!mealCompleted) && ((Vector3.Distance(MainCamera.transform.position, Customer.transform.position) < proximityThreshold)))
        {
            ProximityPanel.SetActive(true);
        }
        if ((!mealCompleted) && ((Vector3.Distance(MainCamera.transform.position, Customer.transform.position) >= proximityThreshold)))
        {
            // ProximityPanel.SetActive(false);
        }
    }
}
