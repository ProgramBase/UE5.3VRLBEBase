using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerCameraController")]
	public partial class AVisualLoggerCameraController : ADebugCameraController, IStaticClass
	{
		public TWeakObjectPtr<AActor> PickedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PickedActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PickedActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.VisualLoggerCameraController");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PickedActor = 0;
	}
}