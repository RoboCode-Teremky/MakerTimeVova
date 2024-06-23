using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public static UnityEvent finishReached = new UnityEvent();
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player")){
            finishReached.Invoke();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //Time.timeScale = 0f;
        }
    }
}