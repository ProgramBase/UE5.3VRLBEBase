using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface")]
	public partial class UChaosNotifyHandlerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface")]
	public interface IChaosNotifyHandlerInterface : IInterface
	{
	}
}