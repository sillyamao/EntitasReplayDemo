using System.Collections.Generic;
using System.Linq;
using Entitas;

public class PlayerInitializeSystem : IInitializeSystem
{
    private Contexts _contexts;

    public PlayerInitializeSystem(Contexts _contexts)
    {
        this._contexts = _contexts;
    }

    public void Initialize()
    {
        var entities = _contexts.game.GetEntitiesWithPlayer(true);

        GameEntity player;
        if (entities.Count == 0)
        {
            player = _contexts.game.CreateEntity();
            player.AddPlayer(true);
            player.AddID(0);
            player.isMovable = true;
            player.AddInputRecords(new List<InputRecordData>());
            player.AddPositionRecords(new List<PositionRecordData>());
            player.isRecordable = true;
        }
        else
        {
            player = entities.First();
        }

        player.ReplacePosition(new Position(0, 0));
        player.ReplaceSpeed(_contexts.game.playerInitData.value.Speed);
    }
}
