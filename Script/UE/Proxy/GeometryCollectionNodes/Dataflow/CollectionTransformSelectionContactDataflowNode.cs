﻿using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionTransformSelectionContactDataflowNode")]
	public partial class FCollectionTransformSelectionContactDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionTransformSelectionContactDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionTransformSelectionContactDataflowNode()
		{
		}

		public static bool operator ==(FCollectionTransformSelectionContactDataflowNode A, FCollectionTransformSelectionContactDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionTransformSelectionContactDataflowNode A, FCollectionTransformSelectionContactDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionTransformSelectionContactDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDataflowTransformSelection TransformSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __InBuffer);
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

		private static uint __TransformSelection = 0;

		private static uint __Collection = 0;

	}
}