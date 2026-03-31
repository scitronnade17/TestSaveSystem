using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IDIService>().To<DIService>().AsSingle();


        BindSaveLoadService();
    }

    private void BindSaveLoadService()
    {
        Container.Bind<IProgressService>().To<ProgressService>().AsSingle();
        Container.Bind<ISaveLoadRegistry>().To<SaveLoadRegistry>().AsSingle();
        Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerService>().AsSingle();
    }
}