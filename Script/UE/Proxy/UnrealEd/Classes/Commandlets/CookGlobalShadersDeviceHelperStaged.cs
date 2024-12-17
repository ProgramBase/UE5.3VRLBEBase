using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CookGlobalShadersDeviceHelperStaged")]
	public partial class UCookGlobalShadersDeviceHelperStaged : UCookGlobalShadersDeviceHelperBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CookGlobalShadersDeviceHelperStaged");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}