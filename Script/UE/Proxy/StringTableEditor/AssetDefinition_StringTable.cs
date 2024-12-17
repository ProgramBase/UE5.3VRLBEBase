using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.StringTableEditor
{
	[PathName("/Script/StringTableEditor.AssetDefinition_StringTable")]
	public partial class UAssetDefinition_StringTable : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StringTableEditor.AssetDefinition_StringTable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}