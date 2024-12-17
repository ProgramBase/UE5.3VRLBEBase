using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.CinematicCamera;
using Script.MovieScene;
using Script.Engine;
using Script.Sequencer;
using Script.SequencerCore;
using Script.MovieSceneTools;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem")]
	public partial class ULevelSequenceEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SyncSectionsUsingSourceTimecode(TArray<UMovieSceneSection> Sections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sections?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SyncSectionsUsingSourceTimecode, __InBuffer);
			}
		}

		public virtual void SnapSectionsToTimelineUsingSourceTimecode(TArray<UMovieSceneSection> Sections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Sections?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SnapSectionsToTimelineUsingSourceTimecode, __InBuffer);
			}
		}

		public virtual void ReplaceBindingWithActors(TArray<AActor> Actors, FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceBindingWithActors, __InBuffer);
			}
		}

		public virtual void RemoveInvalidBindings(FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveInvalidBindings, __InBuffer);
			}
		}

		public virtual void RemoveAllBindings(FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllBindings, __InBuffer);
			}
		}

		public virtual void RemoveActorsFromBinding(TArray<AActor> Actors, FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveActorsFromBinding, __InBuffer);
			}
		}

		public virtual void RebindComponent(TArray<FMovieSceneBindingProxy> ComponentBindings, FName ComponentName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ComponentBindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ComponentName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RebindComponent, __InBuffer);
			}
		}

		public virtual bool PasteTracks(FString TextToImport, FMovieScenePasteTracksParams PasteTracksParams, ref TArray<UMovieSceneTrack> OutTracks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TextToImport?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PasteTracksParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutTracks?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __PasteTracks, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTracks = *(TArray<UMovieSceneTrack>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool PasteSections(FString TextToImport, FMovieScenePasteSectionsParams PasteSectionsParams, ref TArray<UMovieSceneSection> OutSections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TextToImport?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PasteSectionsParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutSections?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __PasteSections, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSections = *(TArray<UMovieSceneSection>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool PasteFolders(FString TextToImport, FMovieScenePasteFoldersParams PasteFoldersParams, ref TArray<UMovieSceneFolder> OutFolders)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TextToImport?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PasteFoldersParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutFolders?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __PasteFolders, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFolders = *(TArray<UMovieSceneFolder>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool PasteBindings(FString TextToImport, FMovieScenePasteBindingsParams PasteBindingsParams, ref TArray<FMovieSceneBindingProxy> OutObjectBindings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = TextToImport?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PasteBindingsParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutObjectBindings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __PasteBindings, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutObjectBindings = *(TArray<FMovieSceneBindingProxy>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual USequencerScriptingLayer GetScriptingLayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScriptingLayer, __ReturnBuffer);

				return *(USequencerScriptingLayer*)__ReturnBuffer;
			}
		}

		public virtual void FixActorReferences()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FixActorReferences);
			}
		}

		public virtual FMovieSceneBindingProxy CreateCamera(bool bSpawnable, ref ACineCameraActor OutActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bSpawnable;

				*(nint*)(__InBuffer + 1) = OutActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateCamera, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActor = *(ACineCameraActor*)(__OutBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		public virtual void CopyTracks(TArray<UMovieSceneTrack> Tracks, ref FString ExportedText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Tracks?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExportedText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CopyTracks, __InBuffer, __OutBuffer);

				ExportedText = *(FString*)(__OutBuffer);

			}
		}

		public virtual void CopySections(TArray<UMovieSceneSection> Sections, ref FString ExportedText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Sections?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExportedText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CopySections, __InBuffer, __OutBuffer);

				ExportedText = *(FString*)(__OutBuffer);

			}
		}

		public virtual void CopyFolders(TArray<UMovieSceneFolder> Folders, ref FString ExportedText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folders?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExportedText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CopyFolders, __InBuffer, __OutBuffer);

				ExportedText = *(FString*)(__OutBuffer);

			}
		}

		public virtual void CopyBindings(TArray<FMovieSceneBindingProxy> Bindings, ref FString ExportedText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Bindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExportedText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CopyBindings, __InBuffer, __OutBuffer);

				ExportedText = *(FString*)(__OutBuffer);

			}
		}

		public virtual TArray<FMovieSceneBindingProxy> ConvertToSpawnable(FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConvertToSpawnable, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		public virtual FMovieSceneBindingProxy ConvertToPossessable(FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConvertToPossessable, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneBindingProxy*)__ReturnBuffer;
			}
		}

		public virtual bool BakeTransformWithSettings(TArray<FMovieSceneBindingProxy> ObjectBindings, FBakingAnimationKeySettings InSettings, FMovieSceneScriptingParams Params = null)
		{
			unsafe
			{
				Params ??= new FMovieSceneScriptingParams();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ObjectBindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Params?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BakeTransformWithSettings, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void BakeTransform(TArray<FMovieSceneBindingProxy> ObjectBindings, FFrameTime BakeInTime, FFrameTime BakeOutTime, FFrameTime BakeInterval, FMovieSceneScriptingParams Params = null)
		{
			unsafe
			{
				Params ??= new FMovieSceneScriptingParams();

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = ObjectBindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BakeInTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BakeOutTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BakeInterval?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Params?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BakeTransform, __InBuffer);
			}
		}

		public virtual void AddActorsToBinding(TArray<AActor> Actors, FMovieSceneBindingProxy ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddActorsToBinding, __InBuffer);
			}
		}

		public virtual TArray<FMovieSceneBindingProxy> AddActors(TArray<AActor> Actors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddActors, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		private static uint __SyncSectionsUsingSourceTimecode = 0;

		private static uint __SnapSectionsToTimelineUsingSourceTimecode = 0;

		private static uint __ReplaceBindingWithActors = 0;

		private static uint __RemoveInvalidBindings = 0;

		private static uint __RemoveAllBindings = 0;

		private static uint __RemoveActorsFromBinding = 0;

		private static uint __RebindComponent = 0;

		private static uint __PasteTracks = 0;

		private static uint __PasteSections = 0;

		private static uint __PasteFolders = 0;

		private static uint __PasteBindings = 0;

		private static uint __GetScriptingLayer = 0;

		private static uint __FixActorReferences = 0;

		private static uint __CreateCamera = 0;

		private static uint __CopyTracks = 0;

		private static uint __CopySections = 0;

		private static uint __CopyFolders = 0;

		private static uint __CopyBindings = 0;

		private static uint __ConvertToSpawnable = 0;

		private static uint __ConvertToPossessable = 0;

		private static uint __BakeTransformWithSettings = 0;

		private static uint __BakeTransform = 0;

		private static uint __AddActorsToBinding = 0;

		private static uint __AddActors = 0;
	}
}