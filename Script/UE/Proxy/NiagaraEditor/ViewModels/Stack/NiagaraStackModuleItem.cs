using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackModuleItem")]
	public partial class UNiagaraStackModuleItem : UNiagaraStackItem, IStaticClass
	{
		public UNiagaraStackModuleItemLinkedInputCollection LinkedInputCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedInputCollection, __ReturnBuffer);

					return *(UNiagaraStackModuleItemLinkedInputCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedInputCollection, __InBuffer);
				}
			}
		}

		public UNiagaraStackFunctionInputCollection InputCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputCollection, __ReturnBuffer);

					return *(UNiagaraStackFunctionInputCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputCollection, __InBuffer);
				}
			}
		}

		public UNiagaraStackModuleItemOutputCollection OutputCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputCollection, __ReturnBuffer);

					return *(UNiagaraStackModuleItemOutputCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackModuleItem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LinkedInputCollection = 0;

		private static uint __InputCollection = 0;

		private static uint __OutputCollection = 0;
	}
}