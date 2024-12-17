using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.ChunkAssetDescribe")]
	public partial class FChunkAssetDescribe : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.ChunkAssetDescribe");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChunkAssetDescribe() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FChunkAssetDescribe() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FChunkAssetDescribe A, FChunkAssetDescribe B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChunkAssetDescribe A, FChunkAssetDescribe B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChunkAssetDescribe;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}