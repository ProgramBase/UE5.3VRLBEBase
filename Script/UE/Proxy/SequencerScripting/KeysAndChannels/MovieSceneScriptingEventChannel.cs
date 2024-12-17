using Script.CoreUObject;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingEventChannel")]
	public partial class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingEventChannel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RemoveKey(UMovieSceneScriptingKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveKey, __InBuffer);
			}
		}

		/// <returns>
		/// An array of UMovieSceneScriptingEventKey's contained by this channel.
		/// Returns all keys even if clipped by the owning section's boundaries or outside of the current sequence play range.
		/// </returns>
		public virtual TArray<UMovieSceneScriptingKey> GetKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetKeys, __ReturnBuffer);

				return *(TArray<UMovieSceneScriptingKey>*)__ReturnBuffer;
			}
		}

		/// <param name="InTime">
		/// The frame this key should go on. Respects TimeUnit to determine if it is a display rate frame or a tick resolution frame.
		/// </param>
		/// <param name="NewValue">
		/// The value that this key should be created with.
		/// </param>
		/// <param name="SubFrame">
		/// Optional [0-1) clamped sub-frame to put this key on. Ignored if TimeUnit is set to Tick Resolution.
		/// </param>
		/// <param name="TimeUnit">
		/// Is the specified InTime in Display Rate frames or Tick Resolution.
		/// </param>
		/// <returns>
		/// The key that was created with the specified values at the specified time.
		/// </returns>
		public virtual UMovieSceneScriptingEventKey AddKey(FFrameNumber InTime, FMovieSceneEvent NewValue, float SubFrame = 0.000000f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SubFrame;

				*(byte*)(__InBuffer + 20) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddKey, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneScriptingEventKey*)__ReturnBuffer;
			}
		}

		private static uint __RemoveKey = 0;

		private static uint __GetKeys = 0;

		private static uint __AddKey = 0;
	}
}