using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.DataflowSphereCovering")]
	public partial class FDataflowSphereCovering : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.DataflowSphereCovering");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowSphereCovering() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataflowSphereCovering() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataflowSphereCovering A, FDataflowSphereCovering B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowSphereCovering A, FDataflowSphereCovering B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowSphereCovering;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}