using Script.CoreUObject;
using Script.Library;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.RecordedTransformTrack")]
	public partial class FRecordedTransformTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Chaos.RecordedTransformTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRecordedTransformTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRecordedTransformTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRecordedTransformTrack A, FRecordedTransformTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRecordedTransformTrack A, FRecordedTransformTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRecordedTransformTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRecordedFrame> Records
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Records, __ReturnBuffer);

					return *(TArray<FRecordedFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Records, __InBuffer);
				}
			}
		}

		private static uint __Records = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}