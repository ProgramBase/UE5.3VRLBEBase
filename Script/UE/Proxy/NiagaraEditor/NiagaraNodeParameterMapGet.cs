using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNodeParameterMapGet")]
	public partial class UNiagaraNodeParameterMapGet : UNiagaraNodeParameterMapBase, IStaticClass
	{
		public TMap<FGuid, FGuid> PinOutputToPinDefaultPersistentId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PinOutputToPinDefaultPersistentId, __ReturnBuffer);

					return *(TMap<FGuid, FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PinOutputToPinDefaultPersistentId, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraNodeParameterMapGet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PinOutputToPinDefaultPersistentId = 0;
	}
}