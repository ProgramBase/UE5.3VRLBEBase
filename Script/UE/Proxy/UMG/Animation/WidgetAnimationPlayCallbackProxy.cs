using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetAnimationPlayCallbackProxy")]
	public partial class UWidgetAnimationPlayCallbackProxy : UObject, IStaticClass
	{
		public FWidgetAnimationResult Finished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Finished, __ReturnBuffer);

					return *(FWidgetAnimationResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Finished, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetAnimationPlayCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationTimeRangeProxyObject(ref UUMGSequencePlayer Result, UUserWidget Widget, UWidgetAnimation InAnimation, float StartAtTime = 0.000000f, float EndAtTime = 0.000000f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = Result?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = StartAtTime;

				*(float*)(__InBuffer + 28) = EndAtTime;

				*(int*)(__InBuffer + 32) = NumLoopsToPlay;

				*(byte*)(__InBuffer + 36) = (byte)PlayMode;

				*(float*)(__InBuffer + 37) = PlaybackSpeed;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CreatePlayAnimationTimeRangeProxyObject, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(UUMGSequencePlayer*)(__OutBuffer);

				return *(UWidgetAnimationPlayCallbackProxy*)__ReturnBuffer;
			}
		}

		public static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationProxyObject(ref UUMGSequencePlayer Result, UUserWidget Widget, UWidgetAnimation InAnimation, float StartAtTime = 0.000000f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = Result?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = StartAtTime;

				*(int*)(__InBuffer + 28) = NumLoopsToPlay;

				*(byte*)(__InBuffer + 32) = (byte)PlayMode;

				*(float*)(__InBuffer + 33) = PlaybackSpeed;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CreatePlayAnimationProxyObject, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(UUMGSequencePlayer*)(__OutBuffer);

				return *(UWidgetAnimationPlayCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __Finished = 0;

		private static uint __CreatePlayAnimationTimeRangeProxyObject = 0;

		private static uint __CreatePlayAnimationProxyObject = 0;
	}
}