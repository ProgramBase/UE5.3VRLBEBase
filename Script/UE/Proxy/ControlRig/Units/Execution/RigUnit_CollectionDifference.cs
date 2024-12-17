﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_CollectionDifference")]
	public partial class FRigUnit_CollectionDifference : FRigUnit_CollectionBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_CollectionDifference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_CollectionDifference()
		{
		}

		public static bool operator ==(FRigUnit_CollectionDifference A, FRigUnit_CollectionDifference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_CollectionDifference A, FRigUnit_CollectionDifference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_CollectionDifference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKeyCollection A
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __A, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __A, __InBuffer);
				}
			}
		}

		public FRigElementKeyCollection B
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __B, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __B, __InBuffer);
				}
			}
		}

		public FRigElementKeyCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FRigElementKeyCollection*)__ReturnBuffer;
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

		private static uint __A = 0;

		private static uint __B = 0;

		private static uint __Collection = 0;

	}
}