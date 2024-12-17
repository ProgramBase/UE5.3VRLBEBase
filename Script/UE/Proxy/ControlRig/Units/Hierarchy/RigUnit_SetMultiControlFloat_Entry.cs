using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_SetMultiControlFloat_Entry")]
	public partial class FRigUnit_SetMultiControlFloat_Entry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_SetMultiControlFloat_Entry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_SetMultiControlFloat_Entry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigUnit_SetMultiControlFloat_Entry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigUnit_SetMultiControlFloat_Entry A, FRigUnit_SetMultiControlFloat_Entry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_SetMultiControlFloat_Entry A, FRigUnit_SetMultiControlFloat_Entry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_SetMultiControlFloat_Entry;

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

		public float FloatValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatValue, __InBuffer);
				}
			}
		}

		private static uint __Control = 0;

		private static uint __FloatValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}