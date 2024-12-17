using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.SequenceRecorderActorFilter")]
	public partial class FSequenceRecorderActorFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequenceRecorder.SequenceRecorderActorFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequenceRecorderActorFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSequenceRecorderActorFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSequenceRecorderActorFilter A, FSequenceRecorderActorFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequenceRecorderActorFilter A, FSequenceRecorderActorFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequenceRecorderActorFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<TSubclassOf<AActor>> ActorClassesToRecord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorClassesToRecord, __ReturnBuffer);

					return *(TArray<TSubclassOf<AActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorClassesToRecord, __InBuffer);
				}
			}
		}

		private static uint __ActorClassesToRecord = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}