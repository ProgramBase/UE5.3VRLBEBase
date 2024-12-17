using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DrawContainerSetThickness")]
	public partial class FRigUnit_DrawContainerSetThickness : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DrawContainerSetThickness");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DrawContainerSetThickness()
		{
		}

		public static bool operator ==(FRigUnit_DrawContainerSetThickness A, FRigUnit_DrawContainerSetThickness B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DrawContainerSetThickness A, FRigUnit_DrawContainerSetThickness B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DrawContainerSetThickness;

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

		private static uint __InstructionName = 0;

		private static uint __Thickness = 0;

	}
}