using Script.CoreUObject;
using Script.Library;
using Script.RigVM;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMCompiler")]
	public partial class URigVMCompiler : UObject, IStaticClass
	{
		public FRigVMCompileSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FRigVMCompileSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMDeveloper.RigVMCompiler");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool CompileVM(TArray<URigVMGraph> InGraphs, URigVMController InController, URigVM OutVM, ref FRigVMExtendedExecuteContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InGraphs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutVM?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __CompileVM, __InBuffer, __OutBuffer, __ReturnBuffer);

				Context = *(FRigVMExtendedExecuteContext*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Compile(TArray<URigVMGraph> InGraphs, URigVMController InController, URigVM OutVM)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InGraphs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutVM?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Compile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Settings = 0;

		private static uint __CompileVM = 0;

		private static uint __Compile = 0;
	}
}