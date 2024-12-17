using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigPreferredEulerAngles")]
	public partial class FRigPreferredEulerAngles : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigPreferredEulerAngles");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigPreferredEulerAngles() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigPreferredEulerAngles() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigPreferredEulerAngles A, FRigPreferredEulerAngles B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigPreferredEulerAngles A, FRigPreferredEulerAngles B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigPreferredEulerAngles;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EEulerRotationOrder RotationOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrder, __ReturnBuffer);

					return *(EEulerRotationOrder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotationOrder, __InBuffer);
				}
			}
		}

		public FVector Current
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Current, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Current, __InBuffer);
				}
			}
		}

		public FVector Initial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Initial, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Initial, __InBuffer);
				}
			}
		}

		private static uint __RotationOrder = 0;

		private static uint __Current = 0;

		private static uint __Initial = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}