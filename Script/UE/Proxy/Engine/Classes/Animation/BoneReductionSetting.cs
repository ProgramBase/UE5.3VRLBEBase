using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoneReductionSetting")]
	public partial class FBoneReductionSetting : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BoneReductionSetting");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoneReductionSetting() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoneReductionSetting() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoneReductionSetting A, FBoneReductionSetting B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoneReductionSetting A, FBoneReductionSetting B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoneReductionSetting;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> BonesToRemove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BonesToRemove, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BonesToRemove, __InBuffer);
				}
			}
		}

		private static uint __BonesToRemove = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}