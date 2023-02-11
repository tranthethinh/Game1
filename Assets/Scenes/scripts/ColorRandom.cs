using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorRandom : MonoBehaviour
{
    public Score score;
    public Material[] material;
    public WinLoseScreen WinLoseScreen;
    public void endgame(){
        WinLoseScreen.Setup(score.score);
    }
    Renderer rend;

   void Start(){

     int i;
     i=Random.Range(0,2);

     score = FindObjectOfType<Score>();
    rend= GetComponent<Renderer>();
    rend.enabled=true;
    rend.sharedMaterial=material[i];
   }

void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "ball"){
        Renderer ballRenderer = other.gameObject.GetComponent<Renderer>();
         if (rend.sharedMaterial == ballRenderer.sharedMaterial) {
            int i;
            i=Random.Range(0,3);
            rend.sharedMaterial=material[i];
            score.AddScore(1);
            if (score.score == 10) {
                endgame();
                // End the game with a win
                
                //Debug.Log("You Win!");
            }
        } else {
            endgame();
            // End the game
            
            //Debug.Log("Game Over");
        }
    }
}
}

