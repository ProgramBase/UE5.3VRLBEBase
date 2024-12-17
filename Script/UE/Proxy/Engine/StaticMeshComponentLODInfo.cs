using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMeshComponentLODInfo")]
	public partial class FStaticMeshComponentLODInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticMeshComponentLODInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticMeshComponentLODInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStaticMeshComponentLODInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStaticMeshComponentLODInfo A, FStaticMeshComponentLODInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticMeshComponentLODInfo A, FStaticMeshComponentLODInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticMeshComponentLODInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}