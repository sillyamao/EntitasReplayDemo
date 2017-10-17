//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly RecordComponent recordComponent = new RecordComponent();

    public bool isRecord {
        get { return HasComponent(GameComponentsLookup.Record); }
        set {
            if (value != isRecord) {
                if (value) {
                    AddComponent(GameComponentsLookup.Record, recordComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.Record);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherRecord;

    public static Entitas.IMatcher<GameEntity> Record {
        get {
            if (_matcherRecord == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Record);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRecord = matcher;
            }

            return _matcherRecord;
        }
    }
}
