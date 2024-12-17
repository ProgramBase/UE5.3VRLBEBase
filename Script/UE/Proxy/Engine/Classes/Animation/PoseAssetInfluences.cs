using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PoseAssetInfluences")]
	public partial class FPoseAssetInfluences : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PoseAssetInfluences");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPoseAssetInfluences() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPoseAssetInfluences() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPoseAssetInfluences A, FPoseAssetInfluences B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPoseAssetInfluences A, FPoseAssetInfluences B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPoseAssetInfluences;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPoseAssetInfluence> Influences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Influences, __ReturnBuffer);

					return *(TArray<FPoseAssetInfluence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Influences, __InBuffer);
				}
			}
		}

		private static uint __Influences = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}