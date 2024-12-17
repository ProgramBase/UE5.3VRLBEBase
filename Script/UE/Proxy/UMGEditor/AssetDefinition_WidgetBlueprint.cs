using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.AssetDefinition_WidgetBlueprint")]
	public partial class UAssetDefinition_WidgetBlueprint : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.AssetDefinition_WidgetBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}