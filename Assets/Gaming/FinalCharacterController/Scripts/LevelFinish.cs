using Gaming.FinalCharacterController;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    [SerializeField] GameObject PlayerController;
    [SerializeField] AudioSource levelJingle;
    [SerializeField] GameObject levelBGM;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController.GetComponent<PlayerController>().enabled = false;
            PlayerController.GetComponent<Animator>().Play("Idle");

            levelBGM.SetActive(false);
            levelJingle.Play();
            fadeOut.SetActive(true);

            Invoke(nameof(NextLevel), 3f); // wait before loading next scene
        }
    }

    void NextLevel()
    {
        SceneController.instance.NextLevel();
    }
}