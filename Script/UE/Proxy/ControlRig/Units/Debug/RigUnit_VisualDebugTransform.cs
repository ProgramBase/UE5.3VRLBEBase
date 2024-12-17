﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_VisualDebugTransform")]
	public partial class FRigUnit_VisualDebugTransform : FRigUnit_DebugBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_VisualDebugTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_VisualDebugTransform()
		{
		}

		public static bool operator ==(FRigUnit_VisualDebugTransform A, FRigUnit_VisualDebugTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_VisualDebugTransform A, FRigUnit_VisualDebugTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_VisualDebugTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public bool bEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __InBuffer);
				}
			}
		}

		public float Thickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Thickness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Thickness, __InBuffer);
				}
			}
		}

		public float Scale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Scale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Scale, __InBuffer);
				}
			}
		}

		public FName BoneSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneSpace, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneSpace, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __bEnabled = 0;

		private static uint __Thickness = 0;

		private static uint __Scale = 0;

		private static uint __BoneSpace = 0;

	}
}