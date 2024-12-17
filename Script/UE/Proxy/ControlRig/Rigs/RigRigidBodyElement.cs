using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigRigidBodyElement")]
	public partial class FRigRigidBodyElement : FRigSingleParentElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigRigidBodyElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigRigidBodyElement()
		{
		}

		public static bool operator ==(FRigRigidBodyElement A, FRigRigidBodyElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigRigidBodyElement A, FRigRigidBodyElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigRigidBodyElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigRigidBodySettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FRigRigidBodySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		private static uint __Settings = 0;

	}
}