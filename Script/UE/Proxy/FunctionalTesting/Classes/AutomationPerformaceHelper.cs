using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AutomationPerformaceHelper")]
	public partial class UAutomationPerformaceHelper : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.AutomationPerformaceHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void WriteLogFile(FString CaptureDir, FString CaptureExtension)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CaptureDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CaptureExtension?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteLogFile, __InBuffer);
			}
		}

		public virtual void TriggerGPUTraceIfRecordFallsBelowBudget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __TriggerGPUTraceIfRecordFallsBelowBudget);
			}
		}

		public virtual void Tick(float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Tick, __InBuffer);
			}
		}

		public virtual void StopCPUProfiling()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopCPUProfiling);
			}
		}

		public virtual void StartCPUProfiling()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartCPUProfiling);
			}
		}

		public virtual void Sample(float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Sample, __InBuffer);
			}
		}

		public virtual void OnBeginTests()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnBeginTests);
			}
		}

		public virtual void OnAllTestsComplete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnAllTestsComplete);
			}
		}

		public virtual bool IsRecording()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRecording, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsCurrentRecordWithinRenderThreadBudget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCurrentRecordWithinRenderThreadBudget, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsCurrentRecordWithinGPUBudget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCurrentRecordWithinGPUBudget, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsCurrentRecordWithinGameThreadBudget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCurrentRecordWithinGameThreadBudget, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void EndStatsFile()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndStatsFile);
			}
		}

		public virtual void EndRecordingBaseline()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndRecordingBaseline);
			}
		}

		public virtual void EndRecording()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndRecording);
			}
		}

		public virtual void BeginStatsFile(FString RecordName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RecordName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BeginStatsFile, __InBuffer);
			}
		}

		public virtual void BeginRecordingBaseline(FString RecordName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RecordName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BeginRecordingBaseline, __InBuffer);
			}
		}

		public virtual void BeginRecording(FString RecordName, float InGPUBudget, float InRenderThreadBudget, float InGameThreadBudget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = RecordName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InGPUBudget;

				*(float*)(__InBuffer + 12) = InRenderThreadBudget;

				*(float*)(__InBuffer + 16) = InGameThreadBudget;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BeginRecording, __InBuffer);
			}
		}

		private static uint __WriteLogFile = 0;

		private static uint __TriggerGPUTraceIfRecordFallsBelowBudget = 0;

		private static uint __Tick = 0;

		private static uint __StopCPUProfiling = 0;

		private static uint __StartCPUProfiling = 0;

		private static uint __Sample = 0;

		private static uint __OnBeginTests = 0;

		private static uint __OnAllTestsComplete = 0;

		private static uint __IsRecording = 0;

		private static uint __IsCurrentRecordWithinRenderThreadBudget = 0;

		private static uint __IsCurrentRecordWithinGPUBudget = 0;

		private static uint __IsCurrentRecordWithinGameThreadBudget = 0;

		private static uint __EndStatsFile = 0;

		private static uint __EndRecordingBaseline = 0;

		private static uint __EndRecording = 0;

		private static uint __BeginStatsFile = 0;

		private static uint __BeginRecordingBaseline = 0;

		private static uint __BeginRecording = 0;
	}
}