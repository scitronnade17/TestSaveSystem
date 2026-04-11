using Zenject;

public class BootSystemInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<SaveLoadInitSystem>().AsSingle();
        Container.BindInterfacesAndSelfTo<BootInitializeSystem>().AsSingle().NonLazy();
    }
}
