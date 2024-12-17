using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CookGlobalShadersDeviceHelperBase")]
	public partial class UCookGlobalShadersDeviceHelperBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CookGlobalShadersDeviceHelperBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}