using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetworkPhysicsSystem")]
	public partial class UNetworkPhysicsSystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NetworkPhysicsSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}