using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchySummaryDataRefreshContext")]
	public partial class UNiagaraHierarchySummaryDataRefreshContext : UNiagaraHierarchyDataRefreshContext, IStaticClass
	{
		public TArray<UNiagaraRendererProperties> Renderers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Renderers, __ReturnBuffer);

					return *(TArray<UNiagaraRendererProperties>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Renderers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchySummaryDataRefreshContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Renderers = 0;
	}
}