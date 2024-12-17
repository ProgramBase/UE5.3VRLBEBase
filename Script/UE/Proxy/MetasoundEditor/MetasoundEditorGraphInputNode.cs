using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphInputNode")]
	public partial class UMetasoundEditorGraphInputNode : UMetasoundEditorGraphMemberNode, IStaticClass
	{
		public UMetasoundEditorGraphInput Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(UMetasoundEditorGraphInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphInputNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Input = 0;
	}
}