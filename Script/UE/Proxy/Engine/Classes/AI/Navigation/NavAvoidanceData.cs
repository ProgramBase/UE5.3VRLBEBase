using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NavAvoidanceData")]
	public partial class FNavAvoidanceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NavAvoidanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavAvoidanceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNavAvoidanceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNavAvoidanceData A, FNavAvoidanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavAvoidanceData A, FNavAvoidanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavAvoidanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}