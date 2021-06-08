using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NOWA ZMIANA
public class BinarySearchAlgorithm : MonoBehaviour
{
    int min;
    int max;
    int guess;

    void StartGame()
    {   
        Debug.Log("Witaj w mojej grze. Wybierz w głowie liczbę pomiędzy 1 a 1000 ");
        Debug.Log("Komputer będzie starał się zgadnąć twoją liczbę");
        Debug.Log("Czy twoja liczba jest większa lub mniejsza od " + guess + " ?");
        Debug.Log("Aby odpowiedzieć naciśnij strzałkę w górę lub w dół lub enter " +
                  "Strzałka w górę: większa liczba, strzałka w dół: mniejsza liczba, enter: trafiona liczba");
    }

    void InitValues()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest wieksza lub mniejsza od: " + guess + " ?");
    }

    void Start()
    {
        InitValues();
        StartGame();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Haha jestem super komputerem z chin, wygralem!");
        }
    }












}
