using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.BoneReferencePair")]
	public partial class FBoneReferencePair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationModifierLibrary.BoneReferencePair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoneReferencePair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoneReferencePair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoneReferencePair A, FBoneReferencePair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoneReferencePair A, FBoneReferencePair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoneReferencePair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference SourceBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceBone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceBone, __InBuffer);
				}
			}
		}

		public FBoneReference TargetBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetBone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetBone, __InBuffer);
				}
			}
		}

		private static uint __SourceBone = 0;

		private static uint __TargetBone = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}