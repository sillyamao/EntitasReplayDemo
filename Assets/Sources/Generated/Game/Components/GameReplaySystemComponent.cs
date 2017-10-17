//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity replaySystemEntity { get { return GetGroup(GameMatcher.ReplaySystem).GetSingleEntity(); } }
    public ReplaySystemComponent replaySystem { get { return replaySystemEntity.replaySystem; } }
    public bool hasReplaySystem { get { return replaySystemEntity != null; } }

    public GameEntity SetReplaySystem(Entitas.Systems newValue) {
        if (hasReplaySystem) {
            throw new Entitas.EntitasException("Could not set ReplaySystem!\n" + this + " already has an entity with ReplaySystemComponent!",
                "You should check if the context already has a replaySystemEntity before setting it or use context.ReplaceReplaySystem().");
        }
        var entity = CreateEntity();
        entity.AddReplaySystem(newValue);
        return entity;
    }

    public void ReplaceReplaySystem(Entitas.Systems newValue) {
        var entity = replaySystemEntity;
        if (entity == null) {
            entity = SetReplaySystem(newValue);
        } else {
            entity.ReplaceReplaySystem(newValue);
        }
    }

    public void RemoveReplaySystem() {
        replaySystemEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ReplaySystemComponent replaySystem { get { return (ReplaySystemComponent)GetComponent(GameComponentsLookup.ReplaySystem); } }
    public bool hasReplaySystem { get { return HasComponent(GameComponentsLookup.ReplaySystem); } }

    public void AddReplaySystem(Entitas.Systems newValue) {
        var index = GameComponentsLookup.ReplaySystem;
        var component = CreateComponent<ReplaySystemComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceReplaySystem(Entitas.Systems newValue) {
        var index = GameComponentsLookup.ReplaySystem;
        var component = CreateComponent<ReplaySystemComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveReplaySystem() {
        RemoveComponent(GameComponentsLookup.ReplaySystem);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherReplaySystem;

    public static Entitas.IMatcher<GameEntity> ReplaySystem {
        get {
            if (_matcherReplaySystem == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ReplaySystem);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherReplaySystem = matcher;
            }

            return _matcherReplaySystem;
        }
    }
}
