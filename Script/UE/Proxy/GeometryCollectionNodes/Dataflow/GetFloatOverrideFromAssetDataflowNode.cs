﻿using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetFloatOverrideFromAssetDataflowNode")]
	public partial class FGetFloatOverrideFromAssetDataflowNode : FDataflowOverrideNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetFloatOverrideFromAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetFloatOverrideFromAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetFloatOverrideFromAssetDataflowNode A, FGetFloatOverrideFromAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetFloatOverrideFromAssetDataflowNode A, FGetFloatOverrideFromAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetFloatOverrideFromAssetDataflowNode;

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

		public float FloatDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatDefault, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatDefault, __InBuffer);
				}
			}
		}

		private static uint __Float = 0;

		private static uint __FloatDefault = 0;

	}
}