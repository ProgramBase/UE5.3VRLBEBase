using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackSimulationStagePropertiesItem")]
	public partial class UNiagaraStackSimulationStagePropertiesItem : UNiagaraStackItem, IStaticClass
	{
		public UNiagaraStackObject SimulationStageObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimulationStageObject, __ReturnBuffer);

					return *(UNiagaraStackObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimulationStageObject, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackSimulationStagePropertiesItem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SimulationStageObject = 0;
	}
}