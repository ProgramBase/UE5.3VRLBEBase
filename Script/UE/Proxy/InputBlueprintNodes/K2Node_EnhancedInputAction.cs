using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputBlueprintNodes
{
	[PathName("/Script/InputBlueprintNodes.K2Node_EnhancedInputAction")]
	public partial class UK2Node_EnhancedInputAction : UK2Node, IStaticClass, IK2Node_EventNodeInterface
	{
		public UInputAction InputAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputBlueprintNodes.K2Node_EnhancedInputAction");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __InputAction = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}