using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultObjectArray")]
	public partial class UMetasoundEditorGraphMemberDefaultObjectArray : UMetasoundEditorGraphMemberDefaultLiteral, IStaticClass
	{
		public TArray<FMetasoundEditorGraphMemberDefaultObjectRef> Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(TArray<FMetasoundEditorGraphMemberDefaultObjectRef>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultObjectArray");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Default = 0;
	}
}