//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly RecordableComponent recordableComponent = new RecordableComponent();

    public bool isRecordable {
        get { return HasComponent(GameComponentsLookup.Recordable); }
        set {
            if (value != isRecordable) {
                if (value) {
                    AddComponent(GameComponentsLookup.Recordable, recordableComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.Recordable);
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

    static Entitas.IMatcher<GameEntity> _matcherRecordable;

    public static Entitas.IMatcher<GameEntity> Recordable {
        get {
            if (_matcherRecordable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Recordable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRecordable = matcher;
            }

            return _matcherRecordable;
        }
    }
}
