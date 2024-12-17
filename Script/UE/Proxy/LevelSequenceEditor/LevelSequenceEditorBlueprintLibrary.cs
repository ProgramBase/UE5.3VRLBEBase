using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;
using Script.LevelSequence;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary")]
	public partial class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetTrackFilterEnabled(FText TrackFilterName, bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = TrackFilterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTrackFilterEnabled, __InBuffer);
			}
		}

		public static void SetSelectionRangeStart(int NewFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSelectionRangeStart, __InBuffer);
			}
		}

		public static void SetSelectionRangeEnd(int NewFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSelectionRangeEnd, __InBuffer);
			}
		}

		public static void SetRandomColorForChannels(UClass Class, TArray<FString> Identifiers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifiers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRandomColorForChannels, __InBuffer);
			}
		}

		public static void SetPlaybackSpeed(float NewPlaybackSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewPlaybackSpeed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetPlaybackSpeed, __InBuffer);
			}
		}

		public static void SetLockLevelSequence(bool bLock)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bLock;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLockLevelSequence, __InBuffer);
			}
		}

		public static void SetLockCameraCutToViewport(bool bLock)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bLock;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLockCameraCutToViewport, __InBuffer);
			}
		}

		public static void SetCustomColorForChannels(UClass Class, TArray<FString> Identifiers, TArray<FLinearColor> NewColors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifiers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewColors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCustomColorForChannels, __InBuffer);
			}
		}

		public static void SetCustomColorForChannel(UClass Class, FString Identifier, FLinearColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCustomColorForChannel, __InBuffer);
			}
		}

		public static void SetCurrentTime(int NewFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentTime, __InBuffer);
			}
		}

		public static void SetCurrentLocalTime(int NewFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewFrame;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentLocalTime, __InBuffer);
			}
		}

		public static void SelectTracks(TArray<UMovieSceneTrack> Tracks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tracks?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectTracks, __InBuffer);
			}
		}

		public static void SelectSections(TArray<UMovieSceneSection> Sections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sections?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectSections, __InBuffer);
			}
		}

		public static void SelectObjects(TArray<FGuid> ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectObjects, __InBuffer);
			}
		}

		public static void SelectFolders(TArray<UMovieSceneFolder> Folders)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folders?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectFolders, __InBuffer);
			}
		}

		public static void SelectChannels(TArray<FSequencerChannelProxy> Channels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Channels?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectChannels, __InBuffer);
			}
		}

		public static void SelectBindings(TArray<FMovieSceneBindingProxy> ObjectBindings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBindings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SelectBindings, __InBuffer);
			}
		}

		public static void RefreshCurrentLevelSequence()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __RefreshCurrentLevelSequence);
			}
		}

		public static void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlaybackParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PlayTo, __InBuffer);
			}
		}

		public static void Play()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __Play);
			}
		}

		public static void Pause()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __Pause);
			}
		}

		public static bool OpenLevelSequence(ULevelSequence LevelSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __OpenLevelSequence, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsTrackFilterEnabled(FText TrackFilterName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TrackFilterName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTrackFilterEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsLevelSequenceLocked()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsLevelSequenceLocked, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsCameraCutLockedToViewport()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsCameraCutLockedToViewport, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasCustomColorForChannel(UClass Class, FString Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasCustomColorForChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FText> GetTrackFilterNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetTrackFilterNames, __ReturnBuffer);

				return *(TArray<FText>*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneSubSection> GetSubSequenceHierarchy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSubSequenceHierarchy, __ReturnBuffer);

				return *(TArray<UMovieSceneSubSection>*)__ReturnBuffer;
			}
		}

		public static int GetSelectionRangeStart()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectionRangeStart, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetSelectionRangeEnd()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectionRangeEnd, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneTrack> GetSelectedTracks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedTracks, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneSection> GetSelectedSections()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedSections, __ReturnBuffer);

				return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
			}
		}

		public static TArray<FGuid> GetSelectedObjects()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedObjects, __ReturnBuffer);

				return *(TArray<FGuid>*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneFolder> GetSelectedFolders()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedFolders, __ReturnBuffer);

				return *(TArray<UMovieSceneFolder>*)__ReturnBuffer;
			}
		}

		public static TArray<FSequencerChannelProxy> GetSelectedChannels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedChannels, __ReturnBuffer);

				return *(TArray<FSequencerChannelProxy>*)__ReturnBuffer;
			}
		}

		public static TArray<FMovieSceneBindingProxy> GetSelectedBindings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedBindings, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		public static float GetPlaybackSpeed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPlaybackSpeed, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static ULevelSequence GetFocusedLevelSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFocusedLevelSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		public static FLinearColor GetCustomColorForChannel(UClass Class, FString Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCustomColorForChannel, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static int GetCurrentTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentTime, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetCurrentLocalTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentLocalTime, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static ULevelSequence GetCurrentLevelSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentLevelSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		public static TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBoundObjects, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public static void FocusParentSequence()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __FocusParentSequence);
			}
		}

		public static void FocusLevelSequence(UMovieSceneSubSection SubSection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SubSection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __FocusLevelSequence, __InBuffer);
			}
		}

		public static void EmptySelection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EmptySelection);
			}
		}

		public static void DeleteColorForChannels(UClass Class, ref FString Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DeleteColorForChannels, __InBuffer, __OutBuffer);

				Identifier = *(FString*)(__OutBuffer);

			}
		}

		public static void CloseLevelSequence()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CloseLevelSequence);
			}
		}

		private static uint __SetTrackFilterEnabled = 0;

		private static uint __SetSelectionRangeStart = 0;

		private static uint __SetSelectionRangeEnd = 0;

		private static uint __SetRandomColorForChannels = 0;

		private static uint __SetPlaybackSpeed = 0;

		private static uint __SetLockLevelSequence = 0;

		private static uint __SetLockCameraCutToViewport = 0;

		private static uint __SetCustomColorForChannels = 0;

		private static uint __SetCustomColorForChannel = 0;

		private static uint __SetCurrentTime = 0;

		private static uint __SetCurrentLocalTime = 0;

		private static uint __SelectTracks = 0;

		private static uint __SelectSections = 0;

		private static uint __SelectObjects = 0;

		private static uint __SelectFolders = 0;

		private static uint __SelectChannels = 0;

		private static uint __SelectBindings = 0;

		private static uint __RefreshCurrentLevelSequence = 0;

		private static uint __PlayTo = 0;

		private static uint __Play = 0;

		private static uint __Pause = 0;

		private static uint __OpenLevelSequence = 0;

		private static uint __IsTrackFilterEnabled = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsLevelSequenceLocked = 0;

		private static uint __IsCameraCutLockedToViewport = 0;

		private static uint __HasCustomColorForChannel = 0;

		private static uint __GetTrackFilterNames = 0;

		private static uint __GetSubSequenceHierarchy = 0;

		private static uint __GetSelectionRangeStart = 0;

		private static uint __GetSelectionRangeEnd = 0;

		private static uint __GetSelectedTracks = 0;

		private static uint __GetSelectedSections = 0;

		private static uint __GetSelectedObjects = 0;

		private static uint __GetSelectedFolders = 0;

		private static uint __GetSelectedChannels = 0;

		private static uint __GetSelectedBindings = 0;

		private static uint __GetPlaybackSpeed = 0;

		private static uint __GetFocusedLevelSequence = 0;

		private static uint __GetCustomColorForChannel = 0;

		private static uint __GetCurrentTime = 0;

		private static uint __GetCurrentLocalTime = 0;

		private static uint __GetCurrentLevelSequence = 0;

		private static uint __GetBoundObjects = 0;

		private static uint __FocusParentSequence = 0;

		private static uint __FocusLevelSequence = 0;

		private static uint __EmptySelection = 0;

		private static uint __DeleteColorForChannels = 0;

		private static uint __CloseLevelSequence = 0;
	}
}