using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FunctionExpressionOutput")]
	public partial class FFunctionExpressionOutput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FunctionExpressionOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFunctionExpressionOutput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFunctionExpressionOutput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFunctionExpressionOutput A, FFunctionExpressionOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFunctionExpressionOutput A, FFunctionExpressionOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFunctionExpressionOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialExpressionFunctionOutput ExpressionOutput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionOutput, __ReturnBuffer);

					return *(UMaterialExpressionFunctionOutput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionOutput, __InBuffer);
				}
			}
		}

		public FGuid ExpressionOutputId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionOutputId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionOutputId, __InBuffer);
				}
			}
		}

		public FExpressionOutput Output
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Output, __ReturnBuffer);

					return *(FExpressionOutput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Output, __InBuffer);
				}
			}
		}

		private static uint __ExpressionOutput = 0;

		private static uint __ExpressionOutputId = 0;

		private static uint __Output = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}