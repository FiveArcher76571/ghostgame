using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pathf = Pathfinding;
using RPGM.Gameplay;
using UnityEngine.EventSystems;

namespace RPGM.Gameplay
{

    public class ScareController : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject player;
        public Camera mainCam;
        public AudioSource scream;
        private float distance;
        public Sprite hidden;
        public Sprite hidden2;
        public Sprite notHidden;
        public float counter;
        public bool spooked;

        Vector3 stop;// = new Vector3(0, 0, 0);
        void Start()
        {
            stop = new Vector3(0, 0, 0);
            spooked = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (spooked)
            {
                GetComponent<pathf.AIPath>().enabled = true;
            }
            else
            {
                GetComponent<pathf.AIPath>().enabled = false;
            }
            distance = Vector3.Distance(transform.position, player.transform.position);
            if (Input.GetKeyDown(KeyCode.E) && !spooked)//&& !EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("EDown");
                //Vector2 mouseWorldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
                //RaycastHit2D hitCheck = Physics2D.Raycast(mouseWorldPos, Vector2.zero);
                if (distance < 1f)
                {
                    Debug.Log("Scare!");
                    scream.Play();
                    spooked = true;

                }

            }


        }

    }

}
