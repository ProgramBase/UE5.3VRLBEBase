using Script.CoreUObject;
using Script.TakesCore;
using Script.ChaosCaching;
using Script.Library;

namespace Script.ChaosCachingEditor
{
	[PathName("/Script/ChaosCachingEditor.TakeRecorderChaosCacheSource")]
	public partial class UTakeRecorderChaosCacheSource : UTakeRecorderSource, IStaticClass
	{
		public TSoftObjectPtr<AChaosCacheManager> ChaosCacheManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosCacheManager, __ReturnBuffer);

					return *(TSoftObjectPtr<AChaosCacheManager>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosCacheManager, __InBuffer);
				}
			}
		}

		public UMovieSceneChaosCacheTrackRecorder TrackRecorder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackRecorder, __ReturnBuffer);

					return *(UMovieSceneChaosCacheTrackRecorder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackRecorder, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCachingEditor.TakeRecorderChaosCacheSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChaosCacheManager = 0;

		private static uint __TrackRecorder = 0;
	}
}