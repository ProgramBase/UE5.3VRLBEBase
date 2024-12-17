using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSkeletonFactory")]
	public partial class UInterchangeSkeletonFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSkeletonFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}