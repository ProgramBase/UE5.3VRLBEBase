using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Engine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MakeMaterialsArrayDataflowNode")]
	public partial class FMakeMaterialsArrayDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MakeMaterialsArrayDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMakeMaterialsArrayDataflowNode()
		{
		}

		public static bool operator ==(FMakeMaterialsArrayDataflowNode A, FMakeMaterialsArrayDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMakeMaterialsArrayDataflowNode A, FMakeMaterialsArrayDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMakeMaterialsArrayDataflowNode;

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

		private static uint __Materials = 0;

	}
}