using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.K2Node_ExecutePythonScript")]
	public partial class UK2Node_ExecutePythonScript : UK2Node_CallFunction, IStaticClass
	{
		public TArray<FName> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public TArray<FName> Outputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Outputs, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Outputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.K2Node_ExecutePythonScript");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Inputs = 0;

		private static uint __Outputs = 0;
	}
}