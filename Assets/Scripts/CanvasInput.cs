using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasInput : MonoBehaviour
{
    public Button btnClick;
    public InputField answer;
    public GameObject human;
    public AudioSource killSound;
    public GameObject canvas;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    private void Start(){
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        Debug.Log("Input : " + answer.text);
        if(answer.tag == "Question Easy 1" && answer.text == "4"){
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Medium 1" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Hard 1" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Easy 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Medium 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Hard 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Easy 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Medium 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Hard 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Easy 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Medium 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Hard 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Easy 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Medium 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
        if (answer.tag == "Question Hard 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
        }
    }

    IEnumerator DisableCanvas( GameObject c)
    {
        yield return new WaitForSeconds(1);
        c.SetActive(false);
    }
}
