public class LoadLevelState : IPayloadedState<int>
{
    private readonly ISceneLoader sceneLoader;
    private readonly ILoadingCurtain curtain;

    public LoadLevelState(ISceneLoader _sceneLoader,
      ILoadingCurtain _curtain)
    {
        sceneLoader = _sceneLoader;
        curtain = _curtain;
    }

    public void Enter(int sceneIndex)
    {
        sceneLoader.LoadScene(sceneIndex);
        curtain.Hide();
    }

    public void Exit() { }
}