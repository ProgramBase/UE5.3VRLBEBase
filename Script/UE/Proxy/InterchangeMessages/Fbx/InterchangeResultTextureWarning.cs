using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeMessages
{
	[PathName("/Script/InterchangeMessages.InterchangeResultTextureWarning")]
	public partial class UInterchangeResultTextureWarning : UInterchangeResultWarning, IStaticClass
	{
		public FString TextureName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeMessages.InterchangeResultTextureWarning");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextureName = 0;
	}
}