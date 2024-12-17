using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosEventListenerComponent")]
	public partial class UChaosEventListenerComponent : UActorComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosEventListenerComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}