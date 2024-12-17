using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraPythonModule")]
	public partial class UNiagaraPythonModule : UObject, IStaticClass
	{
		public UNiagaraStackModuleItem ModuleItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModuleItem, __ReturnBuffer);

					return *(UNiagaraStackModuleItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModuleItem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraPythonModule");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UNiagaraStackModuleItem GetObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObject, __ReturnBuffer);

				return *(UNiagaraStackModuleItem*)__ReturnBuffer;
			}
		}

		private static uint __ModuleItem = 0;

		private static uint __GetObject = 0;
	}
}