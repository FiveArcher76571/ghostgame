using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace RPGM.Gameplay
{
    public class Win : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject kid;
        public Collider2D playerCol;
        public GameObject musicThing;
        public AudioClip puzzle;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision == playerCol)
            {
                if (kid.GetComponent<ScareController>().spooked)
                        {
                    SceneManager.LoadScene("Win!", LoadSceneMode.Single); 
                }
                else
                {
                    musicThing.GetComponent<AudioSource>().clip = puzzle;
                    musicThing.GetComponent<AudioSource>().Play();
                }
                
            }
            
        }
    }
}
