using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KillZVolume")]
	public partial class AKillZVolume : APhysicsVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KillZVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}