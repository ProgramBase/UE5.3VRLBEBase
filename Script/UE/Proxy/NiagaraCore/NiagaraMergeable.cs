using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraCore
{
	[PathName("/Script/NiagaraCore.NiagaraMergeable")]
	public partial class UNiagaraMergeable : UObject, IStaticClass
	{
		public FGuid MergeId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MergeId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MergeId, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraCore.NiagaraMergeable");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MergeId = 0;
	}
}