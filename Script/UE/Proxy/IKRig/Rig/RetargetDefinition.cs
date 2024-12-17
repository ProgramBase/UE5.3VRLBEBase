using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.RetargetDefinition")]
	public partial class FRetargetDefinition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.RetargetDefinition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRetargetDefinition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRetargetDefinition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRetargetDefinition A, FRetargetDefinition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRetargetDefinition A, FRetargetDefinition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRetargetDefinition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName RootBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootBone, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootBone, __InBuffer);
				}
			}
		}

		public TArray<FBoneChain> BoneChains
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneChains, __ReturnBuffer);

					return *(TArray<FBoneChain>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneChains, __InBuffer);
				}
			}
		}

		private static uint __RootBone = 0;

		private static uint __BoneChains = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}