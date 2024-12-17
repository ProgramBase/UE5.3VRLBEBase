using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetMultiControlRotator_Entry")]
	public partial class FRigUnit_SetMultiControlRotator_Entry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetMultiControlRotator_Entry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetMultiControlRotator_Entry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_SetMultiControlRotator_Entry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_SetMultiControlRotator_Entry A, FRigUnit_SetMultiControlRotator_Entry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetMultiControlRotator_Entry A, FRigUnit_SetMultiControlRotator_Entry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetMultiControlRotator_Entry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Control
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Control, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Control, __InBuffer);
				}
			}
		}

		public FRotator Rotator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotator, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotator, __InBuffer);
				}
			}
		}

		public ERigVMTransformSpace Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(ERigVMTransformSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		private static uint __Control = 0;

		private static uint __Rotator = 0;

		private static uint __Space = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}