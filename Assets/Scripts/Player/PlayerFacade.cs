using UnityEngine;
using Zenject;

public class PlayerFacade: MonoBehaviour
{
    [SerializeField] private PlayerHealth health;
    public PlayerHealth PlayerHealth => health;

    private IPlayerService playerService;

    [Inject]
    public void Construct(IPlayerService _playerService)
    {
        playerService = _playerService;
        playerService.Register(this);
    }
}