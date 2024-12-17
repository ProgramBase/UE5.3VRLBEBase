using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneSequenceExtensions")]
	public partial class UMovieSceneSequenceExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneSequenceExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SortMarkedFrames(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SortMarkedFrames, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the work range start
		/// </param>
		/// <param name="StartTimeInSeconds">
		/// The desired work range start time in seconds for this sequence
		/// </param>
		public static void SetWorkRangeStart(UMovieSceneSequence InSequence, float StartTimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTimeInSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWorkRangeStart, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the work range end
		/// </param>
		/// <param name="StartTimeInSeconds">
		/// The desired work range end time in seconds for this sequence
		/// </param>
		public static void SetWorkRangeEnd(UMovieSceneSequence InSequence, float EndTimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EndTimeInSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWorkRangeEnd, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the view range start
		/// </param>
		/// <param name="StartTimeInSeconds">
		/// The desired view range start time in seconds for this sequence
		/// </param>
		public static void SetViewRangeStart(UMovieSceneSequence InSequence, float StartTimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTimeInSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetViewRangeStart, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the view range end
		/// </param>
		/// <param name="StartTimeInSeconds">
		/// The desired view range end time in seconds for this sequence
		/// </param>
		public static void SetViewRangeEnd(UMovieSceneSequence InSequence, float EndTimeInSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EndTimeInSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetViewRangeEnd, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="TickResolution">
		/// The tick resolution of the sequence, defining the smallest unit of time representable on this sequence
		/// </param>
		public static void SetTickResolutionDirectly(UMovieSceneSequence Sequence, FFrameRate TickResolution)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TickResolution?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTickResolutionDirectly, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="TickResolution">
		/// The tick resolution of the sequence, defining the smallest unit of time representable on this sequence
		/// </param>
		public static void SetTickResolution(UMovieSceneSequence Sequence, FFrameRate TickResolution)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TickResolution?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTickResolution, __InBuffer);
			}
		}

		/// <bInReadOnly>
		/// Whether the movie scene should be read only or not
		/// </bInReadOnly>
		public static void SetReadOnly(UMovieSceneSequence Sequence, bool bInReadOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInReadOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetReadOnly, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the playback start
		/// </param>
		/// <param name="StartTime">
		/// The desired start time in seconds for this sequence
		/// </param>
		public static void SetPlaybackStartSeconds(UMovieSceneSequence Sequence, float StartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackStartSeconds, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the playback start
		/// </param>
		/// <param name="StartFrame">
		/// The desired start frame for this sequence
		/// </param>
		public static void SetPlaybackStart(UMovieSceneSequence Sequence, int StartFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = StartFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackStart, __InBuffer);
			}
		}

		/// <bInLocked>
		/// Whether the movie scene playback range should be locked
		/// </bInLocked>
		public static void SetPlaybackRangeLocked(UMovieSceneSequence Sequence, bool bInLocked)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInLocked;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackRangeLocked, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the playback end
		/// </param>
		/// <param name="EndTime">
		/// The desired end time in seconds for this sequence
		/// </param>
		public static void SetPlaybackEndSeconds(UMovieSceneSequence Sequence, float EndTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EndTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackEndSeconds, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the playback end
		/// </param>
		/// <param name="EndFrame">
		/// The desired end frame for this sequence
		/// </param>
		public static void SetPlaybackEnd(UMovieSceneSequence Sequence, int EndFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = EndFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackEnd, __InBuffer);
			}
		}

		/// <bInLocked>
		/// Whether the movie scene marked frames should be locked
		/// </bInLocked>
		public static void SetMarkedFramesLocked(UMovieSceneSequence Sequence, bool bInLocked)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInLocked;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMarkedFramesLocked, __InBuffer);
			}
		}

		/// <InMarkIndex>
		/// The given user marked frame index to edit
		/// </InMarkIndex>
		/// <InFrameNumber>
		/// The frame number to set
		/// </InFrameNumber>
		public static void SetMarkedFrame(UMovieSceneSequence Sequence, int InMarkIndex, FFrameNumber InFrameNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InMarkIndex;

				*(nint*)(__InBuffer + 12) = InFrameNumber?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMarkedFrame, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the evaluation type
		/// </param>
		/// <param name="InEvaluationType">
		/// The evaluation type to set for this sequence
		/// </param>
		public static void SetEvaluationType(UMovieSceneSequence InSequence, EMovieSceneEvaluationType InEvaluationType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InEvaluationType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEvaluationType, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="DisplayRate">
		/// The display rate that this sequence is displayed as
		/// </param>
		public static void SetDisplayRate(UMovieSceneSequence Sequence, FFrameRate DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DisplayRate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetDisplayRate, __InBuffer);
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to set the clock source
		/// </param>
		/// <param name="InClockSource">
		/// The clock source to set for this sequence
		/// </param>
		public static void SetClockSource(UMovieSceneSequence InSequence, EUpdateClockSource InClockSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InClockSource;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetClockSource, __InBuffer);
			}
		}

		/// <param name="RootSequence">
		/// The root sequence that contains the sequence
		/// </param>
		/// <param name="ObjectBindingID">
		/// The object binding id that has the guid and the sequence id
		/// </param>
		/// <returns>
		/// The new binding proxy
		/// </returns>
		public static FMovieSceneBindingProxy ResolveBindingID(UMovieSceneSequence RootSequence, FMovieSceneObjectBindingID InObjectBindingID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RootSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObjectBindingID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ResolveBindingID, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="Track">
		/// The track to remove
		/// </param>
		/// <returns>
		/// Whether the track was successfully removed
		/// </returns>
		public static bool RemoveTrack(UMovieSceneSequence Sequence, UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence That the folder belongs to
		/// </param>
		/// <param name="Folder">
		/// The folder to remove
		/// </param>
		public static void RemoveRootFolderFromSequence(UMovieSceneSequence Sequence, UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveRootFolderFromSequence, __InBuffer);
			}
		}

		public static bool RemoveMasterTrack(UMovieSceneSequence Sequence, UMovieSceneTrack Track)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Track?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveMasterTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to find the binding
		/// </param>
		/// <param name="StartTime">
		/// The time in seconds at which to start the range
		/// </param>
		/// <param name="Duration">
		/// The length of the range in seconds
		/// </param>
		/// <returns>
		/// Specified sequencer range
		/// </returns>
		public static FSequencerScriptingRange MakeRangeSeconds(UMovieSceneSequence Sequence, float StartTime, float Duration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				*(float*)(__InBuffer + 12) = Duration;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRangeSeconds, __InBuffer, __ReturnBuffer);

				return *(FSequencerScriptingRange*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to find the binding
		/// </param>
		/// <param name="StartFrame">
		/// The frame at which to start the range
		/// </param>
		/// <param name="Duration">
		/// The length of the range
		/// </param>
		/// <returns>
		/// Specified sequencer range
		/// </returns>
		public static FSequencerScriptingRange MakeRange(UMovieSceneSequence Sequence, int StartFrame, int Duration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = StartFrame;

				*(int*)(__InBuffer + 12) = Duration;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeRange, __InBuffer, __ReturnBuffer);

				return *(FSequencerScriptingRange*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to locate bound objects for
		/// </param>
		/// <param name="InBinding">
		/// The object binding
		/// </param>
		/// <param name="Context">
		/// Optional context to use to find the required object
		/// </param>
		/// <returns>
		/// An array of all bound objects
		/// </returns>
		public static TArray<UObject> LocateBoundObjects(UMovieSceneSequence Sequence, FMovieSceneBindingProxy InBinding, UObject Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LocateBoundObjects, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the movie scene is read only or not
		/// </returns>
		public static bool IsReadOnly(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsReadOnly, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the movie scene playback range is locked
		/// </returns>
		public static bool IsPlaybackRangeLocked(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsPlaybackRangeLocked, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the work range start
		/// </param>
		/// <returns>
		/// The work range start time in seconds for this sequence
		/// </returns>
		public static float GetWorkRangeStart(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetWorkRangeStart, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the work range end
		/// </param>
		/// <returns>
		/// The work range end time in seconds for this sequence
		/// </returns>
		public static float GetWorkRangeEnd(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetWorkRangeEnd, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the view range start
		/// </param>
		/// <returns>
		/// The view range start time in seconds for this sequence
		/// </returns>
		public static float GetViewRangeStart(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewRangeStart, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the view range end
		/// </param>
		/// <returns>
		/// The view range end time in seconds for this sequence
		/// </returns>
		public static float GetViewRangeEnd(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetViewRangeEnd, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <returns>
		/// An array containing all tracks in this sequence
		/// </returns>
		public static TArray<UMovieSceneTrack> GetTracks(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTracks, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <returns>
		/// The tick resolution of the sequence, defining the smallest unit of time representable on this sequence
		/// </returns>
		public static FFrameRate GetTickResolution(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTickResolution, __InBuffer, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to get spawnables for
		/// </param>
		/// <returns>
		/// Spawnables in this sequence
		/// </returns>
		public static TArray<FMovieSceneBindingProxy> GetSpawnables(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSpawnables, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to retrieve folders from
		/// </param>
		/// <returns>
		/// The folders contained within the given sequence
		/// </returns>
		public static TArray<UMovieSceneFolder> GetRootFoldersInSequence(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRootFoldersInSequence, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneFolder>*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to get possessables for
		/// </param>
		/// <returns>
		/// Possessables in this sequence
		/// </returns>
		public static TArray<FMovieSceneBindingProxy> GetPossessables(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPossessables, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : This function must be used over GetBindingID when the target binding resides in different shots or sub-sequences.
		/// </note>
		/// <note>
		/// : Only unique instances of sequences within a root sequences are supported
		/// </note>
		/// <param name="RootSequence">
		/// The root sequence that contains both the destination sequence (that will resolve the binding ID) and the target sequence that contains the actual binding
		/// </param>
		/// <param name="DestinationSequence">
		/// The sequence that will own or resolve the resulting binding ID. For example, if the binding ID will be applied to a camera cut section pass the sequence that contains the camera cut track to this parameter.
		/// </param>
		/// <param name="Binding">
		/// The target binding to create the ID from
		/// </param>
		/// <returns>
		/// The binding's id
		/// </returns>
		public static FMovieSceneObjectBindingID GetPortableBindingID(UMovieSceneSequence RootSequence, UMovieSceneSequence DestinationSequence, FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RootSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPortableBindingID, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the playback start
		/// </param>
		/// <returns>
		/// Playback start of this sequence
		/// </returns>
		public static float GetPlaybackStartSeconds(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackStartSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the playback start
		/// </param>
		/// <returns>
		/// Playback start of this sequence
		/// </returns>
		public static int GetPlaybackStart(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackStart, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the playback range
		/// </param>
		/// <returns>
		/// Playback range of this sequence
		/// </returns>
		public static FSequencerScriptingRange GetPlaybackRange(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackRange, __InBuffer, __ReturnBuffer);

				return *(FSequencerScriptingRange*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the playback end
		/// </param>
		/// <returns>
		/// Playback end of this sequence
		/// </returns>
		public static float GetPlaybackEndSeconds(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackEndSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the playback end
		/// </param>
		/// <returns>
		/// Playback end of this sequence
		/// </returns>
		public static int GetPlaybackEnd(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackEnd, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <returns>
		/// This sequence's movie scene data object
		/// </returns>
		public static UMovieScene GetMovieScene(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMovieScene, __InBuffer, __ReturnBuffer);

				return *(UMovieScene*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneTrack> GetMasterTracks(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMasterTracks, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Return the user marked frames
		/// </returns>
		public static TArray<FMovieSceneMarkedFrame> GetMarkedFrames(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMarkedFrames, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneMarkedFrame>*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the evaluation type
		/// </param>
		/// <returns>
		/// The evaluation type for this sequence
		/// </returns>
		public static EMovieSceneEvaluationType GetEvaluationType(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEvaluationType, __InBuffer, __ReturnBuffer);

				return *(EMovieSceneEvaluationType*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <returns>
		/// The display rate that this sequence is displayed as
		/// </returns>
		public static FFrameRate GetDisplayRate(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDisplayRate, __InBuffer, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to get the clock source
		/// </param>
		/// <returns>
		/// The clock source for this sequence
		/// </returns>
		public static EUpdateClockSource GetClockSource(UMovieSceneSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClockSource, __InBuffer, __ReturnBuffer);

				return *(EUpdateClockSource*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to get bindings for
		/// </param>
		/// <returns>
		/// An array of unique identifiers for all the bindings in this sequence
		/// </returns>
		public static TArray<FMovieSceneBindingProxy> GetBindings(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBindings, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// : The resulting binding is only valid when applied to properties within the same sequence as this binding. Use GetPortableBindingID for bindings which live in different sub-sequences.
		/// </note>
		/// <param name="Binding">
		/// The binding proxy to generate the binding id from
		/// </param>
		/// <returns>
		/// The binding's id
		/// </returns>
		public static FMovieSceneObjectBindingID GetBindingID(UMovieSceneSequence Sequence, FMovieSceneBindingProxy InBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBindingID, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type specifying which types of track to return
		/// </param>
		/// <returns>
		/// An array containing any tracks that match the type specified
		/// </returns>
		public static TArray<UMovieSceneTrack> FindTracksByType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTracksByType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type specifying the exact types of track to return
		/// </param>
		/// <returns>
		/// An array containing any tracks that are exactly the same as the type specified
		/// </returns>
		public static TArray<UMovieSceneTrack> FindTracksByExactType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTracksByExactType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <InFrameNumber>
		/// The frame number to find the next/previous user marked frame from
		/// </InFrameNumber>
		/// <bForward>
		/// Find forward from the given frame number.
		/// </bForward>
		public static int FindNextMarkedFrame(UMovieSceneSequence Sequence, FFrameNumber InFrameNumber, bool bForward)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFrameNumber?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bForward;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FindNextMarkedFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneTrack> FindMasterTracksByType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindMasterTracksByType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneTrack> FindMasterTracksByExactType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindMasterTracksByExactType, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <InLabel>
		/// The label to the user marked frame to find
		/// </InLabel>
		public static int FindMarkedFrameByLabel(UMovieSceneSequence Sequence, FString InLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FindMarkedFrameByLabel, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <InFrameNumber>
		/// The frame number of the user marked frame to find
		/// </InFrameNumber>
		public static int FindMarkedFrameByFrameNumber(UMovieSceneSequence Sequence, FFrameNumber InFrameNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFrameNumber?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __FindMarkedFrameByFrameNumber, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to find the binding
		/// </param>
		/// <param name="Name">
		/// The display name of the binding to look up
		/// </param>
		/// <returns>
		/// A unique identifier for the binding, or invalid
		/// </returns>
		public static FMovieSceneBindingProxy FindBindingByName(UMovieSceneSequence Sequence, FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindBindingByName, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence within which to find the binding
		/// </param>
		/// <param name="BindingId">
		/// The binding Id to look up
		/// </param>
		/// <returns>
		/// A unique identifier for the binding, or invalid
		/// </returns>
		public static FMovieSceneBindingProxy FindBindingById(UMovieSceneSequence Sequence, FGuid BindingId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BindingId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindBindingById, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		public static void DeleteMarkedFrames(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteMarkedFrames, __InBuffer);
			}
		}

		/// <DeleteIndex>
		/// The index to the user marked frame to delete
		/// </DeleteIndex>
		public static void DeleteMarkedFrame(UMovieSceneSequence Sequence, int DeleteIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = DeleteIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DeleteMarkedFrame, __InBuffer);
			}
		}

		/// <returns>
		/// Whether the movie scene marked frames are locked
		/// </returns>
		public static bool AreMarkedFramesLocked(UMovieSceneSequence Sequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AreMarkedFramesLocked, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to use
		/// </param>
		/// <param name="TrackType">
		/// A UMovieSceneTrack class type to create
		/// </param>
		/// <returns>
		/// The newly created track, if successful
		/// </returns>
		public static UMovieSceneTrack AddTrack(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddTrack, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneTrack*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to add to
		/// </param>
		/// <param name="ObjectToSpawn">
		/// An object instance to use as a template for spawning
		/// </param>
		/// <returns>
		/// A unique identifier for the new binding
		/// </returns>
		public static FMovieSceneBindingProxy AddSpawnableFromInstance(UMovieSceneSequence Sequence, UObject ObjectToSpawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectToSpawn?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSpawnableFromInstance, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to add to
		/// </param>
		/// <param name="ClassToSpawn">
		/// A class or blueprint type to spawn for this binding
		/// </param>
		/// <returns>
		/// A unique identifier for the new binding
		/// </returns>
		public static FMovieSceneBindingProxy AddSpawnableFromClass(UMovieSceneSequence Sequence, UClass ClassToSpawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClassToSpawn?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSpawnableFromClass, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to add a folder to
		/// </param>
		/// <param name="NewFolderName">
		/// The name to give the added folder
		/// </param>
		/// <returns>
		/// The newly created folder
		/// </returns>
		public static UMovieSceneFolder AddRootFolderToSequence(UMovieSceneSequence Sequence, FString NewFolderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewFolderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddRootFolderToSequence, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneFolder*)__ReturnBuffer;
			}
		}

		/// <param name="Sequence">
		/// The sequence to add a possessable to
		/// </param>
		/// <param name="ObjectToPossess">
		/// The object that this sequence should possess when evaluating
		/// </param>
		/// <returns>
		/// A unique identifier for the new binding
		/// </returns>
		public static FMovieSceneBindingProxy AddPossessable(UMovieSceneSequence Sequence, UObject ObjectToPossess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectToPossess?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddPossessable, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		public static UMovieSceneTrack AddMasterTrack(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddMasterTrack, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneTrack*)__ReturnBuffer;
			}
		}

		/// <InMarkedFrame>
		/// The given user marked frame to add
		/// </InMarkedFrame>
		/// <returns>
		/// The index to the newly added marked frame
		/// </returns>
		public static int AddMarkedFrame(UMovieSceneSequence Sequence, FMovieSceneMarkedFrame InMarkedFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMarkedFrame?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddMarkedFrame, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SortMarkedFrames = 0;

		private static uint __SetWorkRangeStart = 0;

		private static uint __SetWorkRangeEnd = 0;

		private static uint __SetViewRangeStart = 0;

		private static uint __SetViewRangeEnd = 0;

		private static uint __SetTickResolutionDirectly = 0;

		private static uint __SetTickResolution = 0;

		private static uint __SetReadOnly = 0;

		private static uint __SetPlaybackStartSeconds = 0;

		private static uint __SetPlaybackStart = 0;

		private static uint __SetPlaybackRangeLocked = 0;

		private static uint __SetPlaybackEndSeconds = 0;

		private static uint __SetPlaybackEnd = 0;

		private static uint __SetMarkedFramesLocked = 0;

		private static uint __SetMarkedFrame = 0;

		private static uint __SetEvaluationType = 0;

		private static uint __SetDisplayRate = 0;

		private static uint __SetClockSource = 0;

		private static uint __ResolveBindingID = 0;

		private static uint __RemoveTrack = 0;

		private static uint __RemoveRootFolderFromSequence = 0;

		private static uint __RemoveMasterTrack = 0;

		private static uint __MakeRangeSeconds = 0;

		private static uint __MakeRange = 0;

		private static uint __LocateBoundObjects = 0;

		private static uint __IsReadOnly = 0;

		private static uint __IsPlaybackRangeLocked = 0;

		private static uint __GetWorkRangeStart = 0;

		private static uint __GetWorkRangeEnd = 0;

		private static uint __GetViewRangeStart = 0;

		private static uint __GetViewRangeEnd = 0;

		private static uint __GetTracks = 0;

		private static uint __GetTickResolution = 0;

		private static uint __GetSpawnables = 0;

		private static uint __GetRootFoldersInSequence = 0;

		private static uint __GetPossessables = 0;

		private static uint __GetPortableBindingID = 0;

		private static uint __GetPlaybackStartSeconds = 0;

		private static uint __GetPlaybackStart = 0;

		private static uint __GetPlaybackRange = 0;

		private static uint __GetPlaybackEndSeconds = 0;

		private static uint __GetPlaybackEnd = 0;

		private static uint __GetMovieScene = 0;

		private static uint __GetMasterTracks = 0;

		private static uint __GetMarkedFrames = 0;

		private static uint __GetEvaluationType = 0;

		private static uint __GetDisplayRate = 0;

		private static uint __GetClockSource = 0;

		private static uint __GetBindings = 0;

		private static uint __GetBindingID = 0;

		private static uint __FindTracksByType = 0;

		private static uint __FindTracksByExactType = 0;

		private static uint __FindNextMarkedFrame = 0;

		private static uint __FindMasterTracksByType = 0;

		private static uint __FindMasterTracksByExactType = 0;

		private static uint __FindMarkedFrameByLabel = 0;

		private static uint __FindMarkedFrameByFrameNumber = 0;

		private static uint __FindBindingByName = 0;

		private static uint __FindBindingById = 0;

		private static uint __DeleteMarkedFrames = 0;

		private static uint __DeleteMarkedFrame = 0;

		private static uint __AreMarkedFramesLocked = 0;

		private static uint __AddTrack = 0;

		private static uint __AddSpawnableFromInstance = 0;

		private static uint __AddSpawnableFromClass = 0;

		private static uint __AddRootFolderToSequence = 0;

		private static uint __AddPossessable = 0;

		private static uint __AddMasterTrack = 0;

		private static uint __AddMarkedFrame = 0;
	}
}