using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosDebugDrawComponent")]
	public partial class UChaosDebugDrawComponent : UActorComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosDebugDrawComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}