using Script.CoreUObject;
using Script.LevelSequence;
using Script.Engine;
using Script.Library;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.CacheTrackRecorder")]
	public partial class UCacheTrackRecorder : UObject, IStaticClass
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

		public FCacheRecorderParameters Parameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Parameters, __ReturnBuffer);

					return *(FCacheRecorderParameters*)__ReturnBuffer;
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

		public TArray<FCachedTrackSource> CacheTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheTracks, __ReturnBuffer);

					return *(TArray<FCachedTrackSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheTracks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CacheTrackRecorder.CacheTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual ECacheTrackRecorderState GetState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetState, __ReturnBuffer);

				return *(ECacheTrackRecorderState*)__ReturnBuffer;
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

		private static uint __SequenceAsset = 0;

		private static uint __WeakWorld = 0;

		private static uint __Parameters = 0;

		private static uint __CacheTracks = 0;

		private static uint __GetState = 0;

		private static uint __GetSequence = 0;
	}
}