using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheDataBuffersLayout")]
	public partial class FNiagaraSimCacheDataBuffersLayout : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSimCacheDataBuffersLayout");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSimCacheDataBuffersLayout() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSimCacheDataBuffersLayout() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSimCacheDataBuffersLayout A, FNiagaraSimCacheDataBuffersLayout B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSimCacheDataBuffersLayout A, FNiagaraSimCacheDataBuffersLayout B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSimCacheDataBuffersLayout;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName LayoutName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayoutName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayoutName, __InBuffer);
				}
			}
		}

		public ENiagaraSimTarget SimTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SimTarget, __ReturnBuffer);

					return *(ENiagaraSimTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SimTarget, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraSimCacheVariable> Variables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variables, __ReturnBuffer);

					return *(TArray<FNiagaraSimCacheVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variables, __InBuffer);
				}
			}
		}

		public ushort FloatCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatCount, __InBuffer);
				}
			}
		}

		public ushort HalfCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HalfCount, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HalfCount, __InBuffer);
				}
			}
		}

		public ushort Int32Count
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Int32Count, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Int32Count, __InBuffer);
				}
			}
		}

		public bool bLocalSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bLocalSpace, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bLocalSpace, __InBuffer);
				}
			}
		}

		public bool bAllowInterpolation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowInterpolation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowInterpolation, __InBuffer);
				}
			}
		}

		public bool bAllowVelocityExtrapolation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowVelocityExtrapolation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowVelocityExtrapolation, __InBuffer);
				}
			}
		}

		public TArray<FName> RebaseVariableNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RebaseVariableNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RebaseVariableNames, __InBuffer);
				}
			}
		}

		public TArray<FName> InterpVariableNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpVariableNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpVariableNames, __InBuffer);
				}
			}
		}

		public ushort ComponentVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentVelocity, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentVelocity, __InBuffer);
				}
			}
		}

		private static uint __LayoutName = 0;

		private static uint __SimTarget = 0;

		private static uint __Variables = 0;

		private static uint __FloatCount = 0;

		private static uint __HalfCount = 0;

		private static uint __Int32Count = 0;

		private static uint __bLocalSpace = 0;

		private static uint __bAllowInterpolation = 0;

		private static uint __bAllowVelocityExtrapolation = 0;

		private static uint __RebaseVariableNames = 0;

		private static uint __InterpVariableNames = 0;

		private static uint __ComponentVelocity = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}