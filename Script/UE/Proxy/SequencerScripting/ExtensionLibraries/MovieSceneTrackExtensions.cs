using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneTrackExtensions")]
	public partial class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneTrackExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="InName">
		/// The name for this track
		/// </param>
		/// <param name="RowIndex">
		/// The row index for the track
		/// </param>
		public static void SetTrackRowDisplayName(UMovieSceneTrack Track, FText InName, int RowIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = RowIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTrackRowDisplayName, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to get the sorting order from
		/// </param>
		/// <param name="SortingOrder">
		/// The sorting order to set
		/// </param>
		public static void SetSortingOrder(UMovieSceneTrack Track, int SortingOrder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SortingOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSortingOrder, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to set the section to key for
		/// </param>
		/// <param name="Section">
		/// The section to key for this track
		/// </param>
		public static void SetSectionToKey(UMovieSceneTrack Track, UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Section?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSectionToKey, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="InName">
		/// The name for this track
		/// </param>
		public static void SetDisplayName(UMovieSceneTrack Track, FText InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetDisplayName, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to set the color tint for
		/// </param>
		/// <param name="ColorTint">
		/// The color tint to set
		/// </param>
		public static void SetColorTint(UMovieSceneTrack Track, FColor ColorTint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ColorTint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetColorTint, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to remove the section from, if present
		/// </param>
		/// <param name="Section">
		/// The section to remove
		/// </param>
		public static void RemoveSection(UMovieSceneTrack Track, UMovieSceneSection Section)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Section?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSection, __InBuffer);
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <param name="RowIndex">
		/// The row index for the track
		/// </param>
		/// <returns>
		/// This track's display name
		/// </returns>
		public static FText GetTrackRowDisplayName(UMovieSceneTrack Track, int RowIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = RowIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTrackRowDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to get the sorting order from
		/// </param>
		/// <returns>
		/// The sorting order of the requested track
		/// </returns>
		public static int GetSortingOrder(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSortingOrder, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to get the section to key for
		/// </param>
		/// <returns>
		/// The section to key for the requested track
		/// </returns>
		public static UMovieSceneSection GetSectionToKey(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSectionToKey, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneSection*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// An array of this track's sections
		/// </returns>
		public static TArray<UMovieSceneSection> GetSections(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSections, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// This track's display name
		/// </returns>
		public static FText GetDisplayName(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to get the color tint from
		/// </param>
		/// <returns>
		/// The color tint of the requested track
		/// </returns>
		public static FColor GetColorTint(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetColorTint, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		/// <param name="Track">
		/// The track to use
		/// </param>
		/// <returns>
		/// The newly create section if successful
		/// </returns>
		public static UMovieSceneSection AddSection(UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSection, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneSection*)__ReturnBuffer;
			}
		}

		private static uint __SetTrackRowDisplayName = 0;

		private static uint __SetSortingOrder = 0;

		private static uint __SetSectionToKey = 0;

		private static uint __SetDisplayName = 0;

		private static uint __SetColorTint = 0;

		private static uint __RemoveSection = 0;

		private static uint __GetTrackRowDisplayName = 0;

		private static uint __GetSortingOrder = 0;

		private static uint __GetSectionToKey = 0;

		private static uint __GetSections = 0;

		private static uint __GetDisplayName = 0;

		private static uint __GetColorTint = 0;

		private static uint __AddSection = 0;
	}
}