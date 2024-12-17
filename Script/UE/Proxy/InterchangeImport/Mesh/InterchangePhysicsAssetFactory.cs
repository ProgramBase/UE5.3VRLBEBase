using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangePhysicsAssetFactory")]
	public partial class UInterchangePhysicsAssetFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangePhysicsAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}