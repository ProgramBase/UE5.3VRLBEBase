using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorderOverlayWidget")]
	public partial class UTakeRecorderOverlayWidget : UUserWidget, IStaticClass
	{
		public UTakeRecorder Recorder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Recorder, __ReturnBuffer);

					return *(UTakeRecorder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Recorder, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorder.TakeRecorderOverlayWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Recorder = 0;
	}
}