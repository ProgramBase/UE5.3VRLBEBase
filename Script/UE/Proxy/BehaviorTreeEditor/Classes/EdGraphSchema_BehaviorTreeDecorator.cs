using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.EdGraphSchema_BehaviorTreeDecorator")]
	public partial class UEdGraphSchema_BehaviorTreeDecorator : UEdGraphSchema, IStaticClass
	{
		public FString PC_Boolean
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PC_Boolean, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PC_Boolean, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.EdGraphSchema_BehaviorTreeDecorator");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PC_Boolean = 0;
	}
}