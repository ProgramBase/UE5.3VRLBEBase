using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryCollectionEngine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetGeometryCollectionSourcesDataflowNode")]
	public partial class FGetGeometryCollectionSourcesDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetGeometryCollectionSourcesDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetGeometryCollectionSourcesDataflowNode()
		{
		}

		public static bool operator ==(FGetGeometryCollectionSourcesDataflowNode A, FGetGeometryCollectionSourcesDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetGeometryCollectionSourcesDataflowNode A, FGetGeometryCollectionSourcesDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetGeometryCollectionSourcesDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UGeometryCollection Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(UGeometryCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __InBuffer);
				}
			}
		}

		public TArray<FGeometryCollectionSource> Sources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sources, __ReturnBuffer);

					return *(TArray<FGeometryCollectionSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sources, __InBuffer);
				}
			}
		}

		private static uint __Asset = 0;

		private static uint __Sources = 0;

	}
}