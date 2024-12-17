using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothSharedSimConfigBase")]
	public partial class UDEPRECATED_ClothSharedSimConfigBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeInterface.ClothSharedSimConfigBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}