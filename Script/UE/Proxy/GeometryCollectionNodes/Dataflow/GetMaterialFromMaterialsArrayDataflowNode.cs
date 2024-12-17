using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetMaterialFromMaterialsArrayDataflowNode")]
	public partial class FGetMaterialFromMaterialsArrayDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetMaterialFromMaterialsArrayDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetMaterialFromMaterialsArrayDataflowNode()
		{
		}

		public static bool operator ==(FGetMaterialFromMaterialsArrayDataflowNode A, FGetMaterialFromMaterialsArrayDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetMaterialFromMaterialsArrayDataflowNode A, FGetMaterialFromMaterialsArrayDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetMaterialFromMaterialsArrayDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UMaterial> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public UMaterial Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public int MaterialIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIdx, __InBuffer);
				}
			}
		}

		private static uint __Materials = 0;

		private static uint __Material = 0;

		private static uint __MaterialIdx = 0;

	}
}