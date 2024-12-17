using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerBoneBlendWeights")]
	public partial class FPerBoneBlendWeights : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerBoneBlendWeights");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerBoneBlendWeights() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerBoneBlendWeights() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerBoneBlendWeights A, FPerBoneBlendWeights B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerBoneBlendWeights A, FPerBoneBlendWeights B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerBoneBlendWeights;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPerBoneBlendWeight> BoneBlendWeights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneBlendWeights, __ReturnBuffer);

					return *(TArray<FPerBoneBlendWeight>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneBlendWeights, __InBuffer);
				}
			}
		}

		private static uint __BoneBlendWeights = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}