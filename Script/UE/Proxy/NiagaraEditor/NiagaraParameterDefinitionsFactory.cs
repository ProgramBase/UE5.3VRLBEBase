using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterDefinitionsFactory")]
	public partial class UNiagaraParameterDefinitionsFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraParameterDefinitionsFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}