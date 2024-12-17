using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMBlueprintGeneratedClass")]
	public partial class URigVMBlueprintGeneratedClass : UBlueprintGeneratedClass, IStaticClass, IRigVMGraphFunctionHost
	{
		public FRigVMGraphFunctionStore GraphFunctionStore
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GraphFunctionStore, __ReturnBuffer);

					return *(FRigVMGraphFunctionStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GraphFunctionStore, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.RigVMBlueprintGeneratedClass");
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

		private static uint __GraphFunctionStore = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}