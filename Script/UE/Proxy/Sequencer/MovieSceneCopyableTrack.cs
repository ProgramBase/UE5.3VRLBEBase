using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieSceneCopyableTrack")]
	public partial class UMovieSceneCopyableTrack : UObject, IStaticClass
	{
		public UMovieSceneTrack Track
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Track, __ReturnBuffer);

					return *(UMovieSceneTrack*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Track, __InBuffer);
				}
			}
		}

		public bool bIsRootTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRootTrack, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRootTrack, __InBuffer);
				}
			}
		}

		public bool bIsCameraCutTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCameraCutTrack, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCameraCutTrack, __InBuffer);
				}
			}
		}

		public TArray<FName> FolderPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FolderPath, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FolderPath, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.MovieSceneCopyableTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Track = 0;

		private static uint __bIsRootTrack = 0;

		private static uint __bIsCameraCutTrack = 0;

		private static uint __FolderPath = 0;
	}
}