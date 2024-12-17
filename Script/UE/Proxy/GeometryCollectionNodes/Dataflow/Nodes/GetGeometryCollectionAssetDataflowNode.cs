using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryCollectionEngine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetGeometryCollectionAssetDataflowNode")]
	public partial class FGetGeometryCollectionAssetDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetGeometryCollectionAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetGeometryCollectionAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetGeometryCollectionAssetDataflowNode A, FGetGeometryCollectionAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetGeometryCollectionAssetDataflowNode A, FGetGeometryCollectionAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetGeometryCollectionAssetDataflowNode;

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

		private static uint __Asset = 0;

	}
}