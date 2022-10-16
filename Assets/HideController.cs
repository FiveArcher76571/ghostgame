using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;
using UnityEngine.EventSystems;

namespace RPGM.Gameplay { 

public class HideController : MonoBehaviour, IPointerClickHandler
    {
    // Start is called before the first frame update
        public GameObject player;
        public Camera mainCam;
        private float distance;
        public Sprite hidden;
        public Sprite hidden2;
        public Sprite notHidden;
        public float counter;

        Vector3 stop;// = new Vector3(0, 0, 0);
        void Start()
        {
            stop = new Vector3(0, 0, 0);
        }

    // Update is called once per frame
    void Update()
    {
            distance = Vector3.Distance(transform.position, player.transform.position);
            if (Input.GetMouseButton(0) )//&& !EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("MouseDown");
                //Vector2 mouseWorldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
                //RaycastHit2D hitCheck = Physics2D.Raycast(mouseWorldPos, Vector2.zero);
                    if (distance < 0.5f)
                    {

                        Debug.Log("Hiding");
                        if (GetComponent<SpriteRenderer>().sprite != hidden && GetComponent<SpriteRenderer>().sprite != hidden2)
                        {
                            player.GetComponent<SpriteRenderer>().enabled = false;
                            GetComponent<SpriteRenderer>().sprite = hidden;
                            player.GetComponent<Rigidbody2D>().drag = 1000;
                            player.GetComponent<CharacterController2D>().enabled = false;
                            player.GetComponent<CapsuleCollider2D>().enabled = false;
                    }

                        if (counter >= 1)
                    {
                        if (GetComponent<SpriteRenderer>().sprite = hidden)
                        {
                            GetComponent<SpriteRenderer>().sprite = hidden2;
                        }
                        if (GetComponent<SpriteRenderer>().sprite = hidden2)
                        {
                            GetComponent<SpriteRenderer>().sprite = hidden;
                        }
                        counter = 0;
                    }
                    counter += Time.deltaTime;
                }
            }
            else
            {
                if (distance < 0.5f)
                {
                    Debug.Log("Not Hiding");
                    player.GetComponent<SpriteRenderer>().enabled = true;
                    GetComponent<SpriteRenderer>().sprite = notHidden;
                    player.GetComponent<Rigidbody2D>().drag = 0;
                    player.GetComponent<CharacterController2D>().enabled = true;
                    player.GetComponent<CapsuleCollider2D>().enabled = true;
                }
            }

            if(distance >= 0.5f)
            {
                GetComponent<SpriteRenderer>().sprite = notHidden;
            }


            
    }
    


        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("clicked");
        }

    }
}
