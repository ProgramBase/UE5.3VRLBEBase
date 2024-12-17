using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryCollectionEngine;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetCollectionFromAssetDataflowNode")]
	public partial class FGetCollectionFromAssetDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetCollectionFromAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetCollectionFromAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetCollectionFromAssetDataflowNode A, FGetCollectionFromAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetCollectionFromAssetDataflowNode A, FGetCollectionFromAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetCollectionFromAssetDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UGeometryCollection CollectionAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollectionAsset, __ReturnBuffer);

					return *(UGeometryCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollectionAsset, __InBuffer);
				}
			}
		}

		public FManagedArrayCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FManagedArrayCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		private static uint __CollectionAsset = 0;

		private static uint __Collection = 0;

	}
}