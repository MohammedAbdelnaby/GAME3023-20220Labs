using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerPrefab;

    private static PlayerCharacterMovement Player;

    void Awake()
    {
        if (Player == null)
        {
            
            GameObject newObj = Instantiate(PlayerPrefab, transform.position, Quaternion.identity);
            Player = newObj.GetComponent<PlayerCharacterMovement>();
        }
    }
}
