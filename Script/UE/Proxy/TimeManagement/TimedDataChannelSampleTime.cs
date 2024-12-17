using Script.CoreUObject;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.TimedDataChannelSampleTime")]
	public partial class FTimedDataChannelSampleTime : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TimeManagement.TimedDataChannelSampleTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimedDataChannelSampleTime() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimedDataChannelSampleTime() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimedDataChannelSampleTime A, FTimedDataChannelSampleTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimedDataChannelSampleTime A, FTimedDataChannelSampleTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimedDataChannelSampleTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}