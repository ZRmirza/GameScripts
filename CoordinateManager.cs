using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CoordinateManager : MonoBehaviour
{
    public int PlayerOnePosition = 1;
    private Dictionary<string, Vector3> gamePieceLocation = new Dictionary<string, Vector3>();
    private Dictionary<string, Vector3> positions = new Dictionary<string, Vector3>
    {
        {"Position 1", new Vector3(1.0f, 0.5f, 0.0f)},
        {"Position 2", new Vector3(1.0f, 0.5f, 1.0f)},
        {"Position 3", new Vector3(1.0f, 0.5f, 2.0f)},
        {"Position 4", new Vector3(1.0f, 0.5f, 3.0f)},
        {"Position 5", new Vector3(1.0f, 0.5f, 4.0f)},
        {"Position 6", new Vector3(1.0f, 0.5f, 5.0f)},
        {"Position 7", new Vector3(1.0f, 0.5f, 6.0f)},
        {"Position 8", new Vector3(1.0f, 0.5f, 7.0f)},
        {"Position 9", new Vector3(1.0f, 0.5f, 8.0f)},
        {"Position 10", new Vector3(1.0f, 0.5f, 9.0f)},
        {"Position 11", new Vector3(1.0f, 0.5f, 10.0f)},
        {"Position 12", new Vector3(2.0f, 0.5f, 10.0f)},
        {"Position 13", new Vector3(3.0f, 0.5f, 10.0f)},
        {"Position 14", new Vector3(4.0f, 0.5f, 10.0f)},
        {"Position 15", new Vector3(5.0f, 0.5f, 10.0f)},
        {"Position 16", new Vector3(6.0f, 0.5f, 10.0f)},
        {"Position 17", new Vector3(7.0f, 0.5f, 10.0f)},
        {"Position 18", new Vector3(8.0f, 0.5f, 10.0f)},
        {"Position 19", new Vector3(9.0f, 0.5f, 10.0f)},
        {"Position 20", new Vector3(10.0f, 0.5f, 10.0f)},
        {"Position 21", new Vector3(11.0f, 0.5f, 10.0f)},
        {"Position 22", new Vector3(11.0f, 0.5f, 9.0f)},
        {"Position 23", new Vector3(11.0f, 0.5f, 8.0f)},
        {"Position 24", new Vector3(11.0f, 0.5f, 7.0f)},
        {"Position 25", new Vector3(11.0f, 0.5f, 6.0f)},
        {"Position 26", new Vector3(11.0f, 0.5f, 5.0f)},
        {"Position 27", new Vector3(11.0f, 0.5f, 4.0f)},
        {"Position 28", new Vector3(11.0f, 0.5f, 3.0f)},
        {"Position 29", new Vector3(11.0f, 0.5f, 2.0f)},
        {"Position 30", new Vector3(11.0f, 0.5f, 1.0f)},
        {"Position 31", new Vector3(11.0f, 0.5f, 0.0f)},
        {"Position 32", new Vector3(10.0f, 0.5f, 0.0f)},
        {"Position 33", new Vector3(9.0f, 0.5f, 0.0f)},
        {"Position 34", new Vector3(8.0f, 0.5f, 0.0f)},
        {"Position 35", new Vector3(7.0f, 0.5f, 0.0f)},
        {"Position 36", new Vector3(6.0f, 0.5f, 0.0f)},
        {"Position 37", new Vector3(5.0f, 0.5f, 0.0f)},
        {"Position 38", new Vector3(4.0f, 0.5f, 0.0f)},
        {"Position 39", new Vector3(3.0f, 0.5f, 0.0f)},
        {"Position 40", new Vector3(2.0f, 0.5f, 0.0f)},
    };




    public void UpdatePlayerOnePosition()
    {
        System.Random random = new System.Random();
        bool End = false;
        while (!End)
        {
            while (PlayerOnePosition < 10)
            {
                int i = 0;
                int diceTotal = random.Next(1, 13);  // Generate a new dice roll inside the loop

                while (i < diceTotal)
                {
                    PlayerOnePosition++;
                    i++;

                    if (PlayerOnePosition > 40)
                    {
                        PlayerOnePosition = 1;  // Reset Position to 1 if it exceeds 10
                    }
                }

                End = true;  // Exit the outer while loop after one dice roll
                break;
            }
        }

        // Print the final Position value
        Console.WriteLine("Position: " + PlayerOnePosition);
    }



    private void Start()
    {
        // Assuming you have a GameObject named "MyObject" in your scene
        GameObject myObject = GameObject.Find("Player 1 Piece (1)");

        // Check if the GameObject was found
        if (myObject != null)
        {
            // Get the coordinates of the GameObject's position
            Vector3 objectPosition = myObject.transform.position;

            // Add the coordinates to the dictionary with a key
            gamePieceLocation["Player 1 Piece"] = objectPosition;

            // Print the coordinates to the console
            Debug.Log("Coordinates of Player 1 Piece: " + objectPosition);
        }
        else
        {
            Debug.LogError("Player 1 Piece not found in the scene.");
        }


    }
}