using Script.CoreUObject;
using Script.LevelSequence;
using Script.Engine;
using Script.Library;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorder")]
	public partial class UTakeRecorder : UObject, IStaticClass
	{
		public ULevelSequence SequenceAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceAsset, __ReturnBuffer);

					return *(ULevelSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceAsset, __InBuffer);
				}
			}
		}

		public UTakeRecorderOverlayWidget OverlayWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayWidget, __ReturnBuffer);

					return *(UTakeRecorderOverlayWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayWidget, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UWorld> WeakWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeakWorld, __ReturnBuffer);

					return *(TWeakObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeakWorld, __InBuffer);
				}
			}
		}

		public FTakeRecorderParameters Parameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parameters, __ReturnBuffer);

					return *(FTakeRecorderParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Parameters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorder.TakeRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ETakeRecorderState GetState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetState, __ReturnBuffer);

				return *(ETakeRecorderState*)__ReturnBuffer;
			}
		}

		public virtual ULevelSequence GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		public virtual float GetCountdownSeconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCountdownSeconds, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SequenceAsset = 0;

		private static uint __OverlayWidget = 0;

		private static uint __WeakWorld = 0;

		private static uint __Parameters = 0;

		private static uint __GetState = 0;

		private static uint __GetSequence = 0;

		private static uint __GetCountdownSeconds = 0;
	}
}