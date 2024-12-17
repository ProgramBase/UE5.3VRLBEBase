using Script.CoreUObject;
using Script.Library;
using Script.InterchangeNodes;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeMeshGeometry")]
	public partial class FInterchangeMeshGeometry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangePipelines.InterchangeMeshGeometry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeMeshGeometry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeMeshGeometry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeMeshGeometry A, FInterchangeMeshGeometry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeMeshGeometry A, FInterchangeMeshGeometry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeMeshGeometry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString MeshUid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshUid, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshUid, __InBuffer);
				}
			}
		}

		public UInterchangeMeshNode MeshNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshNode, __ReturnBuffer);

					return *(UInterchangeMeshNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshNode, __InBuffer);
				}
			}
		}

		public TArray<FString> ReferencingMeshInstanceUids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencingMeshInstanceUids, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencingMeshInstanceUids, __InBuffer);
				}
			}
		}

		public TArray<FString> AttachedSocketUids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedSocketUids, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedSocketUids, __InBuffer);
				}
			}
		}

		private static uint __MeshUid = 0;

		private static uint __MeshNode = 0;

		private static uint __ReferencingMeshInstanceUids = 0;

		private static uint __AttachedSocketUids = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}