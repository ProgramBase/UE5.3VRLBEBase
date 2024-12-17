﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DrawContainerSetColor")]
	public partial class FRigUnit_DrawContainerSetColor : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DrawContainerSetColor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DrawContainerSetColor()
		{
		}

		public static bool operator ==(FRigUnit_DrawContainerSetColor A, FRigUnit_DrawContainerSetColor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DrawContainerSetColor A, FRigUnit_DrawContainerSetColor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DrawContainerSetColor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName InstructionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstructionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstructionName, __InBuffer);
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

		private static uint __InstructionName = 0;

		private static uint __Color = 0;

	}
}