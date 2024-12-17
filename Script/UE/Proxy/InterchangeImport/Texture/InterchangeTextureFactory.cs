using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeTextureFactory")]
	public partial class UInterchangeTextureFactory : UInterchangeFactoryBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeTextureFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}