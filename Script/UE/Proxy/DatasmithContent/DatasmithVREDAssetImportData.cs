using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithVREDAssetImportData")]
	public partial class UDatasmithVREDAssetImportData : UDatasmithAssetImportData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithVREDAssetImportData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}