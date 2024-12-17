using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VisualLoggerDebugSnapshotInterface")]
	public partial class UVisualLoggerDebugSnapshotInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VisualLoggerDebugSnapshotInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.VisualLoggerDebugSnapshotInterface")]
	public interface IVisualLoggerDebugSnapshotInterface : IInterface
	{
	}
}