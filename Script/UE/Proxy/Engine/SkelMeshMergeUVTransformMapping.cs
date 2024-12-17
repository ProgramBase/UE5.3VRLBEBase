using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkelMeshMergeUVTransformMapping")]
	public partial class FSkelMeshMergeUVTransformMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkelMeshMergeUVTransformMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkelMeshMergeUVTransformMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkelMeshMergeUVTransformMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkelMeshMergeUVTransformMapping A, FSkelMeshMergeUVTransformMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkelMeshMergeUVTransformMapping A, FSkelMeshMergeUVTransformMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkelMeshMergeUVTransformMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSkelMeshMergeMeshUVTransforms> UVTransformsPerMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UVTransformsPerMesh, __ReturnBuffer);

					return *(TArray<FSkelMeshMergeMeshUVTransforms>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UVTransformsPerMesh, __InBuffer);
				}
			}
		}

		private static uint __UVTransformsPerMesh = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}