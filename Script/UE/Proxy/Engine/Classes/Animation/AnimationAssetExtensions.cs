using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationAssetExtensions")]
	public partial class UAnimationAssetExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationAssetExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InAsset">
		/// Animation Asset to retrieve the Skeleton for
		/// </param>
		/// <returns>
		/// The target USkeleton for the provided UAnimationAsset
		/// </returns>
		public static USkeleton GetSkeleton(UAnimationAsset InAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSkeleton, __InBuffer, __ReturnBuffer);

				return *(USkeleton*)__ReturnBuffer;
			}
		}

		private static uint __GetSkeleton = 0;
	}
}