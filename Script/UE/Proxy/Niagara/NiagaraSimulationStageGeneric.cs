using Script.CoreUObject;
using Script.NiagaraCore;
using Script.NiagaraShader;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimulationStageGeneric")]
	public partial class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase, IStaticClass
	{
		public FNiagaraVariableAttributeBinding EnabledBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledBinding, __ReturnBuffer);

					return *(FNiagaraVariableAttributeBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnabledBinding, __InBuffer);
				}
			}
		}

		public ENiagaraIterationSource IterationSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IterationSource, __ReturnBuffer);

					return *(ENiagaraIterationSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IterationSource, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue NumIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumIterations, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumIterations, __InBuffer);
				}
			}
		}

		public ENiagaraSimStageExecuteBehavior ExecuteBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExecuteBehavior, __ReturnBuffer);

					return *(ENiagaraSimStageExecuteBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExecuteBehavior, __InBuffer);
				}
			}
		}

		public bool bDisablePartialParticleUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePartialParticleUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePartialParticleUpdate, __InBuffer);
				}
			}
		}

		public FNiagaraVariableDataInterfaceBinding DataInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataInterface, __ReturnBuffer);

					return *(FNiagaraVariableDataInterfaceBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataInterface, __InBuffer);
				}
			}
		}

		public bool bParticleIterationStateEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bParticleIterationStateEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bParticleIterationStateEnabled, __InBuffer);
				}
			}
		}

		public FNiagaraVariableAttributeBinding ParticleIterationStateBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleIterationStateBinding, __ReturnBuffer);

					return *(FNiagaraVariableAttributeBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleIterationStateBinding, __InBuffer);
				}
			}
		}

		public FIntPoint ParticleIterationStateRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleIterationStateRange, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleIterationStateRange, __InBuffer);
				}
			}
		}

		public bool bGpuDispatchForceLinear
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGpuDispatchForceLinear, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGpuDispatchForceLinear, __InBuffer);
				}
			}
		}

		public bool bOverrideGpuDispatchNumThreads
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideGpuDispatchNumThreads, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideGpuDispatchNumThreads, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsX, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsX, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsY, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsY, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsZ, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideGpuDispatchNumThreadsZ, __InBuffer);
				}
			}
		}

		public ENiagaraGpuDispatchType DirectDispatchType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectDispatchType, __ReturnBuffer);

					return *(ENiagaraGpuDispatchType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectDispatchType, __InBuffer);
				}
			}
		}

		public ENiagaraDirectDispatchElementType DirectDispatchElementType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectDispatchElementType, __ReturnBuffer);

					return *(ENiagaraDirectDispatchElementType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectDispatchElementType, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue ElementCountX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountX, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountX, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue ElementCountY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountY, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountY, __InBuffer);
				}
			}
		}

		public FNiagaraParameterBindingWithValue ElementCountZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountZ, __ReturnBuffer);

					return *(FNiagaraParameterBindingWithValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElementCountZ, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSimulationStageGeneric");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EnabledBinding = 0;

		private static uint __IterationSource = 0;

		private static uint __NumIterations = 0;

		private static uint __ExecuteBehavior = 0;

		private static uint __bDisablePartialParticleUpdate = 0;

		private static uint __DataInterface = 0;

		private static uint __bParticleIterationStateEnabled = 0;

		private static uint __ParticleIterationStateBinding = 0;

		private static uint __ParticleIterationStateRange = 0;

		private static uint __bGpuDispatchForceLinear = 0;

		private static uint __bOverrideGpuDispatchNumThreads = 0;

		private static uint __OverrideGpuDispatchNumThreadsX = 0;

		private static uint __OverrideGpuDispatchNumThreadsY = 0;

		private static uint __OverrideGpuDispatchNumThreadsZ = 0;

		private static uint __DirectDispatchType = 0;

		private static uint __DirectDispatchElementType = 0;

		private static uint __ElementCountX = 0;

		private static uint __ElementCountY = 0;

		private static uint __ElementCountZ = 0;
	}
}