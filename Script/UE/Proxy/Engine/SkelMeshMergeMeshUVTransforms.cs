using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkelMeshMergeMeshUVTransforms")]
	public partial class FSkelMeshMergeMeshUVTransforms : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkelMeshMergeMeshUVTransforms");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkelMeshMergeMeshUVTransforms() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkelMeshMergeMeshUVTransforms() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkelMeshMergeMeshUVTransforms A, FSkelMeshMergeMeshUVTransforms B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkelMeshMergeMeshUVTransforms A, FSkelMeshMergeMeshUVTransforms B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkelMeshMergeMeshUVTransforms;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTransform> UVTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UVTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UVTransforms, __InBuffer);
				}
			}
		}

		private static uint __UVTransforms = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}