using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceSpriteRendererInfo")]
	public partial class UNiagaraDataInterfaceSpriteRendererInfo : UNiagaraDataInterface, IStaticClass
	{
		public UNiagaraSpriteRendererProperties SpriteRenderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteRenderer, __ReturnBuffer);

					return *(UNiagaraSpriteRendererProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteRenderer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceSpriteRendererInfo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SpriteRenderer = 0;
	}
}