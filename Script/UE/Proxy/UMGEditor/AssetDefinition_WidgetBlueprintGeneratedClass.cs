using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.AssetDefinition_WidgetBlueprintGeneratedClass")]
	public partial class UAssetDefinition_WidgetBlueprintGeneratedClass : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.AssetDefinition_WidgetBlueprintGeneratedClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}