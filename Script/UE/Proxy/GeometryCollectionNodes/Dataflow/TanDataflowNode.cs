﻿using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.TanDataflowNode")]
	public partial class FTanDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.TanDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTanDataflowNode()
		{
		}

		public static bool operator ==(FTanDataflowNode A, FTanDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTanDataflowNode A, FTanDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTanDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Float
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Float, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Float, __InBuffer);
				}
			}
		}

		public float ReturnValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReturnValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReturnValue, __InBuffer);
				}
			}
		}

		private static uint __Float = 0;

		private static uint __ReturnValue = 0;

	}
}