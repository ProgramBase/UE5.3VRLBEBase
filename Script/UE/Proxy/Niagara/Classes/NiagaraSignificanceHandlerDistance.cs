using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSignificanceHandlerDistance")]
	public partial class UNiagaraSignificanceHandlerDistance : UNiagaraSignificanceHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSignificanceHandlerDistance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}