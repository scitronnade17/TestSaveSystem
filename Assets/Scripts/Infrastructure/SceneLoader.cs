using UnityEngine.SceneManagement;

public interface ISceneLoader
{
    void LoadScene(int sceneIndex);
}

public class SceneLoader : ISceneLoader
{
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}