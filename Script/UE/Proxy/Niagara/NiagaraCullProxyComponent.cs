using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraCullProxyComponent")]
	public partial class UNiagaraCullProxyComponent : UNiagaraComponent, IStaticClass
	{
		public TArray<FNiagaraCulledComponentInfo> Instances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instances, __ReturnBuffer);

					return *(TArray<FNiagaraCulledComponentInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instances, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraCullProxyComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Instances = 0;
	}
}