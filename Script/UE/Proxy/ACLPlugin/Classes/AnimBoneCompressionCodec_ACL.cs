using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimBoneCompressionCodec_ACL")]
	public partial class UAnimBoneCompressionCodec_ACL : UAnimBoneCompressionCodec_ACLBase, IStaticClass
	{
		public TArray<USkeletalMesh> OptimizationTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OptimizationTargets, __ReturnBuffer);

					return *(TArray<USkeletalMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OptimizationTargets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimBoneCompressionCodec_ACL");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OptimizationTargets = 0;
	}
}