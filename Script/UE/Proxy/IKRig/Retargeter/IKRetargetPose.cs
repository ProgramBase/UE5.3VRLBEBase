using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRetargetPose")]
	public partial class FIKRetargetPose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.IKRetargetPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRetargetPose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIKRetargetPose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIKRetargetPose A, FIKRetargetPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRetargetPose A, FIKRetargetPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRetargetPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector RootTranslationOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootTranslationOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootTranslationOffset, __InBuffer);
				}
			}
		}

		public TMap<FName, FQuat> BoneRotationOffsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneRotationOffsets, __ReturnBuffer);

					return *(TMap<FName, FQuat>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneRotationOffsets, __InBuffer);
				}
			}
		}

		private static uint __RootTranslationOffset = 0;

		private static uint __BoneRotationOffsets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}