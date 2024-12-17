using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MaterialsInfoDataflowNode")]
	public partial class FMaterialsInfoDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MaterialsInfoDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialsInfoDataflowNode()
		{
		}

		public static bool operator ==(FMaterialsInfoDataflowNode A, FMaterialsInfoDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialsInfoDataflowNode A, FMaterialsInfoDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialsInfoDataflowNode;

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

		public FString String
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __String, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __String, __InBuffer);
				}
			}
		}

		private static uint __Materials = 0;

		private static uint __String = 0;

	}
}