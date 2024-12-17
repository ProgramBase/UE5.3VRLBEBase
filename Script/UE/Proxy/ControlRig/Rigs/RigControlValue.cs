using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigControlValue")]
	public partial class FRigControlValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigControlValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigControlValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigControlValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigControlValue A, FRigControlValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigControlValue A, FRigControlValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigControlValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigControlValueStorage FloatStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatStorage, __ReturnBuffer);

					return *(FRigControlValueStorage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatStorage, __InBuffer);
				}
			}
		}

		private static uint __FloatStorage = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}