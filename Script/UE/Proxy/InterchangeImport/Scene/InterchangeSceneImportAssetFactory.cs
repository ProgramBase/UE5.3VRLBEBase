using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSceneImportAssetFactory")]
	public partial class UInterchangeSceneImportAssetFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSceneImportAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}