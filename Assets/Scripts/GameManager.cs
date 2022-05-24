using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemsMeunu;
    public event Action OnARPosition;


    public static GameManager instance;

    private void Awake(GameObject instance)
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _ = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");

    }


    public void ItemsMenu()
    {
        OnItemsMeunu?.Invoke();
        Debug.Log("Items Menu Activated");

    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("Items Menu Activated");

    }

}
