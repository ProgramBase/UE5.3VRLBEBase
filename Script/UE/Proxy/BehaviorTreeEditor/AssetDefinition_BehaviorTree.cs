using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.AssetDefinition_BehaviorTree")]
	public partial class UAssetDefinition_BehaviorTree : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.AssetDefinition_BehaviorTree");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}