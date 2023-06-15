using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject character;

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("GameScene");
        StartCoroutine(RotateCharacter());
    }

    IEnumerator RotateCharacter()
    {
        float duration = 2f;
        float elapsedTime = 0f;

        Quaternion startRotation = character.transform.rotation;

        Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);

        while (elapsedTime < duration)
        {
            character.transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsedTime / duration);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        character.transform.rotation = endRotation;
    }
}