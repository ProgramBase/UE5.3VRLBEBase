using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithMDLSceneImportData")]
	public partial class UDatasmithMDLSceneImportData : UDatasmithSceneImportData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithMDLSceneImportData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}