﻿using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.UpdateVolumeAttributesDataflowNode")]
	public partial class FUpdateVolumeAttributesDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.UpdateVolumeAttributesDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUpdateVolumeAttributesDataflowNode()
		{
		}

		public static bool operator ==(FUpdateVolumeAttributesDataflowNode A, FUpdateVolumeAttributesDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUpdateVolumeAttributesDataflowNode A, FUpdateVolumeAttributesDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUpdateVolumeAttributesDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __Collection = 0;

	}
}