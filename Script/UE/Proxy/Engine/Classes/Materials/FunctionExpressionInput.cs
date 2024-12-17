using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FunctionExpressionInput")]
	public partial class FFunctionExpressionInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FunctionExpressionInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFunctionExpressionInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFunctionExpressionInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFunctionExpressionInput A, FFunctionExpressionInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFunctionExpressionInput A, FFunctionExpressionInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFunctionExpressionInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialExpressionFunctionInput ExpressionInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionInput, __ReturnBuffer);

					return *(UMaterialExpressionFunctionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionInput, __InBuffer);
				}
			}
		}

		public FGuid ExpressionInputId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionInputId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionInputId, __InBuffer);
				}
			}
		}

		public FExpressionInput Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		private static uint __ExpressionInput = 0;

		private static uint __ExpressionInputId = 0;

		private static uint __Input = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}