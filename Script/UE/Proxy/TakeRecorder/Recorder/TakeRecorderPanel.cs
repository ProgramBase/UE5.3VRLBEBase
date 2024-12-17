using Script.CoreUObject;
using Script.Library;
using Script.LevelSequence;
using Script.TakesCore;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.TakeRecorderPanel")]
	public partial class UTakeRecorderPanel : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorder.TakeRecorderPanel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopRecording()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopRecording);
			}
		}

		public virtual void StartRecording()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartRecording);
			}
		}

		public virtual void SetupForViewing(ULevelSequence LevelSequenceAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelSequenceAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupForViewing, __InBuffer);
			}
		}

		public virtual void SetupForRecordingInto_LevelSequence(ULevelSequence LevelSequenceAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelSequenceAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupForRecordingInto_LevelSequence, __InBuffer);
			}
		}

		public virtual void SetupForRecording_TakePreset(UTakePreset TakePresetAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TakePresetAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupForRecording_TakePreset, __InBuffer);
			}
		}

		public virtual void SetupForRecording_LevelSequence(ULevelSequence LevelSequenceAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelSequenceAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupForRecording_LevelSequence, __InBuffer);
			}
		}

		public virtual void SetupForEditing(UTakePreset TakePreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TakePreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupForEditing, __InBuffer);
			}
		}

		public virtual void SetFrameRateFromTimecode(bool bInFromTimecode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInFromTimecode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRateFromTimecode, __InBuffer);
			}
		}

		public virtual void SetFrameRate(FFrameRate InFrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRate, __InBuffer);
			}
		}

		public virtual void NewTake()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __NewTake);
			}
		}

		public virtual UTakeMetaData GetTakeMetaData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTakeMetaData, __ReturnBuffer);

				return *(UTakeMetaData*)__ReturnBuffer;
			}
		}

		public virtual UTakeRecorderSources GetSources()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSources, __ReturnBuffer);

				return *(UTakeRecorderSources*)__ReturnBuffer;
			}
		}

		public virtual ETakeRecorderPanelMode GetMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMode, __ReturnBuffer);

				return *(ETakeRecorderPanelMode*)__ReturnBuffer;
			}
		}

		public virtual ULevelSequence GetLevelSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLevelSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		public virtual ULevelSequence GetLastRecordedLevelSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastRecordedLevelSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		public virtual FFrameRate GetFrameRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFrameRate, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		public virtual void ClearPendingTake()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearPendingTake);
			}
		}

		public virtual bool CanStartRecording(ref FText OutErrorText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutErrorText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __CanStartRecording, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutErrorText = *(FText*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __StopRecording = 0;

		private static uint __StartRecording = 0;

		private static uint __SetupForViewing = 0;

		private static uint __SetupForRecordingInto_LevelSequence = 0;

		private static uint __SetupForRecording_TakePreset = 0;

		private static uint __SetupForRecording_LevelSequence = 0;

		private static uint __SetupForEditing = 0;

		private static uint __SetFrameRateFromTimecode = 0;

		private static uint __SetFrameRate = 0;

		private static uint __NewTake = 0;

		private static uint __GetTakeMetaData = 0;

		private static uint __GetSources = 0;

		private static uint __GetMode = 0;

		private static uint __GetLevelSequence = 0;

		private static uint __GetLastRecordedLevelSequence = 0;

		private static uint __GetFrameRate = 0;

		private static uint __ClearPendingTake = 0;

		private static uint __CanStartRecording = 0;
	}
}