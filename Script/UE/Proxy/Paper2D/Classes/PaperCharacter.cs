using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperCharacter")]
	public partial class APaperCharacter : ACharacter, IStaticClass
	{
		public UPaperFlipbookComponent Sprite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sprite, __ReturnBuffer);

					return *(UPaperFlipbookComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sprite, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperCharacter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Sprite = 0;
	}
}