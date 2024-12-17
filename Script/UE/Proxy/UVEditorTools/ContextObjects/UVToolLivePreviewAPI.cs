using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.InteractiveToolsFramework;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolLivePreviewAPI")]
	public partial class UUVToolLivePreviewAPI : UUVToolContextObject, IStaticClass
	{
		public TWeakObjectPtr<UWorld> World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(TWeakObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UInputRouter> InputRouter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputRouter, __ReturnBuffer);

					return *(TWeakObjectPtr<UInputRouter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputRouter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolLivePreviewAPI");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __World = 0;

		private static uint __InputRouter = 0;
	}
}