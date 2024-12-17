using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DefaultPhysicsVolume")]
	public partial class ADefaultPhysicsVolume : APhysicsVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DefaultPhysicsVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}