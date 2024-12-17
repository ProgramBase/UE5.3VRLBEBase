using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.DataflowNodes
{
	[PathName("/Script/DataflowNodes.SkeletalMeshReferenceTransformDataflowNode")]
	public partial class FSkeletalMeshReferenceTransformDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowNodes.SkeletalMeshReferenceTransformDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshReferenceTransformDataflowNode()
		{
		}

		public static bool operator ==(FSkeletalMeshReferenceTransformDataflowNode A, FSkeletalMeshReferenceTransformDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshReferenceTransformDataflowNode A, FSkeletalMeshReferenceTransformDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshReferenceTransformDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public USkeletalMesh SkeletalMeshIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshIn, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshIn, __InBuffer);
				}
			}
		}

		public int BoneIndexIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndexIn, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndexIn, __InBuffer);
				}
			}
		}

		public FTransform TransformOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformOut, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformOut, __InBuffer);
				}
			}
		}

		private static uint __SkeletalMeshIn = 0;

		private static uint __BoneIndexIn = 0;

		private static uint __TransformOut = 0;

	}
}