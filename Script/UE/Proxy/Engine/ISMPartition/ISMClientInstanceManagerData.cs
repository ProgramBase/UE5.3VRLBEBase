using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ISMClientInstanceManagerData")]
	public partial class FISMClientInstanceManagerData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ISMClientInstanceManagerData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FISMClientInstanceManagerData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FISMClientInstanceManagerData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FISMClientInstanceManagerData A, FISMClientInstanceManagerData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FISMClientInstanceManagerData A, FISMClientInstanceManagerData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FISMClientInstanceManagerData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}