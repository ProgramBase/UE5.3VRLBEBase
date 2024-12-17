using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.EdGraphSchema_Niagara")]
	public partial class UEdGraphSchema_Niagara : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.EdGraphSchema_Niagara");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}