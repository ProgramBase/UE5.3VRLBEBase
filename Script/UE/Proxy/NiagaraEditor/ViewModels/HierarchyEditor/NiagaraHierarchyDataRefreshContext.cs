using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyDataRefreshContext")]
	public partial class UNiagaraHierarchyDataRefreshContext : UObject, IStaticClass
	{
		public TMap<FNiagaraHierarchyIdentity, UObject> IdentityToObjectMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IdentityToObjectMap, __ReturnBuffer);

					return *(TMap<FNiagaraHierarchyIdentity, UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IdentityToObjectMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyDataRefreshContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __IdentityToObjectMap = 0;
	}
}