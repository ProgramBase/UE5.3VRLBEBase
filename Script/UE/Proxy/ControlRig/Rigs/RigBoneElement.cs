using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigBoneElement")]
	public partial class FRigBoneElement : FRigSingleParentElement, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigBoneElement");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigBoneElement()
		{
		}

		public static bool operator ==(FRigBoneElement A, FRigBoneElement B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigBoneElement A, FRigBoneElement B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigBoneElement;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERigBoneType BoneType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneType, __ReturnBuffer);

					return *(ERigBoneType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneType, __InBuffer);
				}
			}
		}

		private static uint __BoneType = 0;

	}
}