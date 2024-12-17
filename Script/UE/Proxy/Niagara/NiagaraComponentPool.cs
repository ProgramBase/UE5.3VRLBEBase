using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraComponentPool")]
	public partial class UNiagaraComponentPool : UObject, IStaticClass
	{
		public TMap<UNiagaraSystem, FNCPool> WorldParticleSystemPools
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldParticleSystemPools, __ReturnBuffer);

					return *(TMap<UNiagaraSystem, FNCPool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldParticleSystemPools, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraComponentPool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WorldParticleSystemPools = 0;
	}
}