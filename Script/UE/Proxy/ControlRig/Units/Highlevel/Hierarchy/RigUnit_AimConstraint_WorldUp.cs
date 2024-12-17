using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_AimConstraint_WorldUp")]
	public partial class FRigUnit_AimConstraint_WorldUp : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_AimConstraint_WorldUp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_AimConstraint_WorldUp() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_AimConstraint_WorldUp() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_AimConstraint_WorldUp A, FRigUnit_AimConstraint_WorldUp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_AimConstraint_WorldUp A, FRigUnit_AimConstraint_WorldUp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_AimConstraint_WorldUp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Target
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Target, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Target, __InBuffer);
				}
			}
		}

		public EControlRigVectorKind Kind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Kind, __ReturnBuffer);

					return *(EControlRigVectorKind*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Kind, __InBuffer);
				}
			}
		}

		public FRigElementKey Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		private static uint __Target = 0;

		private static uint __Kind = 0;

		private static uint __Space = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}