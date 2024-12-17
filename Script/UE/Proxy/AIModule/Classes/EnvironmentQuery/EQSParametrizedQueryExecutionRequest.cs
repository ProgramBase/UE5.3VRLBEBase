using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EQSParametrizedQueryExecutionRequest")]
	public partial class FEQSParametrizedQueryExecutionRequest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.EQSParametrizedQueryExecutionRequest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEQSParametrizedQueryExecutionRequest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEQSParametrizedQueryExecutionRequest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEQSParametrizedQueryExecutionRequest A, FEQSParametrizedQueryExecutionRequest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEQSParametrizedQueryExecutionRequest A, FEQSParametrizedQueryExecutionRequest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEQSParametrizedQueryExecutionRequest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UEnvQuery QueryTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QueryTemplate, __ReturnBuffer);

					return *(UEnvQuery*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QueryTemplate, __InBuffer);
				}
			}
		}

		public TArray<FAIDynamicParam> QueryConfig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QueryConfig, __ReturnBuffer);

					return *(TArray<FAIDynamicParam>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QueryConfig, __InBuffer);
				}
			}
		}

		public FBlackboardKeySelector EQSQueryBlackboardKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EQSQueryBlackboardKey, __ReturnBuffer);

					return *(FBlackboardKeySelector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EQSQueryBlackboardKey, __InBuffer);
				}
			}
		}

		public EEnvQueryRunMode RunMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RunMode, __ReturnBuffer);

					return *(EEnvQueryRunMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RunMode, __InBuffer);
				}
			}
		}

		public bool bUseBBKeyForQueryTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseBBKeyForQueryTemplate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseBBKeyForQueryTemplate, __InBuffer);
				}
			}
		}

		private static uint __QueryTemplate = 0;

		private static uint __QueryConfig = 0;

		private static uint __EQSQueryBlackboardKey = 0;

		private static uint __RunMode = 0;

		private static uint __bUseBBKeyForQueryTemplate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}