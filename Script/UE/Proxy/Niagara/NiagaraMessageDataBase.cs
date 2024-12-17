using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraMessageDataBase")]
	public partial class UNiagaraMessageDataBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraMessageDataBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}