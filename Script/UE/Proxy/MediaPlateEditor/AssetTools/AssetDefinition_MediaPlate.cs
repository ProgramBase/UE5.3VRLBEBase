using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MediaPlateEditor
{
	[PathName("/Script/MediaPlateEditor.AssetDefinition_MediaPlate")]
	public partial class UAssetDefinition_MediaPlate : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlateEditor.AssetDefinition_MediaPlate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}