using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyViewModelBase")]
	public partial class UNiagaraHierarchyViewModelBase : UObject, IStaticClass
	{
		public UNiagaraHierarchyRoot HierarchyRoot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyRoot, __ReturnBuffer);

					return *(UNiagaraHierarchyRoot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HierarchyRoot, __InBuffer);
				}
			}
		}

		public UNiagaraHierarchyDataRefreshContext RefreshContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RefreshContext, __ReturnBuffer);

					return *(UNiagaraHierarchyDataRefreshContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RefreshContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyViewModelBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HierarchyRoot = 0;

		private static uint __RefreshContext = 0;
	}
}