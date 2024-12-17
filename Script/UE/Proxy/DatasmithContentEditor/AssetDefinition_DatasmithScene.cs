using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.DatasmithContentEditor
{
	[PathName("/Script/DatasmithContentEditor.AssetDefinition_DatasmithScene")]
	public partial class UAssetDefinition_DatasmithScene : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContentEditor.AssetDefinition_DatasmithScene");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}