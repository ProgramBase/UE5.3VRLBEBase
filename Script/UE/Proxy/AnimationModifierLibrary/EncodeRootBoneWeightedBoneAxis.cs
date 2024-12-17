using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.EncodeRootBoneWeightedBoneAxis")]
	public partial class FEncodeRootBoneWeightedBoneAxis : FEncodeRootBoneWeightedBone, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationModifierLibrary.EncodeRootBoneWeightedBoneAxis");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEncodeRootBoneWeightedBoneAxis()
		{
		}

		public static bool operator ==(FEncodeRootBoneWeightedBoneAxis A, FEncodeRootBoneWeightedBoneAxis B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEncodeRootBoneWeightedBoneAxis A, FEncodeRootBoneWeightedBoneAxis B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEncodeRootBoneWeightedBoneAxis;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EEncodeRootBoneAxis BoneAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneAxis, __ReturnBuffer);

					return *(EEncodeRootBoneAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneAxis, __InBuffer);
				}
			}
		}

		private static uint __BoneAxis = 0;

	}
}