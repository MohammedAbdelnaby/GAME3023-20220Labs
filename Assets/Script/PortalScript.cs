using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Traveller traveller = collision.GetComponent<Traveller>();
        if (traveller != null)
        {
            Debug.Log("Portal warping:" + traveller.gameObject.name);

            SceneManager.LoadScene(tag , LoadSceneMode.Single);
        }
    }
}
