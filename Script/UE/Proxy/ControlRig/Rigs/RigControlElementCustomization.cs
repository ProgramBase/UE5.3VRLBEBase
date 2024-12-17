using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigControlElementCustomization")]
	public partial class FRigControlElementCustomization : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigControlElementCustomization");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigControlElementCustomization() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigControlElementCustomization() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigControlElementCustomization A, FRigControlElementCustomization B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigControlElementCustomization A, FRigControlElementCustomization B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigControlElementCustomization;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigElementKey> AvailableSpaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AvailableSpaces, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AvailableSpaces, __InBuffer);
				}
			}
		}

		public TArray<FRigElementKey> RemovedSpaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RemovedSpaces, __ReturnBuffer);

					return *(TArray<FRigElementKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RemovedSpaces, __InBuffer);
				}
			}
		}

		private static uint __AvailableSpaces = 0;

		private static uint __RemovedSpaces = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}