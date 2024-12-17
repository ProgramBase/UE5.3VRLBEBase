using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ButtonStyleAsset")]
	public partial class UButtonStyleAsset : UObject, IStaticClass
	{
		public FButtonStyle ButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ButtonStyle, __ReturnBuffer);

					return *(FButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ButtonStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ButtonStyleAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ButtonStyle = 0;
	}
}