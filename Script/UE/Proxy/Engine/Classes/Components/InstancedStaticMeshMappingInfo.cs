using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstancedStaticMeshMappingInfo")]
	public partial class FInstancedStaticMeshMappingInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InstancedStaticMeshMappingInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstancedStaticMeshMappingInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInstancedStaticMeshMappingInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInstancedStaticMeshMappingInfo A, FInstancedStaticMeshMappingInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstancedStaticMeshMappingInfo A, FInstancedStaticMeshMappingInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstancedStaticMeshMappingInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}