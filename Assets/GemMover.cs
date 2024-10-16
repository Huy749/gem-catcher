using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum ItemType {
    gem,
    speedbooster,
    timebooster
}
public class GemMover : MonoBehaviour
{
    // khai bao bien so thuc bang 5
   //  public ItemType itemType;  
   public bool isGem;
   public bool isSpeedbooster;
   public bool isTimebooster;
    public float speed = 5f;
    public int scoreAmount;
    public int speedboostAmount;
    public int timeboostAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); //tao chuyen dong theo phuong thang
    }
    private void OnTriggerEnter2D(Collider2D other) // bien other thong tin bat ky collider nao va cham
    {
        if (other.gameObject.CompareTag("Player"))
        //neu cham Player
        {
            Debug.Log(" cham Ngoc");
            if (isGem) {
                 ScoreManager.Instance.AddScore(scoreAmount);
            }
            if (isSpeedbooster)
            {
                CharacterMovement.AddSpeed(speedboostAmount);
            }
            if (isTimebooster)
            {
                ScoreManager.Instance.AddTime(timeboostAmount);
            } 
            
            Destroy(gameObject); //xoa gameObject gan collider nay -> xoa ngoc

        }
        else if (other.gameObject.CompareTag("Ground")) // neu la dat

        {
            Debug.Log(" Cham dat");
            Destroy(gameObject);
        }

        
    }
}
