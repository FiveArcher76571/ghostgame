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
                        player.GetComponent<SpriteRenderer>().enabled = false;
                        player.GetComponent<Rigidbody2D>().drag = 1000;
                        player.GetComponent<CharacterController2D>().enabled = false;
                    }
            }
            else
            {
                if (distance < 0.5f)
                {
                    Debug.Log("Not Hiding");
                    player.GetComponent<SpriteRenderer>().enabled = true;
                    player.GetComponent<Rigidbody2D>().drag = 0;
                    player.GetComponent<CharacterController2D>().enabled = true;
                }
            }
    }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("clicked");
        }

    }
}
