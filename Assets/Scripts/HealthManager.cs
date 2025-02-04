﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public PlayerController thePlayer;
    public float invincibilityLength;
    private float invincibilityCounter;
    public Renderer playerRenderer;
    public Renderer playerRendererSpikes;
    private float flashCounter;
    public float flashLength=0.1f;

    private bool isRespawning;
    private Vector3 respawnPoint;
    public float respawnLength;

    public GameObject deathEffect;
    public Image blackScreen;
    private bool isFadeToBlack;
    private bool isFadeFromBlack;
    public float fadeSpeed;
    public float waitForFade;

    public Text livesText;

    // public delegate void ScoreUpdate(int value);
    // public static event ScoreUpdate OnUpdate;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
        //thePlayer = FindObjectOfType<PlayerController>();
        //respawnPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(invincibilityCounter>0)
        {
            invincibilityCounter-=Time.deltaTime;

            flashCounter-=Time.deltaTime;

            if(flashCounter<=0)
            {
                playerRenderer.enabled = !playerRenderer.enabled;
                playerRendererSpikes.enabled=!playerRendererSpikes.enabled;
                flashCounter=flashLength;
            }

            if(invincibilityCounter<=0){
                playerRenderer.enabled=true;
                playerRendererSpikes.enabled=true;
            }
        }

        if (isFadeToBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if(blackScreen.color.a == 1f)
            {
                isFadeToBlack = false;
            }
        }

        if (isFadeFromBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (blackScreen.color.a == 0f)
            {
                isFadeFromBlack = false;
            }
        }

        ChangeLives(currentHealth);
    }
    
    public void HurtPlayer(int damage, Vector3 direction)
    {
        if(invincibilityCounter<=0)
        {
            currentHealth -= damage;
            
            if (currentHealth <= 0)
            {
                //respawn();
                Instantiate(deathEffect, thePlayer.transform.position, thePlayer.transform.rotation);
                thePlayer.gameObject.SetActive(false);
                isFadeToBlack = true;
                StartCoroutine(ChangeScreen());
                
            }
            else
            {

                thePlayer.Knockback(direction);

                invincibilityCounter = invincibilityLength;

                playerRenderer.enabled = false;
                playerRendererSpikes.enabled = false;

                flashCounter = flashLength;
            }
        }
        
    }

    public void ChangeLives(int currentHealth)
    {
        livesText.text = "Lives: " + currentHealth ;
    }

    IEnumerator ChangeScreen()
    {
        yield return new WaitForSeconds(0.75f);
        //OnUpdate(GoldPickup.score);
        isFadeToBlack = false;
        Debug.Log("Game Over");
        SceneManager.LoadScene(6);
    }


    /* public void respawn()
     {
         //thePlayer.transform.position = respawnPoint;
         //currentHealth = maxHealth;
         if (!isRespawning)
         {
             StartCoroutine("Respawnco");
         }
     }
     public IEnumerator Respawnco()
     {
         isRespawning = true;
         thePlayer.gameObject.SetActive(false);
         Instantiate(deathEffect, thePlayer.transform.position, thePlayer.transform.rotation);

         yield return new WaitForSeconds(respawnLength);

         isFadeToBlack = true;

         yield return new WaitForSeconds(waitForFade);

         isFadeToBlack = false;
         isFadeFromBlack = true;

         isRespawning = false;

         thePlayer.gameObject.SetActive(true);
         thePlayer.transform.position = respawnPoint;
         currentHealth = maxHealth;

         invincibilityCounter = invincibilityLength;

         playerRenderer.enabled = false;
         playerRendererSpikes.enabled = false;

         flashCounter = flashLength;

     }*/

    /*public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            /*invincibilityCounter = invincibilityLength;

            playerRenderer.enabled = false;
            playerRendererSpikes.enabled = false;

            flashCounter = flashLength;
        }
    }

    public void setSpawnPoint(Vector3 newPosition)
    {
        respawnPoint = newPosition;
    }*/
}

   