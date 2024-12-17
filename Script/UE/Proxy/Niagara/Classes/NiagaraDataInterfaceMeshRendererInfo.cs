using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceMeshRendererInfo")]
	public partial class UNiagaraDataInterfaceMeshRendererInfo : UNiagaraDataInterface, IStaticClass
	{
		public UNiagaraMeshRendererProperties MeshRenderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshRenderer, __ReturnBuffer);

					return *(UNiagaraMeshRendererProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshRenderer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceMeshRendererInfo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MeshRenderer = 0;
	}
}