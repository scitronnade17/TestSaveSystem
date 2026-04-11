using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField] private LoadingCurtain loadingCurtainPrefab;
    public override void InstallBindings()
    {
        Container.Bind<IDIService>().To<DIService>().AsSingle();
        Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();

        Container.Bind<ILoadingCurtain>()
            .FromComponentInNewPrefab(loadingCurtainPrefab)
            .AsSingle()
            .NonLazy();

        BindGameStateMachine();
        BindSaveLoadService();
    }

    private void BindSaveLoadService()
    {
        Container.Bind<IProgressService>().To<ProgressService>().AsSingle();
        Container.Bind<ISaveLoadRegistry>().To<SaveLoadRegistry>().AsSingle();
        Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerService>().AsSingle();
    }

    private void BindGameStateMachine()
    {
        Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
        Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
        Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
        Container.BindInterfacesAndSelfTo<LoadLevelState>().AsSingle();
    }
}