using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_InverseExecution")]
	public partial class FRigUnit_InverseExecution : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_InverseExecution");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_InverseExecution()
		{
		}

		public static bool operator ==(FRigUnit_InverseExecution A, FRigUnit_InverseExecution B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_InverseExecution A, FRigUnit_InverseExecution B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_InverseExecution;

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

		private static uint __ExecuteContext = 0;

	}
}