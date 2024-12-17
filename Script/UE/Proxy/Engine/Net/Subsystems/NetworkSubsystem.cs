using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetworkSubsystem")]
	public partial class UNetworkSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetworkSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}