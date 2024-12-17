using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigControlPose")]
	public partial class FControlRigControlPose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ControlRigControlPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigControlPose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigControlPose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigControlPose A, FControlRigControlPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigControlPose A, FControlRigControlPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigControlPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigControlCopy> CopyOfControls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CopyOfControls, __ReturnBuffer);

					return *(TArray<FRigControlCopy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CopyOfControls, __InBuffer);
				}
			}
		}

		private static uint __CopyOfControls = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}