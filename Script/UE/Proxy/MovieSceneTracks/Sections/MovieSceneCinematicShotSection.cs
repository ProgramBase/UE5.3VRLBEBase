using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCinematicShotSection")]
	public partial class UMovieSceneCinematicShotSection : UMovieSceneSubSection, IStaticClass
	{
		public FString ShotDisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShotDisplayName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShotDisplayName, __InBuffer);
				}
			}
		}

		public float ThumbnailReferenceOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailReferenceOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailReferenceOffset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCinematicShotSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetShotDisplayName(FString InShotDisplayName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShotDisplayName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShotDisplayName, __InBuffer);
			}
		}

		/// <returns>
		/// The shot display name. if empty, returns the sequence's name*/
		/// </returns>
		public virtual FString GetShotDisplayName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetShotDisplayName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __ShotDisplayName = 0;

		private static uint __ThumbnailReferenceOffset = 0;

		private static uint __SetShotDisplayName = 0;

		private static uint __GetShotDisplayName = 0;
	}
}