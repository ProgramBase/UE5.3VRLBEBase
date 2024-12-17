using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEmitterPropertiesGroup")]
	public partial class UNiagaraStackEmitterPropertiesGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public UNiagaraStackEmitterPropertiesItem PropertiesItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesItem, __ReturnBuffer);

					return *(UNiagaraStackEmitterPropertiesItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertiesItem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEmitterPropertiesGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PropertiesItem = 0;
	}
}