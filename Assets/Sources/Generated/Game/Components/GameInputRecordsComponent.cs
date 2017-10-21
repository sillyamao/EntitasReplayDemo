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
