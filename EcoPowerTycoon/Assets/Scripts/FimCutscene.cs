using UnityEngine;
using UnityEngine.SceneManagement;

public class FimCutscene : MonoBehaviour
{
    [SerializeField] private CarregarCena carregarCena;
    void OnEnable()
    {
        carregarCena.CarregarTutorial();
    }
}
