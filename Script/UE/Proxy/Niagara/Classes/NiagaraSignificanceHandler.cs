using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSignificanceHandler")]
	public partial class UNiagaraSignificanceHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSignificanceHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}