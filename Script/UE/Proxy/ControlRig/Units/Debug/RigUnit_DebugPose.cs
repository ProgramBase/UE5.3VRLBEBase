﻿using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DebugPose")]
	public partial class FRigUnit_DebugPose : FRigVMFunction_DebugBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DebugPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DebugPose()
		{
		}

		public static bool operator ==(FRigUnit_DebugPose A, FRigUnit_DebugPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DebugPose A, FRigUnit_DebugPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DebugPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FControlRigExecuteContext ExecuteContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteContext, __ReturnBuffer);

					return *(FControlRigExecuteContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteContext, __InBuffer);
				}
			}
		}

		public FRigPose Pose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __ReturnBuffer);

					return *(FRigPose*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pose, __InBuffer);
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

		public FLinearColor Color
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Color, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Color, __InBuffer);
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

		public FTransform WorldOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldOffset, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldOffset, __InBuffer);
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

		private static uint __ExecuteContext = 0;

		private static uint __Pose = 0;

		private static uint __Scale = 0;

		private static uint __Color = 0;

		private static uint __Thickness = 0;

		private static uint __WorldOffset = 0;

		private static uint __bEnabled = 0;

	}
}