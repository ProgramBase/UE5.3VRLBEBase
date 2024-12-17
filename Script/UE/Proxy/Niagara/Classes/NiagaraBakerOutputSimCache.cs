using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraBakerOutputSimCache")]
	public partial class UNiagaraBakerOutputSimCache : UNiagaraBakerOutput, IStaticClass
	{
		public FString SimCacheAssetPathFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimCacheAssetPathFormat, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimCacheAssetPathFormat, __InBuffer);
				}
			}
		}

		public FNiagaraSimCacheCreateParameters CreateParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParameters, __ReturnBuffer);

					return *(FNiagaraSimCacheCreateParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParameters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraBakerOutputSimCache");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SimCacheAssetPathFormat = 0;

		private static uint __CreateParameters = 0;
	}
}