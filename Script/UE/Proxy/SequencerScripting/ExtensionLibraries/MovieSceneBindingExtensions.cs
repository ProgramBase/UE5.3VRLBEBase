using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneBindingExtensions")]
	public partial class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneBindingExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InBinding">
		/// The binding to set
		/// </param>
		/// <param name="SpawnableBindingID">
		/// The spawnable's binding id
		/// </param>
		public static void SetSpawnableBindingID(FMovieSceneBindingProxy InBinding, FMovieSceneObjectBindingID SpawnableBindingID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnableBindingID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSpawnableBindingID, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to get the sorting order from
		/// </param>
		/// <param name="SortingOrder">
		/// The sorting order to set
		/// </param>
		public static void SetSortingOrder(FMovieSceneBindingProxy InBinding, int SortingOrder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SortingOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSortingOrder, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to set 
		/// </param>
		/// <param name="InParentBinding">
		/// The parent to set the InBinding to
		/// </param>
		public static void SetParent(FMovieSceneBindingProxy InBinding, FMovieSceneBindingProxy InParentBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetParent, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to get the name of
		/// </param>
		/// <param name="InName">
		/// The name of the binding
		/// </param>
		public static void SetName(FMovieSceneBindingProxy InBinding, FString InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetName, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to get the name of
		/// </param>
		/// <param name="InName">
		/// The display name of the binding
		/// </param>
		public static void SetDisplayName(FMovieSceneBindingProxy InBinding, FText InDisplayName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDisplayName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetDisplayName, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to remove the track from
		/// </param>
		/// <param name="TrackToRemove">
		/// The track to remove
		/// </param>
		public static void RemoveTrack(FMovieSceneBindingProxy InBinding, UMovieSceneTrack TrackToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackToRemove?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveTrack, __InBuffer);
			}
		}

		/// <param name="InBinding">
		/// The binding to remove the track from
		/// </param>
		public static void Remove(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Remove, __InBuffer);
			}
		}

		/// <param name="SourceBindingId">
		/// The identifier of the binding ID to move all tracks and children from
		/// </param>
		/// <param name="DestinationBindingId">
		/// The identifier of the binding ID to move the contents to	 
		/// </param>
		public static void MoveBindingContents(FMovieSceneBindingProxy SourceBindingId, FMovieSceneBindingProxy DestinationBindingId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceBindingId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationBindingId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __MoveBindingContents, __InBuffer);
			}
		}

		public static bool IsValid(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to find tracks in
		/// </param>
		/// <returns>
		/// An array containing all the binding's tracks
		/// </returns>
		public static TArray<UMovieSceneTrack> GetTracks(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTracks, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the sorting order from
		/// </param>
		/// <returns>
		/// The sorting order of the requested binding
		/// </returns>
		public static int GetSortingOrder(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSortingOrder, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the possessed object class of
		/// </param>
		/// <returns>
		/// The possessed object class of the binding
		/// </returns>
		public static UClass GetPossessedObjectClass(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPossessedObjectClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the parent of
		/// </param>
		/// <returns>
		/// The binding's parent
		/// </returns>
		public static FMovieSceneBindingProxy GetParent(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetParent, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the object template of
		/// </param>
		/// <returns>
		/// The object template of the binding
		/// </returns>
		public static UObject GetObjectTemplate(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectTemplate, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the name of
		/// </param>
		/// <returns>
		/// The name of the binding
		/// </returns>
		public static FString GetName(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the ID of
		/// </param>
		/// <returns>
		/// The guid that uniquely represents this binding
		/// </returns>
		public static FGuid GetId(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetId, __InBuffer, __ReturnBuffer);

				return *(FGuid*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to get the name of
		/// </param>
		/// <returns>
		/// The display name of the binding
		/// </returns>
		public static FText GetDisplayName(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to to get children of
		/// </param>
		/// <returns>
		/// An array containing all the binding's children
		/// </returns>
		public static TArray<FMovieSceneBindingProxy> GetChildPossessables(FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChildPossessables, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to find tracks in
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type specifying which types of track to return
		/// </param>
		/// <returns>
		/// An array containing any tracks that match the type specified
		/// </returns>
		public static TArray<UMovieSceneTrack> FindTracksByType(FMovieSceneBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTracksByType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to find tracks in
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type specifying the exact types of track to return
		/// </param>
		/// <returns>
		/// An array containing any tracks that are exactly the same as the type specified
		/// </returns>
		public static TArray<UMovieSceneTrack> FindTracksByExactType(FMovieSceneBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTracksByExactType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="InBinding">
		/// The binding to add tracks to
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type specifying the type of track to create
		/// </param>
		/// <returns>
		/// The newly created track, if successful
		/// </returns>
		public static UMovieSceneTrack AddTrack(FMovieSceneBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddTrack, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneTrack*)__ReturnBuffer;
			}
		}

		private static uint __SetSpawnableBindingID = 0;

		private static uint __SetSortingOrder = 0;

		private static uint __SetParent = 0;

		private static uint __SetName = 0;

		private static uint __SetDisplayName = 0;

		private static uint __RemoveTrack = 0;

		private static uint __Remove = 0;

		private static uint __MoveBindingContents = 0;

		private static uint __IsValid = 0;

		private static uint __GetTracks = 0;

		private static uint __GetSortingOrder = 0;

		private static uint __GetPossessedObjectClass = 0;

		private static uint __GetParent = 0;

		private static uint __GetObjectTemplate = 0;

		private static uint __GetName = 0;

		private static uint __GetId = 0;

		private static uint __GetDisplayName = 0;

		private static uint __GetChildPossessables = 0;

		private static uint __FindTracksByType = 0;

		private static uint __FindTracksByExactType = 0;

		private static uint __AddTrack = 0;
	}
}