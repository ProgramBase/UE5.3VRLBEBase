using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ContentBundleEngineSubsystem")]
	public partial class UContentBundleEngineSubsystem : UEngineSubsystem, IStaticClass
	{
		public TSoftClassPtr<UContentBundleTypeFactory> ContentBundleTypeFactoryClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleTypeFactoryClass, __ReturnBuffer);

					return *(TSoftClassPtr<UContentBundleTypeFactory>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleTypeFactoryClass, __InBuffer);
				}
			}
		}

		public UContentBundleTypeFactory ContentBundleTypeFactory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleTypeFactory, __ReturnBuffer);

					return *(UContentBundleTypeFactory*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContentBundleTypeFactory, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ContentBundleEngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ContentBundleTypeFactoryClass = 0;

		private static uint __ContentBundleTypeFactory = 0;
	}
}