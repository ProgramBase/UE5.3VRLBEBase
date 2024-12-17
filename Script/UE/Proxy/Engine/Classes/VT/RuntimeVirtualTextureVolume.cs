using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeVirtualTextureVolume")]
	public partial class ARuntimeVirtualTextureVolume : AActor, IStaticClass
	{
		public URuntimeVirtualTextureComponent VirtualTextureComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureComponent, __ReturnBuffer);

					return *(URuntimeVirtualTextureComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureComponent, __InBuffer);
				}
			}
		}

		public UBoxComponent Box
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Box, __ReturnBuffer);

					return *(UBoxComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Box, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeVirtualTextureVolume");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VirtualTextureComponent = 0;

		private static uint __Box = 0;
	}
}