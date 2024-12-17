﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem")]
	public partial class FRigUnit_CCDIK_RotationLimitPerItem : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CCDIK_RotationLimitPerItem");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CCDIK_RotationLimitPerItem() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_CCDIK_RotationLimitPerItem() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_CCDIK_RotationLimitPerItem A, FRigUnit_CCDIK_RotationLimitPerItem B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CCDIK_RotationLimitPerItem A, FRigUnit_CCDIK_RotationLimitPerItem B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CCDIK_RotationLimitPerItem;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey Item
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Item, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Item, __InBuffer);
				}
			}
		}

		public float Limit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __InBuffer);
				}
			}
		}

		private static uint __Item = 0;

		private static uint __Limit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}