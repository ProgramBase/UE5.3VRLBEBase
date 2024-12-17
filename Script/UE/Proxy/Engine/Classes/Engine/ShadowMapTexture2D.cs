using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ShadowMapTexture2D")]
	public partial class UShadowMapTexture2D : UTexture2D, IStaticClass
	{
		public EShadowMapFlags ShadowmapFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowmapFlags, __ReturnBuffer);

					return *(EShadowMapFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowmapFlags, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ShadowMapTexture2D");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ShadowmapFlags = 0;
	}
}