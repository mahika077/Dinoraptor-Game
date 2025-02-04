﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldPickup : MonoBehaviour
{
    public static int score = 0;
    public int value;
    public GameObject pickupEffect;
    public AudioSource CoinSound;

    public static int goldCoinNo = 0;
    // public delegate void ScoreUpdate(int value);
    // public static event ScoreUpdate OnUpdate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the game object that this script is attached to by 15 in the X axis,
        // 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
        // rather than per frame.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CoinSound.Play();
            score += value;
            Debug.Log(score);
            //OnUpdate(score);
            goldCoinNo++;
            Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);

            if((goldCoinNo >= 54) && (CanvasInput.countQues >= 15)){
                //OnUpdate(GoldPickup.score);
                StartCoroutine(ChangeScreen());
            }
        }
    }

    IEnumerator ChangeScreen(){
        yield return new WaitForSeconds(0.5f);
        //OnUpdate(GoldPickup.score);
        SceneManager.LoadScene(5);
    }

}
