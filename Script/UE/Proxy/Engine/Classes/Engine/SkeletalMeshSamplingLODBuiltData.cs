using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshSamplingLODBuiltData")]
	public partial class FSkeletalMeshSamplingLODBuiltData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshSamplingLODBuiltData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshSamplingLODBuiltData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkeletalMeshSamplingLODBuiltData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkeletalMeshSamplingLODBuiltData A, FSkeletalMeshSamplingLODBuiltData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshSamplingLODBuiltData A, FSkeletalMeshSamplingLODBuiltData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshSamplingLODBuiltData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}