using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.LevelSequence;
using Script.TakesCore;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorderBlueprintLibrary")]
	public partial class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorder.TakeRecorderBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void StopRecording()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __StopRecording);
			}
		}

		/// <param name="LevelSequence">
		/// The base level sequence to use for the recording. Will be played back during the recording and duplicated to create the starting point for the resulting asset.
		/// </param>
		/// <param name="Sources">
		/// The sources to use for the recording
		/// </param>
		/// <param name="MetaData">
		/// Meta-data pertaining to this recording, duplicated into the resulting recorded sequence
		/// </param>
		/// <param name="Parameters">
		/// Configurable parameters for this recorder instance
		/// </param>
		/// <returns>
		/// The recorder responsible for the recording, or None if a a recording could not be started
		/// </returns>
		public static UTakeRecorder StartRecording(ULevelSequence LevelSequence, UTakeRecorderSources Sources, UTakeMetaData MetaData, FTakeRecorderParameters Parameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = LevelSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sources?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Parameters?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StartRecording, __InBuffer, __ReturnBuffer);

				return *(UTakeRecorder*)__ReturnBuffer;
			}
		}

		public static void SetOnTakeRecorderStopped(FOnTakeRecorderStopped OnTakeRecorderStopped)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderStopped?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderStopped, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderStarted(FOnTakeRecorderStarted OnTakeRecorderStarted)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderStarted?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderStarted, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderPreInitialize(FOnTakeRecorderPreInitialize OnTakeRecorderPreInitialize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderPreInitialize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderPreInitialize, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderPanelChanged(FOnTakeRecorderPanelChanged OnTakeRecorderPanelChanged)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderPanelChanged?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderPanelChanged, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderMarkedFrameAdded(FOnTakeRecorderMarkedFrameAdded OnTakeRecorderMarkedFrameAdded)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderMarkedFrameAdded?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderMarkedFrameAdded, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderFinished(FOnTakeRecorderFinished OnTakeRecorderFinished)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderFinished?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderFinished, __InBuffer);
			}
		}

		public static void SetOnTakeRecorderCancelled(FOnTakeRecorderCancelled OnTakeRecorderCancelled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OnTakeRecorderCancelled?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetOnTakeRecorderCancelled, __InBuffer);
			}
		}

		public static void SetDefaultParameters(FTakeRecorderParameters DefaultParameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DefaultParameters?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetDefaultParameters, __InBuffer);
			}
		}

		public static UTakeRecorderPanel OpenTakeRecorderPanel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __OpenTakeRecorderPanel, __ReturnBuffer);

				return *(UTakeRecorderPanel*)__ReturnBuffer;
			}
		}

		public static bool IsTakeRecorderEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsTakeRecorderEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRecording()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsRecording, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UTakeRecorderPanel GetTakeRecorderPanel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetTakeRecorderPanel, __ReturnBuffer);

				return *(UTakeRecorderPanel*)__ReturnBuffer;
			}
		}

		public static FTakeRecorderParameters GetDefaultParameters()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultParameters, __ReturnBuffer);

				return *(FTakeRecorderParameters*)__ReturnBuffer;
			}
		}

		public static UTakeRecorder GetActiveRecorder()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetActiveRecorder, __ReturnBuffer);

				return *(UTakeRecorder*)__ReturnBuffer;
			}
		}

		public static void CancelRecording()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CancelRecording);
			}
		}

		private static uint __StopRecording = 0;

		private static uint __StartRecording = 0;

		private static uint __SetOnTakeRecorderStopped = 0;

		private static uint __SetOnTakeRecorderStarted = 0;

		private static uint __SetOnTakeRecorderPreInitialize = 0;

		private static uint __SetOnTakeRecorderPanelChanged = 0;

		private static uint __SetOnTakeRecorderMarkedFrameAdded = 0;

		private static uint __SetOnTakeRecorderFinished = 0;

		private static uint __SetOnTakeRecorderCancelled = 0;

		private static uint __SetDefaultParameters = 0;

		private static uint __OpenTakeRecorderPanel = 0;

		private static uint __IsTakeRecorderEnabled = 0;

		private static uint __IsRecording = 0;

		private static uint __GetTakeRecorderPanel = 0;

		private static uint __GetDefaultParameters = 0;

		private static uint __GetActiveRecorder = 0;

		private static uint __CancelRecording = 0;
	}
}