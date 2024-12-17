using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshSamplingRegionBuiltData")]
	public partial class FSkeletalMeshSamplingRegionBuiltData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshSamplingRegionBuiltData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshSamplingRegionBuiltData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkeletalMeshSamplingRegionBuiltData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkeletalMeshSamplingRegionBuiltData A, FSkeletalMeshSamplingRegionBuiltData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshSamplingRegionBuiltData A, FSkeletalMeshSamplingRegionBuiltData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshSamplingRegionBuiltData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}