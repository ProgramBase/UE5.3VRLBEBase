using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraHierarchyUserParameter")]
	public partial class UNiagaraHierarchyUserParameter : UNiagaraHierarchyItem, IStaticClass
	{
		public UNiagaraScriptVariable UserParameterScriptVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserParameterScriptVariable, __ReturnBuffer);

					return *(UNiagaraScriptVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserParameterScriptVariable, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraHierarchyUserParameter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UserParameterScriptVariable = 0;
	}
}