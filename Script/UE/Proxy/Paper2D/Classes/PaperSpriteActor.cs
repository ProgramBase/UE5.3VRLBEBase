using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperSpriteActor")]
	public partial class APaperSpriteActor : AActor, IStaticClass
	{
		public UPaperSpriteComponent RenderComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderComponent, __ReturnBuffer);

					return *(UPaperSpriteComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperSpriteActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RenderComponent = 0;
	}
}