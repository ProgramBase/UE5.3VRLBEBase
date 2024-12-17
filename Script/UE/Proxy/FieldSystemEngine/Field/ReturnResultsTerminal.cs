using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.ReturnResultsTerminal")]
	public partial class UReturnResultsTerminal : UFieldNodeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.ReturnResultsTerminal");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UReturnResultsTerminal SetReturnResultsTerminal()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __SetReturnResultsTerminal, __ReturnBuffer);

				return *(UReturnResultsTerminal*)__ReturnBuffer;
			}
		}

		private static uint __SetReturnResultsTerminal = 0;
	}
}