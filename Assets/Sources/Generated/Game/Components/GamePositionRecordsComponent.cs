//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PositionRecordsComponent positionRecords { get { return (PositionRecordsComponent)GetComponent(GameComponentsLookup.PositionRecords); } }
    public bool hasPositionRecords { get { return HasComponent(GameComponentsLookup.PositionRecords); } }

    public void AddPositionRecords(System.Collections.Generic.List<PositionRecordData> newValue) {
        var index = GameComponentsLookup.PositionRecords;
        var component = CreateComponent<PositionRecordsComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePositionRecords(System.Collections.Generic.List<PositionRecordData> newValue) {
        var index = GameComponentsLookup.PositionRecords;
        var component = CreateComponent<PositionRecordsComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePositionRecords() {
        RemoveComponent(GameComponentsLookup.PositionRecords);
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

    static Entitas.IMatcher<GameEntity> _matcherPositionRecords;

    public static Entitas.IMatcher<GameEntity> PositionRecords {
        get {
            if (_matcherPositionRecords == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PositionRecords);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPositionRecords = matcher;
            }

            return _matcherPositionRecords;
        }
    }
}
