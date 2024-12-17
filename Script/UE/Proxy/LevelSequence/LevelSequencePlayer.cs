using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;
using Script.Engine;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequencePlayer")]
	public partial class ULevelSequencePlayer : UMovieSceneSequencePlayer, IStaticClass
	{
		public FOnLevelSequencePlayerCameraCutEvent OnCameraCut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCameraCut, __ReturnBuffer);

					return *(FOnLevelSequencePlayerCameraCutEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCameraCut, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequencePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UCameraComponent GetActiveCameraComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveCameraComponent, __ReturnBuffer);

				return *(UCameraComponent*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContextObject">
		/// Context object from which to retrieve a UWorld.
		/// </param>
		/// <param name="LevelSequence">
		/// The level sequence to play.
		/// </param>
		/// <param name="Settings">
		/// The desired playback settings
		/// </param>
		/// <param name="OutActor">
		/// The level sequence actor created to play this sequence.
		/// </param>
		public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, ref ALevelSequenceActor OutActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CreateLevelSequencePlayer, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActor = *(ALevelSequenceActor*)(__OutBuffer);

				return *(ULevelSequencePlayer*)__ReturnBuffer;
			}
		}

		private static uint __OnCameraCut = 0;

		private static uint __GetActiveCameraComponent = 0;

		private static uint __CreateLevelSequencePlayer = 0;
	}
}