using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSimulationStageGroup")]
	public partial class UNiagaraStackSimulationStageGroup : UNiagaraStackScriptItemGroup, IStaticClass
	{
		public UNiagaraStackSimulationStagePropertiesItem SimulationStageProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimulationStageProperties, __ReturnBuffer);

					return *(UNiagaraStackSimulationStagePropertiesItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimulationStageProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSimulationStageGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SimulationStageProperties = 0;
	}
}