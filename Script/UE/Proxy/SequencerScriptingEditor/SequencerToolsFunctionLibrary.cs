using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieSceneCapture;
using Script.LevelSequence;
using Script.UnrealEd;
using Script.MovieScene;
using Script.SequencerScripting;
using Script.MovieSceneTools;
using Script.MovieSceneTracks;

namespace Script.SequencerScriptingEditor
{
	[PathName("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary")]
	public partial class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool RenderMovie(UMovieSceneCapture InCaptureSettings, FOnRenderMovieStopped OnFinishedCallback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InCaptureSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnFinishedCallback?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenderMovie, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <InSequence>
		/// Sequence to link from
		/// </InSequence>
		/// <AnimSequence>
		/// The AnimSequence to link to.
		/// </AnimSequence>
		/// <ExportOption>
		/// The export options that should be used when baking the LevelSequence.
		/// </ExportOption>
		/// <InBinding>
		/// Binding that has a skelmesh component on it
		/// </InBinding>
		public static bool LinkAnimSequence(ULevelSequence Sequence, UAnimSequence AnimSequence, UAnimSeqExportOption ExportOptions, FMovieSceneBindingProxy Binding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExportOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LinkAnimSequence, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRenderingMovie()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsRenderingMovie, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InEndpoint">
		/// Endpoint to check.
		/// </param>
		public static bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEndpoint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsEventEndpointValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <InWorld>
		/// World to import to
		/// </InWorld>
		/// <InSequence>
		/// InSequence to import
		/// </InSequence>
		/// <InBindings>
		/// InBindings to import
		/// </InBindings>
		/// <InImportFBXSettings>
		/// Settings to control import.
		/// </InImportFBXSettings>
		/// <InImportFileName>
		/// Path to fbx file to import from
		/// </InImportFileName>
		/// <InPlayer>
		/// Player to bind to
		/// </InPlayer>
		public static bool ImportLevelSequenceFBX(UWorld InWorld, ULevelSequence InSequence, TArray<FMovieSceneBindingProxy> InBindings, UMovieSceneUserImportFBXSettings InImportFBXSettings, FString InImportFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InImportFBXSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = InImportFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportLevelSequenceFBX, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <InWorld>
		/// World to import to
		/// </InWorld>
		/// <InSequence>
		/// InSequence to import
		/// </InSequence>
		/// <ActorWithControlRigTrack>
		/// ActorWithControlRigTrack The name of the actor with the control rig track we are importing onto
		/// </ActorWithControlRigTrack>
		/// <SelectedControlRigNames>
		/// List of selected control rig names. Will use them if  ImportFBXControlRigSettings->bImportOntoSelectedControls is true
		/// </SelectedControlRigNames>
		/// <ImportFBXControlRigSettings>
		/// Settings to control import.
		/// </ImportFBXControlRigSettings>
		/// <InImportFileName>
		/// Path to fbx file to create
		/// </InImportFileName>
		public static bool ImportFBXToControlRig(UWorld World, ULevelSequence InSequence, FString ActorWithControlRigTrack, TArray<FString> SelectedControlRigNames, UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings, FString ImportFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ActorWithControlRigTrack?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SelectedControlRigNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ImportFBXControlRigSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ImportFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportFBXToControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FSequencerBoundObjects> GetObjectBindings(UWorld InWorld, ULevelSequence InSequence, TArray<UObject> InObject, FSequencerScriptingRange InRange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InRange?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectBindings, __InBuffer, __ReturnBuffer);

				return *(TArray<FSequencerBoundObjects>*)__ReturnBuffer;
			}
		}

		/// <InAnimSequence>
		/// AnimSequence to get links from
		/// </InAnimSequence>
		/// <returns>
		/// Returns the link object if it exists, nullptr if it doesn't
		/// </returns>
		public static UAnimSequenceLevelSequenceLink GetLevelSequenceLinkFromAnimSequence(UAnimSequence InAnimSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLevelSequenceLinkFromAnimSequence, __InBuffer, __ReturnBuffer);

				return *(UAnimSequenceLevelSequenceLink*)__ReturnBuffer;
			}
		}

		public static TArray<FSequencerBoundObjects> GetBoundObjects(UWorld InWorld, ULevelSequence InSequence, TArray<FMovieSceneBindingProxy> InBindings, FSequencerScriptingRange InRange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBindings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InRange?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBoundObjects, __InBuffer, __ReturnBuffer);

				return *(TArray<FSequencerBoundObjects>*)__ReturnBuffer;
			}
		}

		/// <InLevelSequence>
		/// LevelSequence to get links from
		/// </InLevelSequence>
		/// <returns>
		/// Returns the link object if it exists, nullptr if it doesn't
		/// </returns>
		public static ULevelSequenceAnimSequenceLink GetAnimSequenceLinkFromLevelSequence(ULevelSequence InLevelSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimSequenceLinkFromLevelSequence, __InBuffer, __ReturnBuffer);

				return *(ULevelSequenceAnimSequenceLink*)__ReturnBuffer;
			}
		}

		public static bool ExportLevelSequenceFBX(FSequencerExportFBXParams InParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportLevelSequenceFBX, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ExportFBXFromControlRig(ULevelSequence Sequence, FString ActorWithControlRigTrack, UMovieSceneUserExportFBXControlRigSettings ExportFBXControlRigSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorWithControlRigTrack?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExportFBXControlRigSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportFBXFromControlRig, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <InWorld>
		/// World to export
		/// </InWorld>
		/// <InSequence>
		/// Sequence to export
		/// </InSequence>
		/// <AnimSequence>
		/// The AnimSequence to save into.
		/// </AnimSequence>
		/// <ExportOption>
		/// The export options for the sequence.
		/// </ExportOption>
		/// <InBinding>
		/// Binding to export that has a skelmesh component on it
		/// </InBinding>
		/// <InAnimSequenceFilename>
		/// File to create
		/// </InAnimSequenceFilename>
		/// <bCreateLink>
		/// If true will create a link between the animation sequence and the level sequence
		/// </bCreateLink>
		public static bool ExportAnimSequence(UWorld World, ULevelSequence Sequence, UAnimSequence AnimSequence, UAnimSeqExportOption ExportOption, FMovieSceneBindingProxy Binding, bool bCreateLink)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AnimSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ExportOption?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bCreateLink;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportAnimSequence, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InActor">
		/// Actor that will be bound
		/// </param>
		/// <param name="InFunctionName">
		/// Name of the method, as it is displayed in the Blueprint Editor. eg. "Set Actor Scale 3D"
		/// </param>
		/// <param name="bCallInEditor">
		/// Should the event be callable in editor.
		/// </param>
		/// <returns>
		/// The created binding.
		/// </returns>
		public static FSequencerQuickBindingResult CreateQuickBinding(UMovieSceneSequence InSequence, UObject InObject, FString InFunctionName, bool bCallInEditor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InFunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bCallInEditor;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateQuickBinding, __InBuffer, __ReturnBuffer);

				return *(FSequencerQuickBindingResult*)__ReturnBuffer;
			}
		}

		/// <param name="InSequence">
		/// Main level sequence that holds the event track and to which the resulting event should be added.
		/// </param>
		/// <param name="InSection">
		/// Section of the event track of the main sequence.
		/// </param>
		/// <param name="InEndpoint">
		/// Previously created endpoint.
		/// </param>
		/// <param name="InPayload">
		/// Values passed as payload to event, count must match the numbers of payload variable names in @InEndpoint.
		/// </param>
		/// <see>
		/// CreateQuickBinding
		/// </see>
		/// <returns>
		/// The created movie event.
		/// </returns>
		public static FMovieSceneEvent CreateEvent(UMovieSceneSequence InSequence, UMovieSceneEventSectionBase InSection, FSequencerQuickBindingResult InEndpoint, TArray<FString> InPayload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InEndpoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InPayload?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateEvent, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneEvent*)__ReturnBuffer;
			}
		}

		/// <InLevelSequence>
		/// LevelSequence to clean links for
		/// </InLevelSequence>
		public static void ClearLinkedAnimSequences(ULevelSequence InLevelSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearLinkedAnimSequences, __InBuffer);
			}
		}

		public static void CancelMovieRender()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CancelMovieRender);
			}
		}

		private static uint __RenderMovie = 0;

		private static uint __LinkAnimSequence = 0;

		private static uint __IsRenderingMovie = 0;

		private static uint __IsEventEndpointValid = 0;

		private static uint __ImportLevelSequenceFBX = 0;

		private static uint __ImportFBXToControlRig = 0;

		private static uint __GetObjectBindings = 0;

		private static uint __GetLevelSequenceLinkFromAnimSequence = 0;

		private static uint __GetBoundObjects = 0;

		private static uint __GetAnimSequenceLinkFromLevelSequence = 0;

		private static uint __ExportLevelSequenceFBX = 0;

		private static uint __ExportFBXFromControlRig = 0;

		private static uint __ExportAnimSequence = 0;

		private static uint __CreateQuickBinding = 0;

		private static uint __CreateEvent = 0;

		private static uint __ClearLinkedAnimSequences = 0;

		private static uint __CancelMovieRender = 0;
	}
}