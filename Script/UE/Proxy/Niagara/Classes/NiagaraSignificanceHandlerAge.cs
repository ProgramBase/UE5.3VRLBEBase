using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSignificanceHandlerAge")]
	public partial class UNiagaraSignificanceHandlerAge : UNiagaraSignificanceHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSignificanceHandlerAge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}