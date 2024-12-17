using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions")]
	public partial class UMovieSceneFloatVectorTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Track">
		/// The track to set
		/// </param>
		/// <param name="InNumChannelsUsed">
		/// The number of channels to use for this track
		/// </param>
		public static void SetNumChannelsUsed(UMovieSceneFloatVectorTrack Track, int InNumChannelsUsed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InNumChannelsUsed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNumChannelsUsed, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to query for the number of channels used
		/// </param>
		/// <returns>
		/// The number of channels used for this track
		/// </returns>
		public static int GetNumChannelsUsed(UMovieSceneFloatVectorTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumChannelsUsed, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetNumChannelsUsed = 0;

		private static uint __GetNumChannelsUsed = 0;
	}
}