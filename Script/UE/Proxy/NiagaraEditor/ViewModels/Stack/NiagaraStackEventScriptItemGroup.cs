using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEventScriptItemGroup")]
	public partial class UNiagaraStackEventScriptItemGroup : UNiagaraStackScriptItemGroup, IStaticClass
	{
		public UNiagaraStackEventHandlerPropertiesItem EventHandlerProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventHandlerProperties, __ReturnBuffer);

					return *(UNiagaraStackEventHandlerPropertiesItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventHandlerProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEventScriptItemGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EventHandlerProperties = 0;
	}
}