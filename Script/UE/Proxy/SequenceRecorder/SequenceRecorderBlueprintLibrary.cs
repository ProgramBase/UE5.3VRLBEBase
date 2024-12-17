using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary")]
	public partial class USequenceRecorderBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorder.SequenceRecorderBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void StopRecordingSequence()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __StopRecordingSequence);
			}
		}

		/// <param name="ActorsToRecord">
		/// The actors to record
		/// </param>
		public static void StartRecordingSequence(TArray<AActor> ActorsToRecord)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToRecord?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StartRecordingSequence, __InBuffer);
			}
		}

		public static bool IsRecordingSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsRecordingSequence, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __StopRecordingSequence = 0;

		private static uint __StartRecordingSequence = 0;

		private static uint __IsRecordingSequence = 0;
	}
}