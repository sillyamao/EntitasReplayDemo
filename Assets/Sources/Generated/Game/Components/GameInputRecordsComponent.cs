//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity inputRecordsEntity { get { return GetGroup(GameMatcher.InputRecords).GetSingleEntity(); } }
    public InputRecordsComponent inputRecords { get { return inputRecordsEntity.inputRecords; } }
    public bool hasInputRecords { get { return inputRecordsEntity != null; } }

    public GameEntity SetInputRecords(System.Collections.Generic.List<InputRecordData> newValue) {
        if (hasInputRecords) {
            throw new Entitas.EntitasException("Could not set InputRecords!\n" + this + " already has an entity with InputRecordsComponent!",
                "You should check if the context already has a inputRecordsEntity before setting it or use context.ReplaceInputRecords().");
        }
        var entity = CreateEntity();
        entity.AddInputRecords(newValue);
        return entity;
    }

    public void ReplaceInputRecords(System.Collections.Generic.List<InputRecordData> newValue) {
        var entity = inputRecordsEntity;
        if (entity == null) {
            entity = SetInputRecords(newValue);
        } else {
            entity.ReplaceInputRecords(newValue);
        }
    }

    public void RemoveInputRecords() {
        inputRecordsEntity.Destroy();
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

    public InputRecordsComponent inputRecords { get { return (InputRecordsComponent)GetComponent(GameComponentsLookup.InputRecords); } }
    public bool hasInputRecords { get { return HasComponent(GameComponentsLookup.InputRecords); } }

    public void AddInputRecords(System.Collections.Generic.List<InputRecordData> newValue) {
        var index = GameComponentsLookup.InputRecords;
        var component = CreateComponent<InputRecordsComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInputRecords(System.Collections.Generic.List<InputRecordData> newValue) {
        var index = GameComponentsLookup.InputRecords;
        var component = CreateComponent<InputRecordsComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInputRecords() {
        RemoveComponent(GameComponentsLookup.InputRecords);
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

    static Entitas.IMatcher<GameEntity> _matcherInputRecords;

    public static Entitas.IMatcher<GameEntity> InputRecords {
        get {
            if (_matcherInputRecords == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InputRecords);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInputRecords = matcher;
            }

            return _matcherInputRecords;
        }
    }
}