using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    [SerializeField]
    // Kiểm tra xem người chơi có ở gần hay không
    public bool isPlayerNear = false; 
    
    void OnTriggerEnter (Collider other){
        if(other.CompareTag("Player")){
            // Người chơi đã vào vùng va chạm
            isPlayerNear = true;
            Debug.Log("Player entered NPC area");
            //Hiển trị chữ 'F' ( tạo UI theo nhu cầu, ví dụ như dùng Unity UI)
            //ShowInteractUI(true);
        }
    }

    void OnTriggerExit(Collider other){
        if(other.CompareTag ("Player")){
            // Người chơi đã rời khỏi vùng va chạm
            isPlayerNear = false;
            Debug.Log("Player exited NPC area");

            // Ẩn chữ 'F'
            //ShowInteractUI(false);
        }
    }

    void Update(){
        if(isPlayerNear && Input.GetKeyDown(KeyCode.F)){
            Debug.Log("Ban da nhan F");
        }
    }

    // private void ShowInteractUI(bool show){
        
    // }

}
