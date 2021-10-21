using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    // Variable que indica si es Game Over
    [SerializeField] private bool isGameOver;
    // Variable que indica los puntos de vida de el jugador
    private int playerHP = 150;
    // Variable que guarda la cantidad de daño que recibe el jugador
    public int damage = 60;


    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerHP - damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if (playerHP <= 0)
            {
                Debug.Log("Te has quedado sin vida… GAME OVER");
            }
            else if (playerHP <= 30)
            {
                Debug.Log("¡¡¡Tienes poca vida!!!");
            }
            else
            {
                Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
            }
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }
}
