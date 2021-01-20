using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class InputStart : MonoBehaviour {

    AudioSource startSound;

    public GameObject gameObject_Animation;
    Animator anim;
    //public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);


    // Use this for initialization
    void Start()
    {
       startSound = GetComponent<AudioSource>();

       anim = gameObject_Animation.GetComponent<Animator>();

    }

    private void Update() {
        if (OVRInput.GetDown(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.Space))

        {
            //Debug.Log("jksjkd");
            anim.SetBool("FadeOut", true);
            startSound.Play(0);
           
            StartCoroutine(LoadYourAsyncScene());
            
        }
    }

        IEnumerator LoadYourAsyncScene()
        {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.
        yield return new WaitForSeconds(10.0f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone)
            {
            yield return null;
            
        }
        }
    }

    

