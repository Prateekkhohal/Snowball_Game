using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputScreen : MonoBehaviour
{

    public InputField nameInputField;
    public InputField ageInputField;
    public InputField genderInputField;

    public void OnSubmit()
    {
        string name = nameInputField.text;
        string age = ageInputField.text;
        string gender = genderInputField.text;

        Debug.Log("Name:" + name);
        Debug.Log("Age:" + age);
        Debug.Log("Gender:" + gender);

        SceneManager.LoadScene("StartingScene");
    }
}
