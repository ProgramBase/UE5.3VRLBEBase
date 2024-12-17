using Script.CoreUObject;
using Script.Library;

namespace Script.MRMesh
{
	[PathName("/Script/MRMesh.MRMeshConfiguration")]
	public partial class FMRMeshConfiguration : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MRMesh.MRMeshConfiguration");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMRMeshConfiguration() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMRMeshConfiguration() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMRMeshConfiguration A, FMRMeshConfiguration B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMRMeshConfiguration A, FMRMeshConfiguration B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMRMeshConfiguration;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}