using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.DataflowNodes
{
	[PathName("/Script/DataflowNodes.GetStaticMeshDataflowNode")]
	public partial class FGetStaticMeshDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowNodes.GetStaticMeshDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetStaticMeshDataflowNode()
		{
		}

		public static bool operator ==(FGetStaticMeshDataflowNode A, FGetStaticMeshDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetStaticMeshDataflowNode A, FGetStaticMeshDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetStaticMeshDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStaticMesh StaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __InBuffer);
				}
			}
		}

		public FName PropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __InBuffer);
				}
			}
		}

		private static uint __StaticMesh = 0;

		private static uint __PropertyName = 0;

	}
}