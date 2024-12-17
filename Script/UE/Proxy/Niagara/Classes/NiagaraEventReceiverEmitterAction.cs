using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEventReceiverEmitterAction")]
	public partial class UNiagaraEventReceiverEmitterAction : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraEventReceiverEmitterAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}