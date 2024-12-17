using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphVariable")]
	public partial class UMetasoundEditorGraphVariable : UMetasoundEditorGraphMember, IStaticClass
	{
		public FGuid VariableID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VariableID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VariableID, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphVariable");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VariableID = 0;
	}
}