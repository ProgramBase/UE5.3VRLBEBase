using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEmitterPropertiesItem")]
	public partial class UNiagaraStackEmitterPropertiesItem : UNiagaraStackItem, IStaticClass
	{
		public UNiagaraStackObject EmitterObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterObject, __ReturnBuffer);

					return *(UNiagaraStackObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterObject, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEmitterPropertiesItem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EmitterObject = 0;
	}
}