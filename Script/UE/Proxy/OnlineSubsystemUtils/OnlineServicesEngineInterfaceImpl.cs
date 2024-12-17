using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.OnlineServicesEngineInterfaceImpl")]
	public partial class UOnlineServicesEngineInterfaceImpl : UOnlineEngineInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.OnlineServicesEngineInterfaceImpl");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}