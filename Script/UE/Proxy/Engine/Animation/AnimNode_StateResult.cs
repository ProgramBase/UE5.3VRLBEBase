using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_StateResult")]
	public partial class FAnimNode_StateResult : FAnimNode_Root, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_StateResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_StateResult()
		{
		}

		public static bool operator ==(FAnimNode_StateResult A, FAnimNode_StateResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_StateResult A, FAnimNode_StateResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_StateResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int StateIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateIndex, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef StateEntryFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateEntryFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateEntryFunction, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef StateFullyBlendedInFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateFullyBlendedInFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateFullyBlendedInFunction, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef StateExitFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateExitFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateExitFunction, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef StateFullyBlendedOutFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateFullyBlendedOutFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateFullyBlendedOutFunction, __InBuffer);
				}
			}
		}

		private static uint __StateIndex = 0;

		private static uint __StateEntryFunction = 0;

		private static uint __StateFullyBlendedInFunction = 0;

		private static uint __StateExitFunction = 0;

		private static uint __StateFullyBlendedOutFunction = 0;

	}
}