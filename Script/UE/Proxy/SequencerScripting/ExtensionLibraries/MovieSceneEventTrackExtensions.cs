using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneEventTrackExtensions")]
	public partial class UMovieSceneEventTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneEventTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EventKey">
		/// The event key to get the bound object property from
		/// </param>
		/// <returns>
		/// The class of the bound object property
		/// </returns>
		public static UClass GetBoundObjectPropertyClass(FMovieSceneEvent EventKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBoundObjectPropertyClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The event track to add the new event trigger section to
		/// </param>
		/// <returns>
		/// The newly created event trigger section
		/// </returns>
		public static UMovieSceneEventTriggerSection AddEventTriggerSection(UMovieSceneEventTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddEventTriggerSection, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneEventTriggerSection*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The event track to add the new event repeater section to
		/// </param>
		/// <returns>
		/// The newly created event repeater section
		/// </returns>
		public static UMovieSceneEventRepeaterSection AddEventRepeaterSection(UMovieSceneEventTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddEventRepeaterSection, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneEventRepeaterSection*)__ReturnBuffer;
			}
		}

		private static uint __GetBoundObjectPropertyClass = 0;

		private static uint __AddEventTriggerSection = 0;

		private static uint __AddEventRepeaterSection = 0;
	}
}