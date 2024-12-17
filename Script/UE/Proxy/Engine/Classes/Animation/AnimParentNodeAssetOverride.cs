using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimParentNodeAssetOverride")]
	public partial class FAnimParentNodeAssetOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimParentNodeAssetOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimParentNodeAssetOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimParentNodeAssetOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimParentNodeAssetOverride A, FAnimParentNodeAssetOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimParentNodeAssetOverride A, FAnimParentNodeAssetOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimParentNodeAssetOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAnimationAsset NewAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewAsset, __ReturnBuffer);

					return *(UAnimationAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewAsset, __InBuffer);
				}
			}
		}

		public FGuid ParentNodeGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentNodeGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentNodeGuid, __InBuffer);
				}
			}
		}

		private static uint __NewAsset = 0;

		private static uint __ParentNodeGuid = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}