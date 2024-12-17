using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.EncodeRootBoneWeightedBone")]
	public partial class FEncodeRootBoneWeightedBone : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationModifierLibrary.EncodeRootBoneWeightedBone");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEncodeRootBoneWeightedBone() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEncodeRootBoneWeightedBone() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEncodeRootBoneWeightedBone A, FEncodeRootBoneWeightedBone B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEncodeRootBoneWeightedBone A, FEncodeRootBoneWeightedBone B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEncodeRootBoneWeightedBone;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference Bone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __InBuffer);
				}
			}
		}

		public float Weight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __InBuffer);
				}
			}
		}

		private static uint __Bone = 0;

		private static uint __Weight = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}