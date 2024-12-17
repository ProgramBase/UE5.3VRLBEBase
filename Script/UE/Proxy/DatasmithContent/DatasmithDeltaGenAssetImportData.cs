using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithDeltaGenAssetImportData")]
	public partial class UDatasmithDeltaGenAssetImportData : UDatasmithAssetImportData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithDeltaGenAssetImportData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}